namespace RealState
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInit = new System.Windows.Forms.TabPage();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.linkLabelSelectTab = new System.Windows.Forms.LinkLabel();
            this.labelWelcomeTilte = new System.Windows.Forms.Label();
            this.tabPageBuildings = new System.Windows.Forms.TabPage();
            this.panelProperties = new System.Windows.Forms.Panel();
            this.buttonPropertyNew = new System.Windows.Forms.Button();
            this.buttonPropertyDetail = new System.Windows.Forms.Button();
            this.buttonPropertyDelete = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.panelClients = new System.Windows.Forms.Panel();
            this.buttonClientNew = new System.Windows.Forms.Button();
            this.buttonClientDetail = new System.Windows.Forms.Button();
            this.buttonClientDelete = new System.Windows.Forms.Button();
            this.tabPageSocialMedia = new System.Windows.Forms.TabPage();
            this.listViewInstagramPublishedBuildings = new System.Windows.Forms.ListView();
            this.labelPublishedBuildings = new System.Windows.Forms.Label();
            this.checkBoxPublishAutomatic = new System.Windows.Forms.CheckBox();
            this.labelInstagramConfiguration = new System.Windows.Forms.Label();
            this.buttonSaveInstagramCredentials = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelInstagramPassword = new System.Windows.Forms.Label();
            this.labelInstagramUser = new System.Windows.Forms.Label();
            this.labelCredentials = new System.Windows.Forms.Label();
            this.labelInstagramProfile = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.propertySelectorUserControl = new RealState.CustomControls.PropertySelectorUserControl();
            this.clientSelectorUserControl = new RealState.CustomControls.ClientSelectorUserControl();
            this.tabControlMain.SuspendLayout();
            this.tabPageInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabPageBuildings.SuspendLayout();
            this.panelProperties.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.panelClients.SuspendLayout();
            this.tabPageSocialMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageInit);
            this.tabControlMain.Controls.Add(this.tabPageBuildings);
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Controls.Add(this.tabPageSocialMedia);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 457);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageInit
            // 
            this.tabPageInit.Controls.Add(this.pictureBoxLogo);
            this.tabPageInit.Controls.Add(this.linkLabelSelectTab);
            this.tabPageInit.Controls.Add(this.labelWelcomeTilte);
            this.tabPageInit.Location = new System.Drawing.Point(4, 22);
            this.tabPageInit.Name = "tabPageInit";
            this.tabPageInit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInit.Size = new System.Drawing.Size(768, 431);
            this.tabPageInit.TabIndex = 3;
            this.tabPageInit.Text = "Inicio";
            this.tabPageInit.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(264, 315);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(253, 68);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // linkLabelSelectTab
            // 
            this.linkLabelSelectTab.AutoSize = true;
            this.linkLabelSelectTab.Location = new System.Drawing.Point(292, 146);
            this.linkLabelSelectTab.Name = "linkLabelSelectTab";
            this.linkLabelSelectTab.Size = new System.Drawing.Size(193, 13);
            this.linkLabelSelectTab.TabIndex = 1;
            this.linkLabelSelectTab.TabStop = true;
            this.linkLabelSelectTab.Text = "Seleccione una pestaña para continuar";
            // 
            // labelWelcomeTilte
            // 
            this.labelWelcomeTilte.AutoSize = true;
            this.labelWelcomeTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeTilte.Location = new System.Drawing.Point(247, 98);
            this.labelWelcomeTilte.Name = "labelWelcomeTilte";
            this.labelWelcomeTilte.Size = new System.Drawing.Size(287, 24);
            this.labelWelcomeTilte.TabIndex = 0;
            this.labelWelcomeTilte.Text = "BIENVENIDO A REAL STATE";
            // 
            // tabPageBuildings
            // 
            this.tabPageBuildings.Controls.Add(this.panelProperties);
            this.tabPageBuildings.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuildings.Name = "tabPageBuildings";
            this.tabPageBuildings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuildings.Size = new System.Drawing.Size(768, 431);
            this.tabPageBuildings.TabIndex = 0;
            this.tabPageBuildings.Text = "Inmuebles";
            this.tabPageBuildings.UseVisualStyleBackColor = true;
            // 
            // panelProperties
            // 
            this.panelProperties.Controls.Add(this.propertySelectorUserControl);
            this.panelProperties.Controls.Add(this.buttonPropertyNew);
            this.panelProperties.Controls.Add(this.buttonPropertyDetail);
            this.panelProperties.Controls.Add(this.buttonPropertyDelete);
            this.panelProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperties.Location = new System.Drawing.Point(3, 3);
            this.panelProperties.Name = "panelProperties";
            this.panelProperties.Size = new System.Drawing.Size(762, 425);
            this.panelProperties.TabIndex = 10;
            // 
            // buttonPropertyNew
            // 
            this.buttonPropertyNew.Location = new System.Drawing.Point(600, 399);
            this.buttonPropertyNew.Name = "buttonPropertyNew";
            this.buttonPropertyNew.Size = new System.Drawing.Size(75, 23);
            this.buttonPropertyNew.TabIndex = 6;
            this.buttonPropertyNew.Text = "Nuevo";
            this.buttonPropertyNew.UseVisualStyleBackColor = true;
            this.buttonPropertyNew.Click += new System.EventHandler(this.buttonPropertyNew_Click);
            // 
            // buttonPropertyDetail
            // 
            this.buttonPropertyDetail.Location = new System.Drawing.Point(681, 399);
            this.buttonPropertyDetail.Name = "buttonPropertyDetail";
            this.buttonPropertyDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonPropertyDetail.TabIndex = 8;
            this.buttonPropertyDetail.Text = "Detalle";
            this.buttonPropertyDetail.UseVisualStyleBackColor = true;
            this.buttonPropertyDetail.Click += new System.EventHandler(this.buttonPropertyDetail_Click);
            // 
            // buttonPropertyDelete
            // 
            this.buttonPropertyDelete.Location = new System.Drawing.Point(6, 399);
            this.buttonPropertyDelete.Name = "buttonPropertyDelete";
            this.buttonPropertyDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonPropertyDelete.TabIndex = 9;
            this.buttonPropertyDelete.Text = "Eliminar";
            this.buttonPropertyDelete.UseVisualStyleBackColor = true;
            this.buttonPropertyDelete.Click += new System.EventHandler(this.buttonPropertyDelete_Click);
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.panelClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(768, 431);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clientes";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // panelClients
            // 
            this.panelClients.Controls.Add(this.buttonClientNew);
            this.panelClients.Controls.Add(this.buttonClientDetail);
            this.panelClients.Controls.Add(this.buttonClientDelete);
            this.panelClients.Controls.Add(this.clientSelectorUserControl);
            this.panelClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClients.Location = new System.Drawing.Point(3, 3);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(762, 425);
            this.panelClients.TabIndex = 0;
            // 
            // buttonClientNew
            // 
            this.buttonClientNew.Location = new System.Drawing.Point(600, 399);
            this.buttonClientNew.Name = "buttonClientNew";
            this.buttonClientNew.Size = new System.Drawing.Size(75, 23);
            this.buttonClientNew.TabIndex = 10;
            this.buttonClientNew.Text = "Nuevo";
            this.buttonClientNew.UseVisualStyleBackColor = true;
            this.buttonClientNew.Click += new System.EventHandler(this.buttonClientNew_Click);
            // 
            // buttonClientDetail
            // 
            this.buttonClientDetail.Location = new System.Drawing.Point(681, 399);
            this.buttonClientDetail.Name = "buttonClientDetail";
            this.buttonClientDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDetail.TabIndex = 11;
            this.buttonClientDetail.Text = "Detalle";
            this.buttonClientDetail.UseVisualStyleBackColor = true;
            this.buttonClientDetail.Click += new System.EventHandler(this.buttonClientDetail_Click);
            // 
            // buttonClientDelete
            // 
            this.buttonClientDelete.Location = new System.Drawing.Point(6, 399);
            this.buttonClientDelete.Name = "buttonClientDelete";
            this.buttonClientDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDelete.TabIndex = 12;
            this.buttonClientDelete.Text = "Eliminar";
            this.buttonClientDelete.UseVisualStyleBackColor = true;
            this.buttonClientDelete.Click += new System.EventHandler(this.buttonClientDelete_Click);
            // 
            // tabPageSocialMedia
            // 
            this.tabPageSocialMedia.Controls.Add(this.listViewInstagramPublishedBuildings);
            this.tabPageSocialMedia.Controls.Add(this.labelPublishedBuildings);
            this.tabPageSocialMedia.Controls.Add(this.checkBoxPublishAutomatic);
            this.tabPageSocialMedia.Controls.Add(this.labelInstagramConfiguration);
            this.tabPageSocialMedia.Controls.Add(this.buttonSaveInstagramCredentials);
            this.tabPageSocialMedia.Controls.Add(this.textBox2);
            this.tabPageSocialMedia.Controls.Add(this.textBox1);
            this.tabPageSocialMedia.Controls.Add(this.labelInstagramPassword);
            this.tabPageSocialMedia.Controls.Add(this.labelInstagramUser);
            this.tabPageSocialMedia.Controls.Add(this.labelCredentials);
            this.tabPageSocialMedia.Controls.Add(this.labelInstagramProfile);
            this.tabPageSocialMedia.Location = new System.Drawing.Point(4, 22);
            this.tabPageSocialMedia.Name = "tabPageSocialMedia";
            this.tabPageSocialMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSocialMedia.Size = new System.Drawing.Size(768, 431);
            this.tabPageSocialMedia.TabIndex = 2;
            this.tabPageSocialMedia.Text = "RRSS";
            this.tabPageSocialMedia.UseVisualStyleBackColor = true;
            // 
            // listViewInstagramPublishedBuildings
            // 
            this.listViewInstagramPublishedBuildings.HideSelection = false;
            this.listViewInstagramPublishedBuildings.Location = new System.Drawing.Point(367, 108);
            this.listViewInstagramPublishedBuildings.Name = "listViewInstagramPublishedBuildings";
            this.listViewInstagramPublishedBuildings.Size = new System.Drawing.Size(382, 126);
            this.listViewInstagramPublishedBuildings.TabIndex = 10;
            this.listViewInstagramPublishedBuildings.UseCompatibleStateImageBehavior = false;
            // 
            // labelPublishedBuildings
            // 
            this.labelPublishedBuildings.AutoSize = true;
            this.labelPublishedBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublishedBuildings.Location = new System.Drawing.Point(364, 66);
            this.labelPublishedBuildings.Name = "labelPublishedBuildings";
            this.labelPublishedBuildings.Size = new System.Drawing.Size(160, 13);
            this.labelPublishedBuildings.TabIndex = 9;
            this.labelPublishedBuildings.Text = "INMUEBLES PUBLICADOS";
            // 
            // checkBoxPublishAutomatic
            // 
            this.checkBoxPublishAutomatic.AutoSize = true;
            this.checkBoxPublishAutomatic.Location = new System.Drawing.Point(30, 251);
            this.checkBoxPublishAutomatic.Name = "checkBoxPublishAutomatic";
            this.checkBoxPublishAutomatic.Size = new System.Drawing.Size(198, 17);
            this.checkBoxPublishAutomatic.TabIndex = 8;
            this.checkBoxPublishAutomatic.Text = "Publicar inmuebles automáticamente";
            this.checkBoxPublishAutomatic.UseVisualStyleBackColor = true;
            // 
            // labelInstagramConfiguration
            // 
            this.labelInstagramConfiguration.AutoSize = true;
            this.labelInstagramConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstagramConfiguration.Location = new System.Drawing.Point(28, 221);
            this.labelInstagramConfiguration.Name = "labelInstagramConfiguration";
            this.labelInstagramConfiguration.Size = new System.Drawing.Size(109, 13);
            this.labelInstagramConfiguration.TabIndex = 7;
            this.labelInstagramConfiguration.Text = "CONFIGURACIÓN";
            // 
            // buttonSaveInstagramCredentials
            // 
            this.buttonSaveInstagramCredentials.Location = new System.Drawing.Point(193, 173);
            this.buttonSaveInstagramCredentials.Name = "buttonSaveInstagramCredentials";
            this.buttonSaveInstagramCredentials.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveInstagramCredentials.TabIndex = 6;
            this.buttonSaveInstagramCredentials.Text = "Guardar";
            this.buttonSaveInstagramCredentials.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 4;
            // 
            // labelInstagramPassword
            // 
            this.labelInstagramPassword.AutoSize = true;
            this.labelInstagramPassword.Location = new System.Drawing.Point(27, 150);
            this.labelInstagramPassword.Name = "labelInstagramPassword";
            this.labelInstagramPassword.Size = new System.Drawing.Size(61, 13);
            this.labelInstagramPassword.TabIndex = 3;
            this.labelInstagramPassword.Text = "Contraseña";
            // 
            // labelInstagramUser
            // 
            this.labelInstagramUser.AutoSize = true;
            this.labelInstagramUser.Location = new System.Drawing.Point(28, 111);
            this.labelInstagramUser.Name = "labelInstagramUser";
            this.labelInstagramUser.Size = new System.Drawing.Size(43, 13);
            this.labelInstagramUser.TabIndex = 2;
            this.labelInstagramUser.Text = "Usuario";
            // 
            // labelCredentials
            // 
            this.labelCredentials.AutoSize = true;
            this.labelCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredentials.Location = new System.Drawing.Point(28, 66);
            this.labelCredentials.Name = "labelCredentials";
            this.labelCredentials.Size = new System.Drawing.Size(101, 13);
            this.labelCredentials.TabIndex = 1;
            this.labelCredentials.Text = "CREDENCIALES";
            // 
            // labelInstagramProfile
            // 
            this.labelInstagramProfile.AutoSize = true;
            this.labelInstagramProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstagramProfile.Location = new System.Drawing.Point(26, 20);
            this.labelInstagramProfile.Name = "labelInstagramProfile";
            this.labelInstagramProfile.Size = new System.Drawing.Size(137, 24);
            this.labelInstagramProfile.TabIndex = 0;
            this.labelInstagramProfile.Text = "Perfil Instagram";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // propertySelectorUserControl
            // 
            this.propertySelectorUserControl.Location = new System.Drawing.Point(6, 7);
            this.propertySelectorUserControl.Name = "propertySelectorUserControl";
            this.propertySelectorUserControl.Size = new System.Drawing.Size(750, 380);
            this.propertySelectorUserControl.TabIndex = 7;
            // 
            // clientSelectorUserControl
            // 
            this.clientSelectorUserControl.Location = new System.Drawing.Point(6, 7);
            this.clientSelectorUserControl.Name = "clientSelectorUserControl";
            this.clientSelectorUserControl.Size = new System.Drawing.Size(750, 380);
            this.clientSelectorUserControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageInit.ResumeLayout(false);
            this.tabPageInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabPageBuildings.ResumeLayout(false);
            this.panelProperties.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.panelClients.ResumeLayout(false);
            this.tabPageSocialMedia.ResumeLayout(false);
            this.tabPageSocialMedia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageBuildings;
        private System.Windows.Forms.TabPage tabPageSocialMedia;
        private System.Windows.Forms.Button buttonPropertyNew;
        private System.Windows.Forms.ListView listViewInstagramPublishedBuildings;
        private System.Windows.Forms.Label labelPublishedBuildings;
        private System.Windows.Forms.CheckBox checkBoxPublishAutomatic;
        private System.Windows.Forms.Label labelInstagramConfiguration;
        private System.Windows.Forms.Button buttonSaveInstagramCredentials;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelInstagramPassword;
        private System.Windows.Forms.Label labelInstagramUser;
        private System.Windows.Forms.Label labelCredentials;
        private System.Windows.Forms.Label labelInstagramProfile;
        private System.Windows.Forms.TabPage tabPageInit;
        private System.Windows.Forms.LinkLabel linkLabelSelectTab;
        private System.Windows.Forms.Label labelWelcomeTilte;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private CustomControls.PropertySelectorUserControl propertySelectorUserControl;
        private System.Windows.Forms.Button buttonPropertyDelete;
        private System.Windows.Forms.Button buttonPropertyDetail;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Panel panelProperties;
        private System.Windows.Forms.Button buttonClientNew;
        private System.Windows.Forms.Button buttonClientDetail;
        private System.Windows.Forms.Button buttonClientDelete;
        private CustomControls.ClientSelectorUserControl clientSelectorUserControl;
    }
}