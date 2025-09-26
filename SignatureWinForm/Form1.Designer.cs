namespace SignatureWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblDobTitle = new System.Windows.Forms.Label();
            this.lblSlug = new System.Windows.Forms.Label();
            this.lblNumericId = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColorTitle = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(29, 18);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(42, 13);
            this.lblNameTitle.TabIndex = 0;
            this.lblNameTitle.Text = "Họ tên:";
            this.lblNameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDobTitle
            // 
            this.lblDobTitle.AutoSize = true;
            this.lblDobTitle.Location = new System.Drawing.Point(29, 44);
            this.lblDobTitle.Name = "lblDobTitle";
            this.lblDobTitle.Size = new System.Drawing.Size(126, 13);
            this.lblDobTitle.TabIndex = 1;
            this.lblDobTitle.Text = "Ngày sinh (dd/MM/yyyy):";
            this.lblDobTitle.Click += new System.EventHandler(this.lblDobTitle_Click);
            // 
            // lblSlug
            // 
            this.lblSlug.AutoSize = true;
            this.lblSlug.Location = new System.Drawing.Point(29, 69);
            this.lblSlug.Name = "lblSlug";
            this.lblSlug.Size = new System.Drawing.Size(48, 13);
            this.lblSlug.TabIndex = 2;
            this.lblSlug.Text = "Bí danh:";
            // 
            // lblNumericId
            // 
            this.lblNumericId.AutoSize = true;
            this.lblNumericId.Location = new System.Drawing.Point(29, 91);
            this.lblNumericId.Name = "lblNumericId";
            this.lblNumericId.Size = new System.Drawing.Size(39, 13);
            this.lblNumericId.TabIndex = 3;
            this.lblNumericId.Text = "Mã số:";
            // 
            // lblMotto
            // 
            this.lblMotto.AutoSize = true;
            this.lblMotto.Location = new System.Drawing.Point(29, 114);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(64, 13);
            this.lblMotto.TabIndex = 4;
            this.lblMotto.Text = "Châm ngôn:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(32, 145);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Khởi tạo";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(32, 218);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(200, 100);
            this.pnlColor.TabIndex = 9;
            // 
            // lblColorTitle
            // 
            this.lblColorTitle.AutoSize = true;
            this.lblColorTitle.Location = new System.Drawing.Point(32, 199);
            this.lblColorTitle.Name = "lblColorTitle";
            this.lblColorTitle.Size = new System.Drawing.Size(76, 13);
            this.lblColorTitle.TabIndex = 11;
            this.lblColorTitle.Text = "Màu may mắn:";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(162, 36);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(100, 20);
            this.txtDob.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.lblColorTitle);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.lblNumericId);
            this.Controls.Add(this.lblSlug);
            this.Controls.Add(this.lblDobTitle);
            this.Controls.Add(this.lblNameTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblDobTitle;
        private System.Windows.Forms.Label lblSlug;
        private System.Windows.Forms.Label lblNumericId;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblColorTitle;
        private System.Windows.Forms.MaskedTextBox txtDob;
    }
}