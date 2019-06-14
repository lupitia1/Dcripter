using CryptoProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public class XMLActionsRSA : XMLActions
    {
        RSAProviderService rsaProvider = RSAProviderService.Instance;

        public void generateRsaXML() {
            XDocument document = new XDocument();
            document.Add(new XElement("root", new XElement("clavepublica", rsaProvider.keyPar[1])));
            document.Save("cp_esclavo.xml");
        }
    }
}
