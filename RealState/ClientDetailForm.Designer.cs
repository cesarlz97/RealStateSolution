namespace RealState
{
    partial class ClientDetailForm
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
            this.SelectImage = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelClientPhoneNumber = new System.Windows.Forms.Label();
            this.labelClientEmail = new System.Windows.Forms.Label();
            this.textBoxClientSurname = new System.Windows.Forms.TextBox();
            this.textBoxClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.labelContracts = new System.Windows.Forms.Label();
            this.listBoxContracts = new System.Windows.Forms.ListBox();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            this.labelSearchProfiles = new System.Windows.Forms.Label();
            this.listBoxSearchProfiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(37, 144);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(128, 23);
            this.SelectImage.TabIndex = 3;
            this.SelectImage.Text = "Seleccionar Imagen";
            this.SelectImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(176, 126);
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(12, 187);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(44, 13);
            this.labelClientName.TabIndex = 4;
            this.labelClientName.Text = "Nombre";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(67, 184);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientName.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 221);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Apeliidos";
            // 
            // labelClientPhoneNumber
            // 
            this.labelClientPhoneNumber.AutoSize = true;
            this.labelClientPhoneNumber.Location = new System.Drawing.Point(12, 251);
            this.labelClientPhoneNumber.Name = "labelClientPhoneNumber";
            this.labelClientPhoneNumber.Size = new System.Drawing.Size(28, 13);
            this.labelClientPhoneNumber.TabIndex = 7;
            this.labelClientPhoneNumber.Text = "Telf.";
            // 
            // labelClientEmail
            // 
            this.labelClientEmail.AutoSize = true;
            this.labelClientEmail.Location = new System.Drawing.Point(12, 285);
            this.labelClientEmail.Name = "labelClientEmail";
            this.labelClientEmail.Size = new System.Drawing.Size(32, 13);
            this.labelClientEmail.TabIndex = 8;
            this.labelClientEmail.Text = "Email";
            // 
            // textBoxClientSurname
            // 
            this.textBoxClientSurname.Location = new System.Drawing.Point(67, 218);
            this.textBoxClientSurname.Name = "textBoxClientSurname";
            this.textBoxClientSurname.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientSurname.TabIndex = 10;
            // 
            // textBoxClientPhoneNumber
            // 
            this.textBoxClientPhoneNumber.Location = new System.Drawing.Point(67, 248);
            this.textBoxClientPhoneNumber.Name = "textBoxClientPhoneNumber";
            this.textBoxClientPhoneNumber.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientPhoneNumber.TabIndex = 11;
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Location = new System.Drawing.Point(67, 282);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientEmail.TabIndex = 12;
            // 
            // labelContracts
            // 
            this.labelContracts.AutoSize = true;
            this.labelContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContracts.Location = new System.Drawing.Point(507, 9);
            this.labelContracts.Name = "labelContracts";
            this.labelContracts.Size = new System.Drawing.Size(88, 20);
            this.labelContracts.TabIndex = 53;
            this.labelContracts.Text = "Contratos";
            // 
            // listBoxContracts
            // 
            this.listBoxContracts.FormattingEnabled = true;
            this.listBoxContracts.Location = new System.Drawing.Point(511, 42);
            this.listBoxContracts.Name = "listBoxContracts";
            this.listBoxContracts.Size = new System.Drawing.Size(280, 394);
            this.listBoxContracts.TabIndex = 54;
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.Location = new System.Drawing.Point(106, 308);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(96, 23);
            this.buttonSaveClient.TabIndex = 55;
            this.buttonSaveClient.Text = "Guardar";
            this.buttonSaveClient.UseVisualStyleBackColor = true;
            this.buttonSaveClient.Click += new System.EventHandler(this.buttonSaveClient_Click);
            // 
            // labelSearchProfiles
            // 
            this.labelSearchProfiles.AutoSize = true;
            this.labelSearchProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchProfiles.Location = new System.Drawing.Point(221, 12);
            this.labelSearchProfiles.Name = "labelSearchProfiles";
            this.labelSearchProfiles.Size = new System.Drawing.Size(178, 20);
            this.labelSearchProfiles.TabIndex = 56;
            this.labelSearchProfiles.Text = "Perfiles de búsqueda";
            // 
            // listBoxSearchProfiles
            // 
            this.listBoxSearchProfiles.FormattingEnabled = true;
            this.listBoxSearchProfiles.Location = new System.Drawing.Point(225, 42);
            this.listBoxSearchProfiles.Name = "listBoxSearchProfiles";
            this.listBoxSearchProfiles.Size = new System.Drawing.Size(280, 394);
            this.listBoxSearchProfiles.TabIndex = 57;
            // 
            // ClientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSearchProfiles);
            this.Controls.Add(this.labelSearchProfiles);
            this.Controls.Add(this.buttonSaveClient);
            this.Controls.Add(this.listBoxContracts);
            this.Controls.Add(this.labelContracts);
            this.Controls.Add(this.textBoxClientEmail);
            this.Controls.Add(this.textBoxClientPhoneNumber);
            this.Controls.Add(this.textBoxClientSurname);
            this.Controls.Add(this.labelClientEmail);
            this.Controls.Add(this.labelClientPhoneNumber);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "ClientDetailForm";
            this.Text = "ClientDetailForm";
            this.Load += new System.EventHandler(this.ClientDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelClientPhoneNumber;
        private System.Windows.Forms.Label labelClientEmail;
        private System.Windows.Forms.TextBox textBoxClientSurname;
        private System.Windows.Forms.TextBox textBoxClientPhoneNumber;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Label labelContracts;
        private System.Windows.Forms.ListBox listBoxContracts;
        private System.Windows.Forms.Button buttonSaveClient;
        private System.Windows.Forms.Label labelSearchProfiles;
        private System.Windows.Forms.ListBox listBoxSearchProfiles;
    }
}