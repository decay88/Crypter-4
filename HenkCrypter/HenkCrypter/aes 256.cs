using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace encryption
{
    class aes_256
    {
        public static byte[] CreateKey(string Password, string Salt = "HenkCrypter") => new Rfc2898DeriveBytes(Password, Encoding.UTF8.GetBytes(Salt)).GetBytes(32);

        public static byte[] Encrypt(string Text, string Key) =>Encrypt(Encoding.UTF8.GetBytes(Text), CreateKey(Key));
        public static byte[] Encrypt(byte[] Data, byte[] Key)
        {
            using (var Provider = Aes.Create())
            {
                Provider.Key = Key;
                Provider.GenerateIV();

                using (var encryptor = Provider.CreateEncryptor(Provider.Key, Provider.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(Provider.IV, 0, 16);
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(Data, 0, Data.Length);
                            cs.FlushFinalBlock();
                        }
                        return ms.ToArray();
                    }
                }
            }
        }
    }
}