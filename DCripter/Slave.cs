using CryptoProviders;
using DataAccess;
using Management;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DCripter
{
    public partial class Slave : Form
    {
        CryptoController controller = new CryptoController();
        XMLActionsRSA rsaXML = new XMLActionsRSA();

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

        }

        private void rsaSlaveKeyValueLabel_Click(object sender, EventArgs e)
        {

        }

        public void publicKeyValueLabel_Click(object sender, EventArgs e)
        {

        }

        public void ChangeLabel(String[] value)
        {
            publicKeyValueLabel.Text = value[0];
            privateKeyValueLabel.Text = value[1];
        }

        public string publicKeyValueLabelMethod
        {
            get
            {
                return this.publicKeyValueLabel.Text;
            }
            set
            {
                this.publicKeyValueLabel.Text = value;
            }
        }

        private void generateRsaKeysButton_Click(object sender, EventArgs e)
        {
            String[] keyPar = controller.getRSA();
            privateKeyValueLabel.Text = keyPar[0];
            publicKeyValueLabel.Text = keyPar[1];
            referencedMaster.ChangeLabel(keyPar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rsaXML.generateRsaXML();
            //keys.generateRsaXML();
        }
    }
}
