using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoProviders
{
    public class CryptoController
    {
        RSAProviderService rsaProvider = RSAProviderService.Instance;
        TDESProviderService tdesProvider = TDESProviderService.Instance;

        public String[] getRSA() {

            String[] keyPar = rsaProvider.generateKey();

            return keyPar;
        }

        public String[] getTDES()
        {

            String[] tdesValues = tdesProvider.generateKey();

            return tdesValues;
        }

        public String[] encryptWithRSA()
        {
            String[] encryptedTdesValues = rsaProvider.encryptTDES(tdesProvider.tdesValues);

            return encryptedTdesValues;
        }

        public String[] desencryptTdes()
        {
            String[] desencryptedTdes = rsaProvider.desencryptTdes();
            return desencryptedTdes;
        }

        public String encryptWithTDES(string text)
        {
            String [] keyArray = rsaProvider.desencryptTdes();
            String encryptedText = tdesProvider.encryptWithTDES(text, keyArray);
            return encryptedText;
        }

        public String desencryptWithTdes()
        {
            //String encryptedText = tdesProvider.encryptedTextFromXml;
            String desencryptedText = tdesProvider.desencryptWithTDES();

            return desencryptedText;
        }

    }
}
