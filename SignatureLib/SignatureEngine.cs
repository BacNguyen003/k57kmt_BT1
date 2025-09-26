using System;

namespace SignatureLib
{
    public class SignatureEngine
    {
        private string _fullName;
        private DateTime _birthDate;
        // KHÔNG dùng _seed nữa

        // Overload MỚI: 2 tham số (chuẩn bạn đang dùng)
        public void SetInput(string fullName, DateTime birthDate)
        {
            _fullName = fullName;
            _birthDate = birthDate;
        }

        // (Tuỳ chọn) Giữ overload cũ 3 tham số để không lỗi các nơi còn gọi kiểu cũ
        public void SetInput(string fullName, DateTime birthDate, int seed)
        {
            // Bỏ qua seed, chỉ gọi về overload 2 tham số
            SetInput(fullName, birthDate);
        }

        public string GetSlug()
        {
            string s = _fullName.ToLower();
            s = s.Replace(" ", "-");
            return s;
        }

        public int GetNumericId()
        {
            return (_fullName.Length * 100 + _birthDate.Year) % 99999999;
        }

        public string[] GetPattern3x3()
        {
            string[] pattern = new string[3];
            Random rnd = new Random(_fullName.Length + _birthDate.Day + _birthDate.Month);
            for (int i = 0; i < 3; i++)
            {
                string row = "";
                for (int j = 0; j < 3; j++)
                    row += rnd.Next(2) == 0 ? "*" : ".";
                pattern[i] = row;
            }
            return pattern;
        }

        public string GetLuckyColorHex()
        {
            int hash = _fullName.Length * 31 + _birthDate.Day + _birthDate.Month + _birthDate.Year;
            Random rnd = new Random(hash);
            int r = rnd.Next(256), g = rnd.Next(256), b = rnd.Next(256);
            return String.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        public string GetMotto()
        {
            string[] mottos = new string[]
            {
                "Sống như chính mình.",
                "Học, học nữa, học mãi.",
                "Luôn tiến về phía trước.",
                "Đừng bỏ cuộc.",
                "Sáng tạo là dấu ấn cá nhân."
            };
            int idx = (_fullName.Length + _birthDate.Day) % mottos.Length;
            return mottos[idx];
        }
    }
}
