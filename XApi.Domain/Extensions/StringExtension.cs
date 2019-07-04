using System.Text;

namespace XApi.Domain.Extensions
{
    public static class StringExtension
    {
        public static string ConvertToMD5(this string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "";
            }
            var passWord = (password+="|12d331cc-f6c0-40c0-bb43-6e32-989c2881");
            var MD5 = System.Security.Cryptography.MD5.Create();
            var data = MD5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
            {
                sbString.Append(t.ToString("x2"));
            }
            return sbString.ToString();
        }
    }
}
