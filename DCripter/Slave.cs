using CryptoProviders;
using DataAccess;
using Management;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DCripter
{
    public partial class Slave : Form
    {
        CryptoController controller = new CryptoController();
        XMLActionsRSA rsaXML = new XMLActionsRSA();
        XMLActionsTDES tdesXML = new XMLActionsTDES();

        KeysGenerator keys = new KeysGenerator();
        Master referencedMaster;
        public Slave(Master master)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(745, 64);
            this.referencedMaster = master;
        }

        private void Slave_Load(object sender, EventArgs e)
        {

        }

        private void importRsaSlaveButton_Click(object sender, EventArgs e)
        {
            String path = openFileExplorer("Open encrypted tdes file: tdesencriptado.xml");
            String[] encryptedTdes = tdesXML.getEncryptedTdes(path);
            this.tdesKey.Text = "TDES 1: " + encryptedTdes[1] + Environment.NewLine + "TDES 2: " + encryptedTdes[2]
                + Environment.NewLine + "TDES 3: " + encryptedTdes[3] + Environment.NewLine + "TDES IV: " + encryptedTdes[0];


        }

        private void rsaSlaveKeyValueLabel_Click(object sender, EventArgs e)
        {

        }

        public void publicKeyValueLabel_Click(object sender, EventArgs e)
        {

        }

        public void ChangeLabel(String[] value)
        {
            publicKeyBox.Text = value[0];
            privateKeyBox.Text = value[1];
        }

        public string publicKeyValueLabelMethod
        {
            get
            {
                return this.publicKeyBox.Text;
            }
            set
            {
                this.publicKeyBox.Text = value;
            }
        }

        private void generateRsaKeysButton_Click(object sender, EventArgs e)
        {
            String[] keyPar = controller.getRSA();
            privateKeyBox.Text = keyPar[0];
            publicKeyBox.Text = keyPar[1];
            referencedMaster.ChangeLabel(keyPar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = openSaveFileExplorer("Save slave public key", "cp_esclavo.xml");
            rsaXML.generateRsaXML(path);
            MessageBox.Show("Tu archivo se guardo como cp_esclavo.xml en " + path, "Informacion importante", MessageBoxButtons.OK);

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

        private void button2_Click(object sender, EventArgs e)
        {
            String[] desencryptedTdes = controller.desencryptTdes();

            this.decryptedTdes.Text = "TDES 1: " + desencryptedTdes[1] + Environment.NewLine + "TDES 2: " + desencryptedTdes[2] 
                + Environment.NewLine + "TDES 3: " + desencryptedTdes[3] + Environment.NewLine + "TDES IV: " + desencryptedTdes[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String encryptedText = controller.encryptWithTDES(textToEncrypt.Text);
            encryptedTextBox.Text = "Texto encriptado: " + encryptedText; 
                }

        private void button4_Click(object sender, EventArgs e)
        {
            String path = openSaveFileExplorer("Save encripted text", "textoencriptado.xml");
            tdesXML.exportEncryptedText(path);
            MessageBox.Show("Tu archivo se guardo como textoencriptado.xml en " + path, "Informacion importante", MessageBoxButtons.OK);   
        }
    }
}

