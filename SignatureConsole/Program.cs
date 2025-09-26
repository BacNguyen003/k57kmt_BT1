using System;
using System.Globalization;
using System.Text;
using SignatureLib;

namespace SignatureConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Để Console in tiếng Việt không lỗi font
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=====================================");
            Console.WriteLine("   SIGNATURE MAKER - by <YourBrand>");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // Nhập dữ liệu
            Console.Write("Họ tên: ");
            string fullName = Console.ReadLine();

            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            string dobText = Console.ReadLine();

            DateTime birthDate;
            try
            {
                birthDate = DateTime.ParseExact(dobText, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Ngày sinh không hợp lệ. Mặc định 01/01/2000.");
                birthDate = new DateTime(2000, 1, 1);
            }

            // Gọi DLL (SignatureLib)
            SignatureEngine engine = new SignatureEngine();
            engine.SetInput(fullName, birthDate); // overload 2 tham số

            // Hiển thị kết quả
            Console.WriteLine();
            Console.WriteLine("KẾT QUẢ:");
            Console.WriteLine("Slug        : " + engine.GetSlug());
            Console.WriteLine("NumericId   : " + engine.GetNumericId());

            Console.WriteLine("Pattern 3x3 :");
            foreach (string row in engine.GetPattern3x3())
            {
                Console.WriteLine("  " + row);
            }

            Console.WriteLine("Lucky Color : " + engine.GetLuckyColorHex());
            Console.WriteLine("Motto       : " + engine.GetMotto());

            Console.WriteLine();
            Console.WriteLine("Nhấn Enter để thoát...");
            Console.ReadLine();
        }
    }
}
