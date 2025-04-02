using System;
using System.Linq;

namespace Semester6LiamKleinhalle.Helpers
{
    public static class EncryptionFunctions
    {
        // Charset voor encryptie en decryptie
        private const string Charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string Encrypt(string input, int key)
        {
            return new string(input.Select(c =>
            {
                int index = Charset.IndexOf(c);
                return index >= 0 ? Charset[(index + key) % Charset.Length] : c;
            }).ToArray());
        }

        public static string Decrypt(string input, int key)
        {
            return new string(input.Select(c =>
            {
                int index = Charset.IndexOf(c);
                return index >= 0 ? Charset[(index - key + Charset.Length) % Charset.Length] : c;
            }).ToArray());
        }
    }
}
