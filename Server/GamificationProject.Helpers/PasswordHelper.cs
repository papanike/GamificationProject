using GamificationProject.Interfaces;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace GamificationProject.Helpers
{
    public static class PasswordHelper
    {
        private const int _saltSize = 16;

        public static void GenerateHashes(ISecureUser user, string password)
        {
            user.PasswordSalt = GenerateSalt();
            user.PasswordHash = GenerateSaltedHash(HashHelper.GetBytes(password), user.PasswordSalt);
        }

        public static bool ValidatePass(ISecureUser user, string password)
        {
            var hash = GenerateSaltedHash(HashHelper.GetBytes(password), user.PasswordSalt);
            return Enumerable.SequenceEqual(hash, user.PasswordHash);
        }

        #region [ Helpers ]

        private static byte[] GenerateSalt()
        {
            var salt = new byte[_saltSize];
            new RNGCryptoServiceProvider().GetBytes(salt);
            return salt;
        }

        private static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] plainTextWithSaltBytes = new byte[plainText.Length + salt.Length];

            Buffer.BlockCopy(salt, 0, plainTextWithSaltBytes, 0, _saltSize / 4);
            Buffer.BlockCopy(plainText, 0, plainTextWithSaltBytes, _saltSize / 4, plainText.Length);
            Buffer.BlockCopy(salt, _saltSize / 4, plainTextWithSaltBytes, _saltSize / 4 + plainText.Length, _saltSize * 3 / 4);

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        #endregion
    }
}
