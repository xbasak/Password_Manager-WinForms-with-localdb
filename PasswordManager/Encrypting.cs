using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager
{
    public class Encrypting
    {
        public Encrypting() { }

        public static string Encrypt(string plainText, string encryptionKey)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] key = GetValidKey(encryptionKey);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();
                using (var ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);
                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string Decrypt(string encryptedText, string encryptionKey)
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(encryptedText);
                byte[] key = GetValidKey(encryptionKey);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    using (var ms = new MemoryStream(cipherBytes))
                    {
                        byte[] iv = new byte[16];
                        ms.Read(iv, 0, iv.Length);
                        aes.IV = iv;
                        using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            byte[] plainBytes = new byte[cipherBytes.Length - iv.Length];
                            int decryptedCount = cs.Read(plainBytes, 0, plainBytes.Length);
                            return Encoding.UTF8.GetString(plainBytes, 0, decryptedCount);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string GenerateKey()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[32];
                rng.GetBytes(key);
                return Convert.ToBase64String(key);
            }
        }

        private static byte[] GetValidKey(string encryptionKey)
        {
            byte[] key = Encoding.UTF8.GetBytes(encryptionKey);
            if (key.Length < 32)
            {
                Array.Resize(ref key, 32);
            }
            else if (key.Length > 32)
            {
                Array.Resize(ref key, 32);
            }
            return key;
        }
    }
}
