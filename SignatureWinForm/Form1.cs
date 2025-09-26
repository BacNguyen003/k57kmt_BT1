using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SignatureLib;

namespace SignatureWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // txtDob là ô nhập ngày: KHÔNG đặt multiline/readonly/hiển thị mật khẩu
            txtDob.UseSystemPasswordChar = false;
            txtDob.PasswordChar = '\0';
            txtDob.Multiline = false;
            txtDob.ReadOnly = false;

            // txtPattern là ô hiển thị pattern 3x3 (multiline, chỉ đọc)
            if (this.Controls.ContainsKey("txtPattern"))
            {
                txtDob.Multiline = true;
                txtDob.ReadOnly = true;
                txtDob.Font = new Font("Consolas", 9f);
                txtDob.Text = string.Empty;
            }
        }

        // các handler rỗng có thể giữ nguyên hoặc xóa
        private void label1_Click(object sender, EventArgs e) { }
        private void lblDobTitle_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Giữ prefix tiếng Việt và chỉ gán phần giá trị sau dấu ":"
            void SetValueWithPrefix(Label lbl, string value)
            {
                string prefix = lbl.Text ?? "";
                int idx = prefix.IndexOf(':');
                if (idx >= 0) prefix = prefix.Substring(0, idx + 1) + " ";
                else if (prefix.Length > 0) prefix = prefix.Trim() + ": ";
                lbl.Text = prefix + value;
            }

            // 1) Input
            string fullName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng nhập Họ tên.", "Thiếu thông tin");
                txtName.Focus(); return;
            }

            if (!DateTime.TryParseExact(
                    txtDob.Text.Trim(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out DateTime birthDate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (định dạng dd/MM/yyyy).", "Lỗi nhập liệu");
                txtDob.Focus(); return;
            }

            // 2) DLL
            var engine = new SignatureEngine();
            engine.SetInput(fullName, birthDate);

            // 3) Kết quả
            SetValueWithPrefix(lblSlug, engine.GetSlug());
            SetValueWithPrefix(lblNumericId, engine.GetNumericId().ToString());
            SetValueWithPrefix(lblMotto, engine.GetMotto());

            // 4) Pattern 3x3 -> hiển thị ở txtPattern (KHÔNG đụng vào txtDob)
            if (this.Controls.ContainsKey("txtPattern"))
            {
                txtDob.Text = string.Join(Environment.NewLine, engine.GetPattern3x3());
            }

            // 5) Màu may mắn
            string hex = engine.GetLuckyColorHex();
            pnlColor.BackColor = ColorTranslator.FromHtml(hex);
            if (this.Controls.ContainsKey("lblColorHex"))
            {
                var l = this.Controls["lblColorHex"] as Label;
                if (l != null) l.Text = hex;
            }
        }
    }
}
