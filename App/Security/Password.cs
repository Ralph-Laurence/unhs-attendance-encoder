using System;
using System.Security.Cryptography;
using System.Text;

namespace UNHS_Attendance_Encoder_Net48.App.Security
{
    internal class Password
    {
        private const int SaltSize = 16; // 128 bit

        public static string Make(string plain)
        {
            // Generate a salt
            byte[] salt = GenerateSalt();

            // Hash the plain password along with the salt
            string hashedPassword = HashPassword(plain, salt);

            // Combine the salt and hashed password for storage
            return $"{Convert.ToBase64String(salt)}:{hashedPassword}";
        }

        public static bool Verify(string enteredPassword, string storedPassword)
        {
            // Split the stored password into salt and hash
            var parts = storedPassword.Split(':');
            byte[] salt = Convert.FromBase64String(parts[0]);
            string storedHash = parts[1];

            // Hash the entered password with the same salt
            string enteredHash = HashPassword(enteredPassword, salt);

            // Compare the hashes
            return storedHash == enteredHash;
        }

        private static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);
                return salt;
            }
        }

        private static string HashPassword(string password, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] combined = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[combined.Length + salt.Length];

                Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
                Buffer.BlockCopy(combined, 0, saltedPassword, salt.Length, combined.Length);

                byte[] hash = sha256.ComputeHash(saltedPassword);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
