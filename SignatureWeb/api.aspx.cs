using System;
using System.Web;
using System.Web.UI;
using SignatureLib;

namespace SignatureWeb
{
    public partial class api : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json; charset=utf-8";

            // Lấy input
            string fullName = (Request["fullName"] ?? "").Trim();
            string dobText = (Request["dob"] ?? "").Trim();

            // Parse ngày sinh dd/MM/yyyy
            DateTime birthDate;
            if (!DateTime.TryParseExact(
                    dobText,
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out birthDate))
            {
                birthDate = new DateTime(2000, 1, 1); // fallback
            }

            // Gọi DLL
            var engine = new SignatureEngine();
            engine.SetInput(fullName, birthDate);

            // Lấy dữ liệu
            string slug = engine.GetSlug();
            int numId = engine.GetNumericId();
            string motto = engine.GetMotto();
            string pattern = string.Join("\n", engine.GetPattern3x3()); // chuỗi có \n
            string color = engine.GetLuckyColorHex();

            // Build JSON thủ công (an toàn ký tự)
            string json =
                "{"
                + "\"slug\":\"" + J(slug) + "\","
                + "\"numericId\":" + numId.ToString() + ","
                + "\"motto\":\"" + J(motto) + "\","
                + "\"pattern\":\"" + J(pattern) + "\","
                + "\"color\":\"" + J(color) + "\""
                + "}";

            Response.Write(json);
            Response.End();
        }

        // Escape JSON đơn giản cho .NET 2.0
        private static string J(string s)
        {
            if (s == null) return "";
            s = s.Replace("\\", "\\\\");
            s = s.Replace("\"", "\\\"");
            s = s.Replace("\r", "");
            s = s.Replace("\n", "\\n");
            return s;
        }
    }
}
