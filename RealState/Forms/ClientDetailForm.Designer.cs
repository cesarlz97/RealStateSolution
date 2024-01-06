namespace RealState.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetailForm));
            this.SelectImage = new System.Windows.Forms.Button();
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
            this.labelProperties = new System.Windows.Forms.Label();
            this.listBoxProperties = new System.Windows.Forms.ListBox();
            this.buttonAddSearchProfile = new System.Windows.Forms.Button();
            this.buttonDeleteSearchProfile = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(38, 175);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(128, 23);
            this.SelectImage.TabIndex = 3;
            this.SelectImage.Text = "Seleccionar Imagen";
            this.SelectImage.UseVisualStyleBackColor = true;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(13, 218);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(44, 13);
            this.labelClientName.TabIndex = 4;
            this.labelClientName.Text = "Nombre";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(68, 215);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientName.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(13, 252);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Apeliidos";
            // 
            // labelClientPhoneNumber
            // 
            this.labelClientPhoneNumber.AutoSize = true;
            this.labelClientPhoneNumber.Location = new System.Drawing.Point(13, 282);
            this.labelClientPhoneNumber.Name = "labelClientPhoneNumber";
            this.labelClientPhoneNumber.Size = new System.Drawing.Size(28, 13);
            this.labelClientPhoneNumber.TabIndex = 7;
            this.labelClientPhoneNumber.Text = "Telf.";
            // 
            // labelClientEmail
            // 
            this.labelClientEmail.AutoSize = true;
            this.labelClientEmail.Location = new System.Drawing.Point(13, 316);
            this.labelClientEmail.Name = "labelClientEmail";
            this.labelClientEmail.Size = new System.Drawing.Size(32, 13);
            this.labelClientEmail.TabIndex = 8;
            this.labelClientEmail.Text = "Email";
            // 
            // textBoxClientSurname
            // 
            this.textBoxClientSurname.Location = new System.Drawing.Point(68, 249);
            this.textBoxClientSurname.Name = "textBoxClientSurname";
            this.textBoxClientSurname.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientSurname.TabIndex = 10;
            // 
            // textBoxClientPhoneNumber
            // 
            this.textBoxClientPhoneNumber.Location = new System.Drawing.Point(68, 279);
            this.textBoxClientPhoneNumber.Name = "textBoxClientPhoneNumber";
            this.textBoxClientPhoneNumber.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientPhoneNumber.TabIndex = 11;
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Location = new System.Drawing.Point(68, 313);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(135, 20);
            this.textBoxClientEmail.TabIndex = 12;
            // 
            // labelContracts
            // 
            this.labelContracts.AutoSize = true;
            this.labelContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContracts.Location = new System.Drawing.Point(221, 285);
            this.labelContracts.Name = "labelContracts";
            this.labelContracts.Size = new System.Drawing.Size(88, 20);
            this.labelContracts.TabIndex = 53;
            this.labelContracts.Text = "Contratos";
            // 
            // listBoxContracts
            // 
            this.listBoxContracts.FormattingEnabled = true;
            this.listBoxContracts.Location = new System.Drawing.Point(225, 308);
            this.listBoxContracts.Name = "listBoxContracts";
            this.listBoxContracts.Size = new System.Drawing.Size(563, 108);
            this.listBoxContracts.TabIndex = 54;
            this.listBoxContracts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxContracts_MouseDoubleClick);
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.Location = new System.Drawing.Point(107, 339);
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
            this.labelSearchProfiles.Location = new System.Drawing.Point(221, 9);
            this.labelSearchProfiles.Name = "labelSearchProfiles";
            this.labelSearchProfiles.Size = new System.Drawing.Size(178, 20);
            this.labelSearchProfiles.TabIndex = 56;
            this.labelSearchProfiles.Text = "Perfiles de búsqueda";
            // 
            // listBoxSearchProfiles
            // 
            this.listBoxSearchProfiles.FormattingEnabled = true;
            this.listBoxSearchProfiles.Location = new System.Drawing.Point(225, 32);
            this.listBoxSearchProfiles.Name = "listBoxSearchProfiles";
            this.listBoxSearchProfiles.Size = new System.Drawing.Size(563, 108);
            this.listBoxSearchProfiles.TabIndex = 57;
            this.listBoxSearchProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSearchProfiles_MouseDoubleClick);
            // 
            // labelProperties
            // 
            this.labelProperties.AutoSize = true;
            this.labelProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProperties.Location = new System.Drawing.Point(221, 147);
            this.labelProperties.Name = "labelProperties";
            this.labelProperties.Size = new System.Drawing.Size(92, 20);
            this.labelProperties.TabIndex = 58;
            this.labelProperties.Text = "Inmuebles";
            // 
            // listBoxProperties
            // 
            this.listBoxProperties.FormattingEnabled = true;
            this.listBoxProperties.Location = new System.Drawing.Point(225, 170);
            this.listBoxProperties.Name = "listBoxProperties";
            this.listBoxProperties.Size = new System.Drawing.Size(563, 108);
            this.listBoxProperties.TabIndex = 59;
            this.listBoxProperties.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProperties_MouseDoubleClick);
            // 
            // buttonAddSearchProfile
            // 
            this.buttonAddSearchProfile.Location = new System.Drawing.Point(761, 6);
            this.buttonAddSearchProfile.Name = "buttonAddSearchProfile";
            this.buttonAddSearchProfile.Size = new System.Drawing.Size(23, 23);
            this.buttonAddSearchProfile.TabIndex = 60;
            this.buttonAddSearchProfile.Text = "+";
            this.buttonAddSearchProfile.UseVisualStyleBackColor = true;
            this.buttonAddSearchProfile.Click += new System.EventHandler(this.buttonAddSearchProfile_Click);
            // 
            // buttonDeleteSearchProfile
            // 
            this.buttonDeleteSearchProfile.Location = new System.Drawing.Point(732, 6);
            this.buttonDeleteSearchProfile.Name = "buttonDeleteSearchProfile";
            this.buttonDeleteSearchProfile.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteSearchProfile.TabIndex = 61;
            this.buttonDeleteSearchProfile.Text = "-";
            this.buttonDeleteSearchProfile.UseVisualStyleBackColor = true;
            this.buttonDeleteSearchProfile.Click += new System.EventHandler(this.buttonDeleteSearchProfile_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::RealState.Properties.Resources.Client_Default_Profile_Image;
            this.pictureBoxImage.Location = new System.Drawing.Point(27, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // ClientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteSearchProfile);
            this.Controls.Add(this.buttonAddSearchProfile);
            this.Controls.Add(this.listBoxProperties);
            this.Controls.Add(this.labelProperties);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
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
        private System.Windows.Forms.Label labelProperties;
        private System.Windows.Forms.ListBox listBoxProperties;
        private System.Windows.Forms.Button buttonAddSearchProfile;
        private System.Windows.Forms.Button buttonDeleteSearchProfile;
    }
}