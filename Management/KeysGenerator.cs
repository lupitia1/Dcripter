using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Management
{
    public class KeysGenerator
    {/*
        RSAParameters privateKey;
        RSAParameters publicKey;
        String[] keyPar = new string[2];
        String[] tdesValues = new String[3];

        public String[] generateRSA()
        {
            try
            {

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512))
                {
                    privateKey = RSA.ExportParameters(true);
                    publicKey = RSA.ExportParameters(false);

                    keyPar[0] = RSA.ToXmlString(true);
                    keyPar[1] = RSA.ToXmlString(false);

                    //Console.WriteLine();
                    //var x = new XmlSerializer(textp.GetType());
                    //x.Serialize(Console.Out, textp);
                    //Console.WriteLine();
                }
            }
            catch (ArgumentNullException)
            {
                //Catch this exception in case the encryption did
                //not succeed.
                Console.WriteLine("Encryption failed.");

            }

            return keyPar;
        }

        public String[] GenerateTDES()
        {
            try
            {
                // Create 3DES that generates a new key and initialization vector (IV).  
                // Same key must be used in encryption and decryption  
                using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
                {
                    string cleanTdes = BitConverter.ToString(tdes.Key).Replace("-","" );

                    tdesValues[0] = cleanTdes;
                    tdesValues[1] = BitConverter.ToString(tdes.IV);

                    
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return tdesValues;

        }

        public void generateRsaXML()
        {

            XDocument document = new XDocument();
            document.Add(new XElement("root", new XElement("clavepublica", keyPar[1])));
            document.Save("cp_esclavo.xml");

        }

        public void GenerateTdesXML()
        {
            throw new NotImplementedException();
        }

        public String ReadRsa()
        {

            StringBuilder result = new StringBuilder();

            foreach (XElement level1Element in XElement.Load("cp_esclavo.xml").Elements("clavepublica"))
            {

                result.AppendLine(level1Element.Value);

            }

            return result.ToString();
        }
*/
    }
}