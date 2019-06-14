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
            this.textToDecryptLabel = new System.Windows.Forms.Label();
            this.generateTdesButton = new System.Windows.Forms.Button();
            this.encryptTdesKeyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.publicKeyValueLabel = new System.Windows.Forms.Label();
            this.privateKeyValueLabel = new System.Windows.Forms.Label();
            this.rsaSlaveKeyValueLabel = new System.Windows.Forms.Label();
            this.TdesKeyValueLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.importRsaSlaveButton = new System.Windows.Forms.Button();
            this.generateRsaKeysButton = new System.Windows.Forms.Button();
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
            // textToDecryptLabel
            // 
            this.textToDecryptLabel.AutoSize = true;
            this.textToDecryptLabel.Location = new System.Drawing.Point(265, 325);
            this.textToDecryptLabel.Name = "textToDecryptLabel";
            this.textToDecryptLabel.Size = new System.Drawing.Size(195, 13);
            this.textToDecryptLabel.TabIndex = 8;
            this.textToDecryptLabel.Text = "<<Valor de la clave TDES encriptada>>";
            this.textToDecryptLabel.Click += new System.EventHandler(this.textToDecryptLabel_Click);
            // 
            // generateTdesButton
            // 
            this.generateTdesButton.Location = new System.Drawing.Point(16, 232);
            this.generateTdesButton.Name = "generateTdesButton";
            this.generateTdesButton.Size = new System.Drawing.Size(140, 42);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "<<Texto encriptado del fichero xml>>";
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
            // publicKeyValueLabel
            // 
            this.publicKeyValueLabel.AutoSize = true;
            this.publicKeyValueLabel.Location = new System.Drawing.Point(265, 63);
            this.publicKeyValueLabel.Name = "publicKeyValueLabel";
            this.publicKeyValueLabel.Size = new System.Drawing.Size(110, 13);
            this.publicKeyValueLabel.TabIndex = 18;
            this.publicKeyValueLabel.Text = "<<Valor de la clave>>";
            this.publicKeyValueLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // privateKeyValueLabel
            // 
            this.privateKeyValueLabel.AutoSize = true;
            this.privateKeyValueLabel.Location = new System.Drawing.Point(265, 117);
            this.privateKeyValueLabel.Name = "privateKeyValueLabel";
            this.privateKeyValueLabel.Size = new System.Drawing.Size(110, 13);
            this.privateKeyValueLabel.TabIndex = 19;
            this.privateKeyValueLabel.Text = "<<Valor de la clave>>";
            this.privateKeyValueLabel.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // rsaSlaveKeyValueLabel
            // 
            this.rsaSlaveKeyValueLabel.AutoSize = true;
            this.rsaSlaveKeyValueLabel.Location = new System.Drawing.Point(265, 172);
            this.rsaSlaveKeyValueLabel.Name = "rsaSlaveKeyValueLabel";
            this.rsaSlaveKeyValueLabel.Size = new System.Drawing.Size(202, 13);
            this.rsaSlaveKeyValueLabel.TabIndex = 21;
            this.rsaSlaveKeyValueLabel.Text = "<<Valor de la clave pública de esclavo>>";
            // 
            // TdesKeyValueLabel
            // 
            this.TdesKeyValueLabel.AutoSize = true;
            this.TdesKeyValueLabel.Location = new System.Drawing.Point(265, 247);
            this.TdesKeyValueLabel.Name = "TdesKeyValueLabel";
            this.TdesKeyValueLabel.Size = new System.Drawing.Size(142, 13);
            this.TdesKeyValueLabel.TabIndex = 22;
            this.TdesKeyValueLabel.Text = "<<Valor de la clave TDES>>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exportar xml TDES encriptada ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "Importar mensaje de xml";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 42);
            this.button3.TabIndex = 25;
            this.button3.Text = "Desencriptar mensaje";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "<<Texto desencriptado>>";
            // 
            // importRsaSlaveButton
            // 
            this.importRsaSlaveButton.Location = new System.Drawing.Point(16, 157);
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
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 604);
            this.Controls.Add(this.generateRsaKeysButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TdesKeyValueLabel);
            this.Controls.Add(this.rsaSlaveKeyValueLabel);
            this.Controls.Add(this.importRsaSlaveButton);
            this.Controls.Add(this.privateKeyValueLabel);
            this.Controls.Add(this.publicKeyValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptTdesKeyButton);
            this.Controls.Add(this.generateTdesButton);
            this.Controls.Add(this.textToDecryptLabel);
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
        private System.Windows.Forms.Label textToDecryptLabel;
        private System.Windows.Forms.Button generateTdesButton;
        private System.Windows.Forms.Button encryptTdesKeyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label publicKeyValueLabel;
        private System.Windows.Forms.Label privateKeyValueLabel;
        private System.Windows.Forms.Label rsaSlaveKeyValueLabel;
        private System.Windows.Forms.Label TdesKeyValueLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button importRsaSlaveButton;
        private System.Windows.Forms.Button generateRsaKeysButton;
    }
}

