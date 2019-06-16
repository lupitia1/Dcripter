namespace DCripter
{
    partial class Master
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.privateKeyLabel1 = new System.Windows.Forms.Label();
            this.publicKeyLabel2 = new System.Windows.Forms.Label();
            this.generateTdesButton = new System.Windows.Forms.Button();
            this.encryptTdesKeyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptedText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.desencryptedText = new System.Windows.Forms.Label();
            this.importRsaSlaveButton = new System.Windows.Forms.Button();
            this.generateRsaKeysButton = new System.Windows.Forms.Button();
            this.encryptedTdesBox = new System.Windows.Forms.TextBox();
            this.publicKeyBox = new System.Windows.Forms.TextBox();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.slaveRsaPublicKey = new System.Windows.Forms.TextBox();
            this.tdesKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // privateKeyLabel1
            // 
            this.privateKeyLabel1.AutoSize = true;
            this.privateKeyLabel1.Location = new System.Drawing.Point(178, 117);
            this.privateKeyLabel1.Name = "privateKeyLabel1";
            this.privateKeyLabel1.Size = new System.Drawing.Size(73, 13);
            this.privateKeyLabel1.TabIndex = 3;
            this.privateKeyLabel1.Text = "Clave Privada";
            this.privateKeyLabel1.Click += new System.EventHandler(this.keyLabel_Click);
            // 
            // publicKeyLabel2
            // 
            this.publicKeyLabel2.AutoSize = true;
            this.publicKeyLabel2.Location = new System.Drawing.Point(178, 63);
            this.publicKeyLabel2.Name = "publicKeyLabel2";
            this.publicKeyLabel2.Size = new System.Drawing.Size(72, 13);
            this.publicKeyLabel2.TabIndex = 4;
            this.publicKeyLabel2.Text = "Clave Pública";
            // 
            // generateTdesButton
            // 
            this.generateTdesButton.AutoSize = true;
            this.generateTdesButton.Location = new System.Drawing.Point(16, 244);
            this.generateTdesButton.Name = "generateTdesButton";
            this.generateTdesButton.Size = new System.Drawing.Size(116, 42);
            this.generateTdesButton.TabIndex = 11;
            this.generateTdesButton.Text = "Generar clave TDES";
            this.generateTdesButton.UseVisualStyleBackColor = true;
            this.generateTdesButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // encryptTdesKeyButton
            // 
            this.encryptTdesKeyButton.Location = new System.Drawing.Point(16, 310);
            this.encryptTdesKeyButton.Name = "encryptTdesKeyButton";
            this.encryptTdesKeyButton.Size = new System.Drawing.Size(205, 42);
            this.encryptTdesKeyButton.TabIndex = 12;
            this.encryptTdesKeyButton.Text = "Encriptar clave TDES con RSA  y clave pública esclavo";
            this.encryptTdesKeyButton.UseVisualStyleBackColor = true;
            this.encryptTdesKeyButton.Click += new System.EventHandler(this.encryptTdesKeyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "----------------------------------------------------------------------";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // encryptedText
            // 
            this.encryptedText.AutoSize = true;
            this.encryptedText.Location = new System.Drawing.Point(265, 398);
            this.encryptedText.MaximumSize = new System.Drawing.Size(210, 0);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(181, 13);
            this.encryptedText.TabIndex = 16;
            this.encryptedText.Text = "<<Texto encriptado del fichero xml>>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Maestro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exportar xml TDES encriptada ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "Importar mensaje de xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 42);
            this.button3.TabIndex = 25;
            this.button3.Text = "Desencriptar mensaje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // desencryptedText
            // 
            this.desencryptedText.AutoSize = true;
            this.desencryptedText.Location = new System.Drawing.Point(218, 519);
            this.desencryptedText.Name = "desencryptedText";
            this.desencryptedText.Size = new System.Drawing.Size(128, 13);
            this.desencryptedText.TabIndex = 26;
            this.desencryptedText.Text = "<<Texto desencriptado>>";
            // 
            // importRsaSlaveButton
            // 
            this.importRsaSlaveButton.Location = new System.Drawing.Point(16, 174);
            this.importRsaSlaveButton.Name = "importRsaSlaveButton";
            this.importRsaSlaveButton.Size = new System.Drawing.Size(140, 42);
            this.importRsaSlaveButton.TabIndex = 20;
            this.importRsaSlaveButton.Text = "Importar clave RSA esclavo";
            this.importRsaSlaveButton.UseVisualStyleBackColor = true;
            this.importRsaSlaveButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // generateRsaKeysButton
            // 
            this.generateRsaKeysButton.Location = new System.Drawing.Point(16, 77);
            this.generateRsaKeysButton.Name = "generateRsaKeysButton";
            this.generateRsaKeysButton.Size = new System.Drawing.Size(140, 42);
            this.generateRsaKeysButton.TabIndex = 27;
            this.generateRsaKeysButton.Text = "Generar claves RSA";
            this.generateRsaKeysButton.UseVisualStyleBackColor = true;
            this.generateRsaKeysButton.Click += new System.EventHandler(this.generateRsaKeysButton_Click);
            // 
            // encryptedTdesBox
            // 
            this.encryptedTdesBox.Location = new System.Drawing.Point(259, 310);
            this.encryptedTdesBox.Multiline = true;
            this.encryptedTdesBox.Name = "encryptedTdesBox";
            this.encryptedTdesBox.ReadOnly = true;
            this.encryptedTdesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedTdesBox.Size = new System.Drawing.Size(201, 73);
            this.encryptedTdesBox.TabIndex = 48;
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.Location = new System.Drawing.Point(259, 42);
            this.publicKeyBox.Multiline = true;
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.ReadOnly = true;
            this.publicKeyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.publicKeyBox.Size = new System.Drawing.Size(201, 47);
            this.publicKeyBox.TabIndex = 49;
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(259, 107);
            this.privateKeyBox.Multiline = true;
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.ReadOnly = true;
            this.privateKeyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.privateKeyBox.Size = new System.Drawing.Size(201, 47);
            this.privateKeyBox.TabIndex = 50;
            // 
            // slaveRsaPublicKey
            // 
            this.slaveRsaPublicKey.Location = new System.Drawing.Point(259, 174);
            this.slaveRsaPublicKey.Multiline = true;
            this.slaveRsaPublicKey.Name = "slaveRsaPublicKey";
            this.slaveRsaPublicKey.ReadOnly = true;
            this.slaveRsaPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.slaveRsaPublicKey.Size = new System.Drawing.Size(201, 47);
            this.slaveRsaPublicKey.TabIndex = 51;
            // 
            // tdesKey
            // 
            this.tdesKey.Location = new System.Drawing.Point(259, 244);
            this.tdesKey.Multiline = true;
            this.tdesKey.Name = "tdesKey";
            this.tdesKey.ReadOnly = true;
            this.tdesKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tdesKey.Size = new System.Drawing.Size(201, 47);
            this.tdesKey.TabIndex = 52;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 604);
            this.Controls.Add(this.tdesKey);
            this.Controls.Add(this.slaveRsaPublicKey);
            this.Controls.Add(this.privateKeyBox);
            this.Controls.Add(this.publicKeyBox);
            this.Controls.Add(this.encryptedTdesBox);
            this.Controls.Add(this.generateRsaKeysButton);
            this.Controls.Add(this.desencryptedText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.importRsaSlaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptTdesKeyButton);
            this.Controls.Add(this.generateTdesButton);
            this.Controls.Add(this.publicKeyLabel2);
            this.Controls.Add(this.privateKeyLabel1);
            this.Name = "Master";
            this.Text = "DCrypt - Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label privateKeyLabel1;
        private System.Windows.Forms.Label publicKeyLabel2;
        private System.Windows.Forms.Button generateTdesButton;
        private System.Windows.Forms.Button encryptTdesKeyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label encryptedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label desencryptedText;
        private System.Windows.Forms.Button importRsaSlaveButton;
        private System.Windows.Forms.Button generateRsaKeysButton;
        private System.Windows.Forms.TextBox encryptedTdesBox;
        private System.Windows.Forms.TextBox publicKeyBox;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.TextBox slaveRsaPublicKey;
        private System.Windows.Forms.TextBox tdesKey;
    }
}

