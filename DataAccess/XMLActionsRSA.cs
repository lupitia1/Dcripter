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

        public void generateRsaXML(String path) {
            XDocument document = new XDocument();
            document.Add(new XElement("root", new XElement("clavepublica", rsaProvider.keyPar[1])));
            document.Save(path);
        }

        public string ReadRsa(String path)
        {
            StringBuilder result = new StringBuilder();

            foreach (XElement level1Element in XElement.Load(path).Elements("clavepublica"))
            {

                result.AppendLine(level1Element.Value);
                rsaProvider.slaveStringPublicKey = level1Element.Value;
            }

            return result.ToString();
        }
    }
}
