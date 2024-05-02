using System;
using System.Linq;
using System.Text;

namespace BusinessTraining
{
    public static class CryptoHelper
    {
        const int prefixLength = 5;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        static string version = "$1$";
        static Random random = new Random();
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private static string GeneratePrefix()
        {
            return new string(Enumerable.Repeat(chars, prefixLength).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string DeletePrefix(string stringWithPrefix)
        {
            return stringWithPrefix.Substring(version.Length + prefixLength);
        }

        public static string Encrypt(string plainString)
        {
            string encodedJsonString = Base64Encode(plainString);
            string randomString = GeneratePrefix();
            return version + randomString + encodedJsonString;
        }

        public static string Decrypt(string encryptedString)
        {
            string encodedString = DeletePrefix(encryptedString);
            return Base64Decode(encodedString);
        }
    }
}
