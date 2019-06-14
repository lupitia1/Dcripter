using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KeyProviders
{
    class TDESProviderService : KeyProviderService
    {
        String[] tdesValues = new String[3];

        public string[] generateKey()
        {
            try
            {
                // Create 3DES that generates a new key and initialization vector (IV).  
                // Same key must be used in encryption and decryption  
                using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
                {
                    string cleanTdes = BitConverter.ToString(tdes.Key).Replace("-", "");

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
    }
}
