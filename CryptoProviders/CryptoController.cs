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
        TDESProviderService tdesProvider = new TDESProviderService();

        public String[] getRSA() {

            String[] keyPar = rsaProvider.generateKey();

            return keyPar;
        }

        public String[] getTDES()
        {

            String[] tdesValues = tdesProvider.generateKey();

            return tdesValues;
        }
    }
}
