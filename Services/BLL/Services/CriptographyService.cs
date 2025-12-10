using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public static class CriptographyService
    {
        public static string HashMd5(string textPlainPass)
        {
            StringBuilder sb = new StringBuilder();

            using (MD5 md5 = MD5.Create())
            {
                byte[] retVal = md5.ComputeHash(Encoding.Unicode.GetBytes(textPlainPass));
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
            }
            return sb.ToString();
        }

        private static string encryptionKey = ConfigurationManager.AppSettings["ClaveEncriptacion"];
        public static string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(encryptor.IV, 0, encryptor.IV.Length);

                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.FlushFinalBlock();
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            cipherText = cipherText.Replace(" ", "+");
            int paddingNeeded = cipherText.Length % 4;
            if (paddingNeeded > 0)
            {
                paddingNeeded = 4 - paddingNeeded;
                cipherText = cipherText.PadRight(cipherText.Length + paddingNeeded, '=');
            }

            try
            {
                byte[] fullCipherBytes = Convert.FromBase64String(cipherText);
                if (fullCipherBytes.Length < 16)
                {
                    throw new CryptographicException("La longitud de los datos cifrados es insuficiente (falta el IV).");
                }

                byte[] iv = new byte[16];
                Array.Copy(fullCipherBytes, 0, iv, 0, 16);

                using (MemoryStream cipherStream = new MemoryStream())
                {
                    cipherStream.Write(fullCipherBytes, 16, fullCipherBytes.Length - 16);
                    cipherStream.Seek(0, SeekOrigin.Begin);

                    using (Aes encryptor = Aes.Create())
                    {
                        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                        encryptor.Key = pdb.GetBytes(32);

                        encryptor.IV = iv;

                        using (CryptoStream cs = new CryptoStream(cipherStream, encryptor.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                cs.CopyTo(ms);

                                return Encoding.Unicode.GetString(ms.ToArray());
                            }
                        }
                    }
                }
            }
            catch (CryptographicException ex)
            {
                throw new Exception($"Error criptográfico: Falló la desencriptación (posiblemente clave/IV incorrectos o datos truncados). Mensaje original: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error en el sistema al desencriptar: {ex.Message}");
            }
        }
    }
}
