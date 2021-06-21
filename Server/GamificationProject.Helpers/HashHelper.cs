using System;
using System.Security.Cryptography;
using System.Text;

namespace GamificationProject.Helpers
{
    public static class HashHelper
    {
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = new SHA256Managed();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            return GetString(GetHash(inputString));
        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in data)
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
