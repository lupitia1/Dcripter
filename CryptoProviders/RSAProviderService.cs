using System;
using System.Security.Cryptography;

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
        public String[] keyPar = new string[2];

        public string[] generateKey()
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
    }
}
