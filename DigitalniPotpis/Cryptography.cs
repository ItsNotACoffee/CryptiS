using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

public class Cryptography
{
    public class Asymmetric
    {
        private static int keySize = 4096;
        public static void CreateKeys(out string publicKey, out string privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);

            byte[] publicBytes = Encoding.UTF8.GetBytes(rsa.ToXmlString(false));
            byte[] privateBytes = Encoding.UTF8.GetBytes(rsa.ToXmlString(true));

            publicKey = Convert.ToBase64String(publicBytes);
            privateKey = Convert.ToBase64String(privateBytes);
        }

        public static byte[] Encrypt(string dataToEncrypt, string publicKey)
        {
            string publicKeyReadable = Encoding.UTF8.GetString(Convert.FromBase64String(publicKey));

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);
            rsa.FromXmlString(publicKeyReadable);
            byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(dataToEncrypt), false);

            return encryptedData;
        }

        public static string Decrypt(byte[] cipherText, string privateKey)
        {
            string privateKeyReadable = Encoding.UTF8.GetString(Convert.FromBase64String(privateKey));

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);
            rsa.FromXmlString(privateKey);
            byte[] decryptedData = rsa.Decrypt(cipherText, false);

            return Encoding.UTF8.GetString(decryptedData);
        }
    }

    public class Symmetric
    {
        public static string CreateKey()
        {
            Rijndael rijAlg = Rijndael.Create();
            rijAlg.KeySize = 256;
            rijAlg.Mode = CipherMode.CBC;
            rijAlg.Padding = PaddingMode.PKCS7;
            rijAlg.GenerateKey();
            string key = Convert.ToBase64String(rijAlg.Key);
            return key;
        }

        public static byte[] Encrypt (string dataToEncrypt, byte[] Key)
        {
            // Check arguments.
            if (dataToEncrypt == null || dataToEncrypt.Length <= 0)
                throw new ArgumentNullException("dataToEncrypt");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            using (Rijndael rijAlg = Rijndael.Create())
            {
                byte[] encBytes = Encoding.UTF8.GetBytes(dataToEncrypt);

                //set all properties
                rijAlg.KeySize = 256;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.Key = Key;

                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(rijAlg.IV, 0, 16); //embed IV into stream
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(encBytes, 0, encBytes.Length);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
            return encrypted;
        }

        public static string Decrypt (byte[] cipherText, byte[] Key)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");

            string plainText;

            using (Rijndael rijAlg = Rijndael.Create())
            {
                //set all properties
                rijAlg.KeySize = 256;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.Key = Key;

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    //Get IV - First 16 bytes
                    byte[] iv = new byte[16];
                    msDecrypt.Read(iv, 0, 16);
                    rijAlg.IV = iv;

                    ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        byte[] decrypted = new byte[cipherText.Length];
                        var byteCount = csDecrypt.Read(decrypted, 0, cipherText.Length);
                        plainText = Encoding.UTF8.GetString(decrypted, 0, byteCount);
                    }
                }
            }
            return plainText;
        }
    }
}