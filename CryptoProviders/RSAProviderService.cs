using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace CryptoProviders
{
    public class RSAProviderService : IProviderService
    {
        private static readonly Lazy<RSAProviderService> instance = new Lazy<RSAProviderService>(() => new RSAProviderService());

        private RSAProviderService()
        {

        }

        // Propiedad para acceder a la instancia
        public static RSAProviderService Instance
        {
            get
            {
                return instance.Value;
            }
        }

        RSAParameters privateKey { set; get; }
        RSAParameters publicKey { set; get; }
        public String slaveStringPublicKey { set; get; }
        public String[] keyPar = new string[2];
        public String[] encryptedTdesValues = new String[4];
        public String[] encryptedXmlTdesValues = new string[4];
        public String[] desencryptedTdesValues = new string[4];
        public byte[] decryptedData;


        public String[] desencryptTdes()
        {
            
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512))
            {
                RSA.ImportParameters(privateKey);
                byte[] tdes1 = getBytesFromHex(encryptedXmlTdesValues[1]);
                byte[] tdes2 = getBytesFromHex(encryptedXmlTdesValues[2]);
                byte[] tdes3 = getBytesFromHex(encryptedXmlTdesValues[3]);
                byte[] tdesIv = getBytesFromHex(encryptedXmlTdesValues[0]);

                desencryptedTdesValues[1] = BitConverter.ToString(RSA.Decrypt(tdes1, true));
                desencryptedTdesValues[2] = BitConverter.ToString(RSA.Decrypt(tdes2, true));
                desencryptedTdesValues[3] = BitConverter.ToString(RSA.Decrypt(tdes3, true));
                desencryptedTdesValues[0] = BitConverter.ToString(RSA.Decrypt(tdesIv, true));

            }
            return desencryptedTdesValues;

        }

         public static byte[] getBytesFromHex(String toHexString) {
            if (toHexString.Length % 2 !=0) {
                throw new ArgumentException();
            }

            byte[] data = new byte[toHexString.Length / 2];

            for (int index = 0; index < data.Length; index++) {
                string byteValue = toHexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber);
            }

            return data;
        }

        public string[] generateKey()
        {
            try
            {
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512);
                 privateKey = RSA.ExportParameters(true);
                 publicKey = RSA.ExportParameters(false);

                    keyPar[0] = RSA.ToXmlString(true);
                    keyPar[1] = RSA.ToXmlString(false);

                    //Console.WriteLine();
                    //var x = new XmlSerializer(textp.GetType());
                    //x.Serialize(Console.Out, textp);
                    //Console.WriteLine();
                
            }
            catch (ArgumentNullException)
            {
        
            }

            return keyPar;
        }

        public String[] encryptTDES(String[] tdesValues)
        {
            try
            {
                RSACryptoServiceProvider RSA2 = new RSACryptoServiceProvider(512);
                RSA2.FromXmlString(slaveStringPublicKey);

                byte[] encrypted0 = RSA2.Encrypt(getBytesFromHex(tdesValues[0]), true);
                byte[] encrypted1 = RSA2.Encrypt(getBytesFromHex(tdesValues[1]), true);
                byte[] encrypted2 = RSA2.Encrypt(getBytesFromHex(tdesValues[2]), true);
                byte[] encrypted3 = RSA2.Encrypt(getBytesFromHex(tdesValues[3]), true);

                encryptedTdesValues[0] = (ByteArrayToHex(encrypted0).Replace("-", ""));
                encryptedTdesValues[1] = (ByteArrayToHex(encrypted1).Replace("-", ""));
                encryptedTdesValues[2] = (ByteArrayToHex(encrypted2).Replace("-", ""));
                encryptedTdesValues[3] = (ByteArrayToHex(encrypted3).Replace("-", ""));

                //ENCRIPTAR TDES CON RSA
                //Console.WriteLine(encryptedTdesValues[0]);
                //Console.WriteLine(BitConverter.ToString(encryptedTdesValues[1]).Replace("-", ""));
                //Console.WriteLine(BitConverter.ToString(encryptedTdesValues[2]).Replace("-", ""));
                //Console.WriteLine(BitConverter.ToString(encryptedTdesValues[3]).Replace("-", ""));

                return encryptedTdesValues;

            }
            catch
            {
                return null;
            }
        }


        public static string ByteArrayToHex(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
