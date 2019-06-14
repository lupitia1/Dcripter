using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProviders
{
    public class CryptoController
    {
        RSAProviderService rsaProvider = new RSAProviderService();

        public String[] getRSA() {

            String[] keyPar = rsaProvider.generateKey();

            return keyPar;
        }
    }
}
