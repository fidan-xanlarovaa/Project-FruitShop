using System.Security.Cryptography;
using System.Text;

namespace Blog.Shared.Extentions
{
    public static class PasswordHasher
    {
        // admin1234s@1t 1aqw1jbuaihsabausuasbuavs
        public static string HashPassword(this string password)
        {
            if (password == null)
            { return null; }
            password += "s@1t"; //parolun gucunu artirmaq ucun elave edirik

            byte[] bytes = Encoding.UTF8.GetBytes(password); //bu passwordu bize bytlar seklinde geri qaytarir

            var sha1 = SHA1.Create();//bu guid olaraq randomly passwordu hash formasina salir ki, databadeni qiran hcker, userin passworduu gore bilmesin

            byte[] hashBytes = sha1.ComputeHash(bytes);

            return HexStringFromBytes(hashBytes);
        }

        private static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
    }
}
