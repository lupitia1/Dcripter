using CryptoProviders;
using DataAccess;
using Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCripter
{
    public partial class Master : Form
    {
        CryptoController controller = new CryptoController();
        XMLActionsRSA rsaXML = new XMLActionsRSA();
        XMLActionsTDES tdesXML = new XMLActionsTDES();
        KeysGenerator keys;
        Slave referencedSlave;

        public Master()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(61, 64);
        }

        public void saveReference(Slave slave)
        {
            referencedSlave = slave;   
        }

        public void ChangeLabel(String[] value)
        {
            publicKeyBox.Text = value[0];
            privateKeyBox.Text = value[1];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            keys = new KeysGenerator();
        }

        private void keyLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textToDecryptLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String[] tdesValues = controller.getTDES();

            this.tdesKey.Text = "TDES 1: " + tdesValues[1] + Environment.NewLine + "TDES 2: " + tdesValues[2]
               + Environment.NewLine + "TDES 3: " + tdesValues[3] + Environment.NewLine + "TDES IV: " + tdesValues[0];
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String path = openFileExplorer("Import RSA Slave File: cp_esclavo.xml");
            String RsaValue = rsaXML.ReadRsa(path);
            this.slaveRsaPublicKey.Text = RsaValue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateRsaKeysButton_Click(object sender, EventArgs e)
        {
            String[] keyPar = controller.getRSA();
            privateKeyBox.Text = keyPar[0];
            publicKeyBox.Text = keyPar[1];
            referencedSlave.ChangeLabel(keyPar);

        }

        private void encryptTdesKeyButton_Click(object sender, EventArgs e)
        {
            String[] encryptedTdesValues = controller.encryptWithRSA();
            try
            {
                this.encryptedTdesBox.Text = "TDES 1: " + encryptedTdesValues[1] + Environment.NewLine + "TDES 2: " + encryptedTdesValues[2] 
                    + Environment.NewLine + "TDES 3: " + encryptedTdesValues[3] + Environment.NewLine + "TDES IV: " + encryptedTdesValues[0];
            }
            catch {

            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            String path = openSaveFileExplorer("Save encrypted tdes", "tdesencriptado.xml");
            tdesXML.generateEncryptedTdesXML(path);
            MessageBox.Show("Tu archivo se guardo como tdesencriptado.xml en " + path, "Informacion importante", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String path = openFileExplorer("Open encrypted text file: textoencriptado.xml");
            String encryptedTextFromXml = tdesXML.readEncryptedTextXml(path);
            this.encryptedText.Text = encryptedTextFromXml;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String desencryptedText = controller.desencryptWithTdes();
            this.desencryptedText.Text = desencryptedText;
        }

        public static string openSaveFileExplorer(string title, string filename)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = title,

                DefaultExt = "xml",
                FileName = filename,
                Filter = "xml files (.xml)|.xml",
                FilterIndex = 2,
                OverwritePrompt = true,
                RestoreDirectory = true,
                ValidateNames = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                return saveFileDialog1.FileName;
            else
                return "No se ha seleccionado ningún archivo";

        }
        public string openFileExplorer(string title)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = title,

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                //Filter = "xml files (.xml)|.xml",
                //FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return "No se ha seleccionado ningún archivo";
            }
        }

    }
}
