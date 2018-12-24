using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace encryption
{
    class aes_256
    {
        public static byte[] CreateKey(string Password, string Salt = "HenkCrypter") => new Rfc2898DeriveBytes(Password, Encoding.UTF8.GetBytes(Salt)).GetBytes(32);

        public static byte[] Decrypt(byte[] Data, string Key)=> Decrypt(Data, CreateKey(Key));
        public static byte[] Decrypt(byte[] Data, byte[] Key)
        {
            using (var Provider = Aes.Create())
            {
                Provider.Key = Key;
                using (var ms = new MemoryStream(Data))
                {
                    byte[] iv = new byte[16];
                    ms.Read(iv, 0, 16);
                    Provider.IV = iv;

                    using (var Decryptor = Provider.CreateDecryptor(Provider.Key, Provider.IV))
                    {
                        using (var cs = new CryptoStream(ms, Decryptor, CryptoStreamMode.Read))
                        {
                            byte[] Decrypted = new byte[Data.Length];
                            var byteCount = cs.Read(Decrypted, 0, Data.Length);
                            return new MemoryStream(Decrypted, 0, byteCount).ToArray();
                        }
                    }
                }
            }
        }
    }
}