namespace DCripter
{
    partial class Slave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateRsaKeysButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.publicKeyLabel2 = new System.Windows.Forms.Label();
            this.privateKeyLabel1 = new System.Windows.Forms.Label();
            this.exportXmlButton = new System.Windows.Forms.Button();
            this.importRsaSlaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textToEncrypt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.decryptedTdes = new System.Windows.Forms.TextBox();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.publicKeyBox = new System.Windows.Forms.TextBox();
            this.tdesKey = new System.Windows.Forms.TextBox();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generateRsaKeysButton
            // 
            this.generateRsaKeysButton.Location = new System.Drawing.Point(16, 77);
            this.generateRsaKeysButton.Name = "generateRsaKeysButton";
            this.generateRsaKeysButton.Size = new System.Drawing.Size(140, 42);
            this.generateRsaKeysButton.TabIndex = 28;
            this.generateRsaKeysButton.Text = "Generar claves RSA";
            this.generateRsaKeysButton.UseVisualStyleBackColor = true;
            this.generateRsaKeysButton.Click += new System.EventHandler(this.generateRsaKeysButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Esclavo";
            // 
            // publicKeyLabel2
            // 
            this.publicKeyLabel2.AutoSize = true;
            this.publicKeyLabel2.Location = new System.Drawing.Point(178, 63);
            this.publicKeyLabel2.Name = "publicKeyLabel2";
            this.publicKeyLabel2.Size = new System.Drawing.Size(72, 13);
            this.publicKeyLabel2.TabIndex = 30;
            this.publicKeyLabel2.Text = "Clave Pública";
            // 
            // privateKeyLabel1
            // 
            this.privateKeyLabel1.AutoSize = true;
            this.privateKeyLabel1.Location = new System.Drawing.Point(178, 117);
            this.privateKeyLabel1.Name = "privateKeyLabel1";
            this.privateKeyLabel1.Size = new System.Drawing.Size(73, 13);
            this.privateKeyLabel1.TabIndex = 29;
            this.privateKeyLabel1.Text = "Clave Privada";
            // 
            // exportXmlButton
            // 
            this.exportXmlButton.Location = new System.Drawing.Point(467, 69);
            this.exportXmlButton.Name = "exportXmlButton";
            this.exportXmlButton.Size = new System.Drawing.Size(73, 58);
            this.exportXmlButton.TabIndex = 34;
            this.exportXmlButton.Text = "Exportar xml RSA ";
            this.exportXmlButton.UseVisualStyleBackColor = true;
            this.exportXmlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // importRsaSlaveButton
            // 
            this.importRsaSlaveButton.Location = new System.Drawing.Point(16, 169);
            this.importRsaSlaveButton.Name = "importRsaSlaveButton";
            this.importRsaSlaveButton.Size = new System.Drawing.Size(140, 42);
            this.importRsaSlaveButton.TabIndex = 35;
            this.importRsaSlaveButton.Text = "Importar clave TDES de fichero XML";
            this.importRsaSlaveButton.UseVisualStyleBackColor = true;
            this.importRsaSlaveButton.Click += new System.EventHandler(this.importRsaSlaveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 37;
            this.button2.Text = "Desencriptar TDES de fichero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Introducir texto:";
            // 
            // textToEncrypt
            // 
            this.textToEncrypt.Location = new System.Drawing.Point(162, 358);
            this.textToEncrypt.Name = "textToEncrypt";
            this.textToEncrypt.Size = new System.Drawing.Size(298, 20);
            this.textToEncrypt.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 42);
            this.button3.TabIndex = 41;
            this.button3.Text = "Encriptar texto algoritmo TDES y clave TDES desencriptada";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 42);
            this.button4.TabIndex = 43;
            this.button4.Text = "Exportar mensaje a xml";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // decryptedTdes
            // 
            this.decryptedTdes.Location = new System.Drawing.Point(259, 236);
            this.decryptedTdes.Multiline = true;
            this.decryptedTdes.Name = "decryptedTdes";
            this.decryptedTdes.ReadOnly = true;
            this.decryptedTdes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptedTdes.Size = new System.Drawing.Size(201, 73);
            this.decryptedTdes.TabIndex = 47;
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(259, 107);
            this.privateKeyBox.Multiline = true;
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.ReadOnly = true;
            this.privateKeyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.privateKeyBox.Size = new System.Drawing.Size(201, 47);
            this.privateKeyBox.TabIndex = 52;
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.Location = new System.Drawing.Point(259, 42);
            this.publicKeyBox.Multiline = true;
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.ReadOnly = true;
            this.publicKeyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.publicKeyBox.Size = new System.Drawing.Size(201, 47);
            this.publicKeyBox.TabIndex = 51;
            // 
            // tdesKey
            // 
            this.tdesKey.Location = new System.Drawing.Point(259, 169);
            this.tdesKey.Multiline = true;
            this.tdesKey.Name = "tdesKey";
            this.tdesKey.ReadOnly = true;
            this.tdesKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tdesKey.Size = new System.Drawing.Size(201, 47);
            this.tdesKey.TabIndex = 53;
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(79, 465);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ReadOnly = true;
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedTextBox.Size = new System.Drawing.Size(201, 73);
            this.encryptedTextBox.TabIndex = 54;
            // 
            // Slave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 604);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.tdesKey);
            this.Controls.Add(this.privateKeyBox);
            this.Controls.Add(this.publicKeyBox);
            this.Controls.Add(this.decryptedTdes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textToEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.importRsaSlaveButton);
            this.Controls.Add(this.exportXmlButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.publicKeyLabel2);
            this.Controls.Add(this.privateKeyLabel1);
            this.Controls.Add(this.generateRsaKeysButton);
            this.Name = "Slave";
            this.Text = "Slave";
            this.Load += new System.EventHandler(this.Slave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateRsaKeysButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label publicKeyLabel2;
        private System.Windows.Forms.Label privateKeyLabel1;
        private System.Windows.Forms.Button exportXmlButton;
        private System.Windows.Forms.Button importRsaSlaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textToEncrypt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox decryptedTdes;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.TextBox publicKeyBox;
        private System.Windows.Forms.TextBox tdesKey;
        private System.Windows.Forms.TextBox encryptedTextBox;
    }
}