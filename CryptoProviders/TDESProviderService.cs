using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoProviders
{
    public class TDESProviderService : IProviderService
    {
        private static readonly Lazy<TDESProviderService> instance = new Lazy<TDESProviderService>(() => new TDESProviderService());

        private TDESProviderService()
        {

        }

        // Propiedad para acceder a la instancia
        public static TDESProviderService Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public String[] tdesValues { set; get; }  = new String[4];
        public byte[] originalTdes { set; get; }
        public byte[] originalIV{ set; get; }
        public String encryptedText { set; get; }
        public String encryptedTextFromXml { set; get; }

        public string[] generateKey()
        {
            try
            {
                // Create 3DES that generates a new key and initialization vector (IV).  
                // Same key must be used in encryption and decryption  
                
                   

                    

                   /* tdesValues[0] = cleanIV;
                    tdesValues[1] = cleanTdes.Substring(0, 16);
                    tdesValues[2] = cleanTdes.Substring(16, 16);
                    tdesValues[3] = cleanTdes.Substring(32, 16);
                    */
                    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                originalTdes = tdes.Key;
                originalIV = tdes.IV;
                //string cleanTdes = BitConverter.ToString(tdes.Key).Replace("-", "");
                //string cleanIV = BitConverter.ToString(tdes.IV).Replace("-", "");

                byte[] key = tdes.Key;
                    tdesValues[1] = ByteArrayToHex(getSubset(key, 0, 8));
                    tdesValues[2] = ByteArrayToHex(getSubset(key, 8, 8));
                    tdesValues[3] = ByteArrayToHex(getSubset(key, 16, 8));
                    tdesValues[0] = ByteArrayToHex(tdes.IV);

                
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return tdesValues;

        }

        public static string ByteArrayToHex(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static byte[] getSubset(byte[] array, int skip, int get)
        {
            int length = get + skip;
            length = length > array.Length ? array.Length : length;
            byte[] response = new byte[get];
            int c = 0;
            for (int i = skip; i < length; i++)
            {
                response[c] = array[i];
                c++;
            }
            return response;
        }


        internal String desencryptWithTDES()
        {
            byte[] Data = getBytesFromHex(encryptedTextFromXml);
            Console.WriteLine(ByteArrayToHex(Data));
            byte[] Key = this.originalTdes;
            byte[] IV = this.originalIV;

            try
            {
                MemoryStream msDecrypt = new MemoryStream(Data);
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    new TripleDESCryptoServiceProvider().CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);
                byte[] fromEncrypt = new byte[Data.Length];
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
                return new ASCIIEncoding().GetString(fromEncrypt);
            }
            catch 
            {
               // MessageBox.Show($"Algo salio mal: {e.ToString()}", "Error", MessageBoxButtons.OK);
                return null;
            }


        }

        internal String encryptWithTDES(string text, String[] keyArray)
        {
            try
            {
                String tdesKeyString = keyArray[1].Replace("-","") + keyArray[2].Replace("-", "") + keyArray[3].Replace("-", "");
                byte[] tdesBytesKey = getBytesFromHex(tdesKeyString);

                String tdesIV = keyArray[0].Replace("-", "");
                byte[] tdesIvBytes = getBytesFromHex(tdesIV);

                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream,
                    new TripleDESCryptoServiceProvider().CreateEncryptor(tdesBytesKey, tdesIvBytes),
                    CryptoStreamMode.Write);
                byte[] toEncrypt = new ASCIIEncoding().GetBytes(text);
                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();
                byte[] ret = mStream.ToArray();
                cStream.Close();
                mStream.Close();
                encryptedText = BitConverter.ToString(ret).Replace("-", "");
                return BitConverter.ToString(ret).Replace("-","");

            }
            catch
            {
                //MessageBox.Show($"Algo salio mal: {e.ToString()}", "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public static byte[] getBytesFromHex(String toHexString)
        {

       
            if (toHexString.Length % 2 != 0)
            {
                throw new ArgumentException();
            }

            byte[] data = new byte[toHexString.Length / 2];

            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = toHexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return data;
        }
    }
}
