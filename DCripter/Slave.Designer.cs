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
            this.privateKeyValueLabel = new System.Windows.Forms.Label();
            this.publicKeyValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.publicKeyLabel2 = new System.Windows.Forms.Label();
            this.privateKeyLabel1 = new System.Windows.Forms.Label();
            this.exportXmlButton = new System.Windows.Forms.Button();
            this.rsaSlaveKeyValueLabel = new System.Windows.Forms.Label();
            this.importRsaSlaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
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
            // privateKeyValueLabel
            // 
            this.privateKeyValueLabel.AutoSize = true;
            this.privateKeyValueLabel.Location = new System.Drawing.Point(265, 117);
            this.privateKeyValueLabel.Name = "privateKeyValueLabel";
            this.privateKeyValueLabel.Size = new System.Drawing.Size(110, 13);
            this.privateKeyValueLabel.TabIndex = 33;
            this.privateKeyValueLabel.Text = "<<Valor de la clave>>";
            // 
            // publicKeyValueLabel
            // 
            this.publicKeyValueLabel.AutoSize = true;
            this.publicKeyValueLabel.Location = new System.Drawing.Point(265, 63);
            this.publicKeyValueLabel.Name = "publicKeyValueLabel";
            this.publicKeyValueLabel.Size = new System.Drawing.Size(110, 13);
            this.publicKeyValueLabel.TabIndex = 32;
            this.publicKeyValueLabel.Text = "<<Valor de la clave>>";
            this.publicKeyValueLabel.Click += new System.EventHandler(this.publicKeyValueLabel_Click);
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
            this.exportXmlButton.Location = new System.Drawing.Point(431, 70);
            this.exportXmlButton.Name = "exportXmlButton";
            this.exportXmlButton.Size = new System.Drawing.Size(73, 58);
            this.exportXmlButton.TabIndex = 34;
            this.exportXmlButton.Text = "Exportar xml TDES encriptada ";
            this.exportXmlButton.UseVisualStyleBackColor = true;
            this.exportXmlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rsaSlaveKeyValueLabel
            // 
            this.rsaSlaveKeyValueLabel.AutoSize = true;
            this.rsaSlaveKeyValueLabel.Location = new System.Drawing.Point(265, 172);
            this.rsaSlaveKeyValueLabel.Name = "rsaSlaveKeyValueLabel";
            this.rsaSlaveKeyValueLabel.Size = new System.Drawing.Size(195, 13);
            this.rsaSlaveKeyValueLabel.TabIndex = 36;
            this.rsaSlaveKeyValueLabel.Text = "<<Valor de la clave TDES encriptada>>";
            this.rsaSlaveKeyValueLabel.Click += new System.EventHandler(this.rsaSlaveKeyValueLabel_Click);
            // 
            // importRsaSlaveButton
            // 
            this.importRsaSlaveButton.Location = new System.Drawing.Point(16, 157);
            this.importRsaSlaveButton.Name = "importRsaSlaveButton";
            this.importRsaSlaveButton.Size = new System.Drawing.Size(140, 42);
            this.importRsaSlaveButton.TabIndex = 35;
            this.importRsaSlaveButton.Text = "Importar clave TDES de fichero XML";
            this.importRsaSlaveButton.UseVisualStyleBackColor = true;
            this.importRsaSlaveButton.Click += new System.EventHandler(this.importRsaSlaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "<<Valor de la clave TDES desencriptada>>";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 37;
            this.button2.Text = "Desencriptar TDES de fichero";
            this.button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 42);
            this.button3.TabIndex = 41;
            this.button3.Text = "Encriptar texto algoritmo TDES y clave TDES desencriptada";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "<<Resultado del texto encriptado>>";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 42);
            this.button4.TabIndex = 43;
            this.button4.Text = "Exportar mensaje a xml";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Slave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 604);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rsaSlaveKeyValueLabel);
            this.Controls.Add(this.importRsaSlaveButton);
            this.Controls.Add(this.exportXmlButton);
            this.Controls.Add(this.privateKeyValueLabel);
            this.Controls.Add(this.publicKeyValueLabel);
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
        private System.Windows.Forms.Label privateKeyValueLabel;
        private System.Windows.Forms.Label publicKeyValueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label publicKeyLabel2;
        private System.Windows.Forms.Label privateKeyLabel1;
        private System.Windows.Forms.Button exportXmlButton;
        private System.Windows.Forms.Label rsaSlaveKeyValueLabel;
        private System.Windows.Forms.Button importRsaSlaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
    }
}