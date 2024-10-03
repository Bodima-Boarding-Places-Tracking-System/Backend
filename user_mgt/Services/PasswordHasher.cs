using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;

namespace user_mgt.Services
{
    public class PasswordHasher : IPasswordHasher<string>
    {
        private const int SaltSize = 128 / 8;
        private const int KeySize = 256 / 8;
        private const int Iterations = 10000;
        private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA256;
        private const char Delimiter = ';';

        public string HashPassword(string user, string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, _hashAlgorithmName, KeySize);
            return string.Join(Delimiter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public PasswordVerificationResult VerifyHashedPassword(string user, string hashedPassword, string providedPassword)
        {
            var parts = hashedPassword.Split(Delimiter);
            if (parts.Length != 2)
            {
                return PasswordVerificationResult.Failed;
            }

            var salt = Convert.FromBase64String(parts[0]);
            var hash = Convert.FromBase64String(parts[1]);

            var newHash = Rfc2898DeriveBytes.Pbkdf2(providedPassword, salt, Iterations, _hashAlgorithmName, KeySize);

            if (CryptographicOperations.FixedTimeEquals(newHash, hash))
            {
                return PasswordVerificationResult.Success;
            }

            return PasswordVerificationResult.Failed;
        }
    }
}