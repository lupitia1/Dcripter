using CryptoProviders;
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
            publicKeyValueLabel.Text = value[0];
            privateKeyValueLabel.Text = value[1];
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
            this.TdesKeyValueLabel.Text = tdesValues[0] ;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String RsaValue = keys.ReadRsa();
            this.rsaSlaveKeyValueLabel.Text = RsaValue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateRsaKeysButton_Click(object sender, EventArgs e)
        {
            String[] keyPar = controller.getRSA();
            privateKeyValueLabel.Text = keyPar[0];
            publicKeyValueLabel.Text = keyPar[1];
            referencedSlave.ChangeLabel(keyPar);

        }

        private void encryptTdesKeyButton_Click(object sender, EventArgs e)
        {
            keys.GenerateTdesXML();
        }
    }
}
