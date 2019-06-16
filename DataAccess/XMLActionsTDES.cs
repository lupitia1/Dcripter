using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using CryptoProviders;

namespace DataAccess
{
    public class XMLActionsTDES : XMLActions
    {
        TDESProviderService tdesProvider = TDESProviderService.Instance;
        RSAProviderService rsaProvider = RSAProviderService.Instance;

        public void generateEncryptedTdesXML(String path)
        {
            XDocument document = new XDocument();
            document.Add(new XElement("root", new XElement("tdes1", rsaProvider.encryptedTdesValues[1]),
                                              new XElement("tdes2", rsaProvider.encryptedTdesValues[2]),
                                              new XElement("tdes3", rsaProvider.encryptedTdesValues[3]),
                                              new XElement("iv", rsaProvider.encryptedTdesValues[0])));
            document.Save(path);
        }

        public String[] getEncryptedTdes(String path)
        {

             String[] encryptedTdes  = new String[4];
             StringBuilder result = new StringBuilder();
          
            foreach (XElement level1Element in XElement.Load(path).Elements("tdes1"))
            {
                encryptedTdes[1] = level1Element.Value.ToString();
            }

            foreach (XElement level1Element in XElement.Load(path).Elements("tdes2"))
            {

                encryptedTdes[2] = level1Element.Value.ToString();
            }

            foreach (XElement level1Element in XElement.Load(path).Elements("tdes3"))
            {

                encryptedTdes[3] = level1Element.Value.ToString();
            }

            foreach (XElement level1Element in XElement.Load(path).Elements("iv"))
            {


                encryptedTdes[0] = level1Element.Value.ToString();
            }

            rsaProvider.encryptedXmlTdesValues = encryptedTdes;

           return encryptedTdes;
        }

        public void exportEncryptedText(String path)
        {
            String encryptedText = tdesProvider.encryptedText;

            XDocument document = new XDocument();
            document.Add(new XElement("root", new XElement("textoe", encryptedText)));
            document.Save(path);
        }

        public String readEncryptedTextXml(String path)
        {
            StringBuilder result = new StringBuilder();

            foreach (XElement level1Element in XElement.Load(path).Elements("textoe"))
            {

                result.AppendLine(level1Element.Value);
                tdesProvider.encryptedTextFromXml = level1Element.Value.ToString();
            }

            return result.ToString();
        }
    }
}

