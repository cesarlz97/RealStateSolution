using RealState.Models;

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
            this.propertySelectorUserControl = new RealState.CustomControls.ItemSelectorUserControl<Property>();
            this.buttonPropertyNew = new System.Windows.Forms.Button();
            this.buttonPropertyDetail = new System.Windows.Forms.Button();
            this.buttonPropertyDelete = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.panelClients = new System.Windows.Forms.Panel();
            this.buttonClientNew = new System.Windows.Forms.Button();
            this.buttonClientDetail = new System.Windows.Forms.Button();
            this.buttonClientDelete = new System.Windows.Forms.Button();
            this.clientSelectorUserControl = new RealState.CustomControls.ItemSelectorUserControl<Client>();
            this.tabPageSocialMedia = new System.Windows.Forms.TabPage();
            this.buttonPublishPropertyOnTwitter = new System.Windows.Forms.Button();
            this.labelSelectedPropertyTitle = new System.Windows.Forms.Label();
            this.labelSelectedProperty = new System.Windows.Forms.Label();
            this.buttonSelectPropertyToPublish = new System.Windows.Forms.Button();
            this.textBoxTwitterAccessTokenSecret = new System.Windows.Forms.TextBox();
            this.labelTwitterAccessTokenSecret = new System.Windows.Forms.Label();
            this.textBoxTwitterAccessToken = new System.Windows.Forms.TextBox();
            this.labelTwitterAccessToken = new System.Windows.Forms.Label();
            this.listViewTwitterPublishedBuildings = new System.Windows.Forms.ListView();
            this.labelTwitterPublishedProperties = new System.Windows.Forms.Label();
            this.buttonSaveTwitterCredentials = new System.Windows.Forms.Button();
            this.textBoxTwitterApiKeySecret = new System.Windows.Forms.TextBox();
            this.textBoxTwitterApiKey = new System.Windows.Forms.TextBox();
            this.labelTwitterApiKeySecret = new System.Windows.Forms.Label();
            this.labelTwitterApiKey = new System.Windows.Forms.Label();
            this.labelCredentials = new System.Windows.Forms.Label();
            this.labelTwitterProfile = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            // propertySelectorUserControl
            // 
            this.propertySelectorUserControl.Location = new System.Drawing.Point(6, 7);
            this.propertySelectorUserControl.Name = "propertySelectorUserControl";
            this.propertySelectorUserControl.Size = new System.Drawing.Size(750, 380);
            this.propertySelectorUserControl.TabIndex = 7;
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
            // clientSelectorUserControl
            // 
            this.clientSelectorUserControl.Location = new System.Drawing.Point(6, 7);
            this.clientSelectorUserControl.Name = "clientSelectorUserControl";
            this.clientSelectorUserControl.Size = new System.Drawing.Size(750, 380);
            this.clientSelectorUserControl.TabIndex = 0;
            // 
            // tabPageSocialMedia
            // 
            this.tabPageSocialMedia.Controls.Add(this.buttonPublishPropertyOnTwitter);
            this.tabPageSocialMedia.Controls.Add(this.labelSelectedPropertyTitle);
            this.tabPageSocialMedia.Controls.Add(this.labelSelectedProperty);
            this.tabPageSocialMedia.Controls.Add(this.buttonSelectPropertyToPublish);
            this.tabPageSocialMedia.Controls.Add(this.textBoxTwitterAccessTokenSecret);
            this.tabPageSocialMedia.Controls.Add(this.labelTwitterAccessTokenSecret);
            this.tabPageSocialMedia.Controls.Add(this.textBoxTwitterAccessToken);
            this.tabPageSocialMedia.Controls.Add(this.labelTwitterAccessToken);
            this.tabPageSocialMedia.Controls.Add(this.listViewTwitterPublishedBuildings);
            this.tabPageSocialMedia.Controls.Add(this.labelTwitterPublishedProperties);
            this.tabPageSocialMedia.Controls.Add(this.buttonSaveTwitterCredentials);
            this.tabPageSocialMedia.Controls.Add(this.textBoxTwitterApiKeySecret);
            this.tabPageSocialMedia.Controls.Add(this.textBoxTwitterApiKey);
            this.tabPageSocialMedia.Controls.Add(this.labelTwitterApiKeySecret);
            this.tabPageSocialMedia.Controls.Add(this.labelTwitterApiKey);
            this.tabPageSocialMedia.Controls.Add(this.labelCredentials);
            this.tabPageSocialMedia.Controls.Add(this.labelTwitterProfile);
            this.tabPageSocialMedia.Location = new System.Drawing.Point(4, 22);
            this.tabPageSocialMedia.Name = "tabPageSocialMedia";
            this.tabPageSocialMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSocialMedia.Size = new System.Drawing.Size(768, 431);
            this.tabPageSocialMedia.TabIndex = 2;
            this.tabPageSocialMedia.Text = "RRSS";
            this.tabPageSocialMedia.UseVisualStyleBackColor = true;
            // 
            // buttonPublishPropertyOnTwitter
            // 
            this.buttonPublishPropertyOnTwitter.Location = new System.Drawing.Point(173, 321);
            this.buttonPublishPropertyOnTwitter.Name = "buttonPublishPropertyOnTwitter";
            this.buttonPublishPropertyOnTwitter.Size = new System.Drawing.Size(75, 23);
            this.buttonPublishPropertyOnTwitter.TabIndex = 18;
            this.buttonPublishPropertyOnTwitter.Text = "Publicar";
            this.buttonPublishPropertyOnTwitter.UseVisualStyleBackColor = true;
            this.buttonPublishPropertyOnTwitter.Click += new System.EventHandler(this.buttonPublishPropertyOnTwitter_Click);
            // 
            // labelSelectedPropertyTitle
            // 
            this.labelSelectedPropertyTitle.AutoSize = true;
            this.labelSelectedPropertyTitle.Location = new System.Drawing.Point(28, 295);
            this.labelSelectedPropertyTitle.Name = "labelSelectedPropertyTitle";
            this.labelSelectedPropertyTitle.Size = new System.Drawing.Size(47, 13);
            this.labelSelectedPropertyTitle.TabIndex = 17;
            this.labelSelectedPropertyTitle.Text = "Ninguna";
            // 
            // labelSelectedProperty
            // 
            this.labelSelectedProperty.AutoSize = true;
            this.labelSelectedProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedProperty.Location = new System.Drawing.Point(28, 267);
            this.labelSelectedProperty.Name = "labelSelectedProperty";
            this.labelSelectedProperty.Size = new System.Drawing.Size(147, 13);
            this.labelSelectedProperty.TabIndex = 16;
            this.labelSelectedProperty.Text = "Propiedad seleccionada:";
            // 
            // buttonSelectPropertyToPublish
            // 
            this.buttonSelectPropertyToPublish.Location = new System.Drawing.Point(30, 321);
            this.buttonSelectPropertyToPublish.Name = "buttonSelectPropertyToPublish";
            this.buttonSelectPropertyToPublish.Size = new System.Drawing.Size(137, 23);
            this.buttonSelectPropertyToPublish.TabIndex = 15;
            this.buttonSelectPropertyToPublish.Text = "Seleccionar propiedad";
            this.buttonSelectPropertyToPublish.UseVisualStyleBackColor = true;
            this.buttonSelectPropertyToPublish.Click += new System.EventHandler(this.buttonSelectPropertyToPublish_Click);
            // 
            // textBoxTwitterAccessTokenSecret
            // 
            this.textBoxTwitterAccessTokenSecret.Location = new System.Drawing.Point(144, 186);
            this.textBoxTwitterAccessTokenSecret.Name = "textBoxTwitterAccessTokenSecret";
            this.textBoxTwitterAccessTokenSecret.Size = new System.Drawing.Size(618, 20);
            this.textBoxTwitterAccessTokenSecret.TabIndex = 14;
            // 
            // labelTwitterAccessTokenSecret
            // 
            this.labelTwitterAccessTokenSecret.AutoSize = true;
            this.labelTwitterAccessTokenSecret.Location = new System.Drawing.Point(28, 189);
            this.labelTwitterAccessTokenSecret.Name = "labelTwitterAccessTokenSecret";
            this.labelTwitterAccessTokenSecret.Size = new System.Drawing.Size(110, 13);
            this.labelTwitterAccessTokenSecret.TabIndex = 13;
            this.labelTwitterAccessTokenSecret.Text = "Access Token Secret";
            // 
            // textBoxTwitterAccessToken
            // 
            this.textBoxTwitterAccessToken.Location = new System.Drawing.Point(144, 160);
            this.textBoxTwitterAccessToken.Name = "textBoxTwitterAccessToken";
            this.textBoxTwitterAccessToken.Size = new System.Drawing.Size(618, 20);
            this.textBoxTwitterAccessToken.TabIndex = 12;
            // 
            // labelTwitterAccessToken
            // 
            this.labelTwitterAccessToken.AutoSize = true;
            this.labelTwitterAccessToken.Location = new System.Drawing.Point(28, 163);
            this.labelTwitterAccessToken.Name = "labelTwitterAccessToken";
            this.labelTwitterAccessToken.Size = new System.Drawing.Size(76, 13);
            this.labelTwitterAccessToken.TabIndex = 11;
            this.labelTwitterAccessToken.Text = "Access Token";
            // 
            // listViewTwitterPublishedBuildings
            // 
            this.listViewTwitterPublishedBuildings.HideSelection = false;
            this.listViewTwitterPublishedBuildings.Location = new System.Drawing.Point(380, 283);
            this.listViewTwitterPublishedBuildings.Name = "listViewTwitterPublishedBuildings";
            this.listViewTwitterPublishedBuildings.Size = new System.Drawing.Size(382, 126);
            this.listViewTwitterPublishedBuildings.TabIndex = 10;
            this.listViewTwitterPublishedBuildings.UseCompatibleStateImageBehavior = false;
            // 
            // labelTwitterPublishedProperties
            // 
            this.labelTwitterPublishedProperties.AutoSize = true;
            this.labelTwitterPublishedProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwitterPublishedProperties.Location = new System.Drawing.Point(377, 267);
            this.labelTwitterPublishedProperties.Name = "labelTwitterPublishedProperties";
            this.labelTwitterPublishedProperties.Size = new System.Drawing.Size(142, 13);
            this.labelTwitterPublishedProperties.TabIndex = 9;
            this.labelTwitterPublishedProperties.Text = "Propiedades publicadas";
            // 
            // buttonSaveTwitterCredentials
            // 
            this.buttonSaveTwitterCredentials.Location = new System.Drawing.Point(687, 212);
            this.buttonSaveTwitterCredentials.Name = "buttonSaveTwitterCredentials";
            this.buttonSaveTwitterCredentials.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTwitterCredentials.TabIndex = 6;
            this.buttonSaveTwitterCredentials.Text = "Guardar";
            this.buttonSaveTwitterCredentials.UseVisualStyleBackColor = true;
            this.buttonSaveTwitterCredentials.Click += new System.EventHandler(this.buttonSaveTwitterCredentials_Click);
            // 
            // textBoxTwitterApiKeySecret
            // 
            this.textBoxTwitterApiKeySecret.Location = new System.Drawing.Point(144, 134);
            this.textBoxTwitterApiKeySecret.Name = "textBoxTwitterApiKeySecret";
            this.textBoxTwitterApiKeySecret.Size = new System.Drawing.Size(618, 20);
            this.textBoxTwitterApiKeySecret.TabIndex = 5;
            // 
            // textBoxTwitterApiKey
            // 
            this.textBoxTwitterApiKey.Location = new System.Drawing.Point(144, 108);
            this.textBoxTwitterApiKey.Name = "textBoxTwitterApiKey";
            this.textBoxTwitterApiKey.Size = new System.Drawing.Size(618, 20);
            this.textBoxTwitterApiKey.TabIndex = 4;
            // 
            // labelTwitterApiKeySecret
            // 
            this.labelTwitterApiKeySecret.AutoSize = true;
            this.labelTwitterApiKeySecret.Location = new System.Drawing.Point(27, 137);
            this.labelTwitterApiKeySecret.Name = "labelTwitterApiKeySecret";
            this.labelTwitterApiKeySecret.Size = new System.Drawing.Size(79, 13);
            this.labelTwitterApiKeySecret.TabIndex = 3;
            this.labelTwitterApiKeySecret.Text = "API Key Secret";
            // 
            // labelTwitterApiKey
            // 
            this.labelTwitterApiKey.AutoSize = true;
            this.labelTwitterApiKey.Location = new System.Drawing.Point(28, 111);
            this.labelTwitterApiKey.Name = "labelTwitterApiKey";
            this.labelTwitterApiKey.Size = new System.Drawing.Size(45, 13);
            this.labelTwitterApiKey.TabIndex = 2;
            this.labelTwitterApiKey.Text = "API Key";
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
            // labelTwitterProfile
            // 
            this.labelTwitterProfile.AutoSize = true;
            this.labelTwitterProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwitterProfile.Location = new System.Drawing.Point(26, 20);
            this.labelTwitterProfile.Name = "labelTwitterProfile";
            this.labelTwitterProfile.Size = new System.Drawing.Size(142, 24);
            this.labelTwitterProfile.TabIndex = 0;
            this.labelTwitterProfile.Text = "Perfil X (Twitter)";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ListView listViewTwitterPublishedBuildings;
        private System.Windows.Forms.Label labelTwitterPublishedProperties;
        private System.Windows.Forms.Button buttonSaveTwitterCredentials;
        private System.Windows.Forms.TextBox textBoxTwitterApiKeySecret;
        private System.Windows.Forms.TextBox textBoxTwitterApiKey;
        private System.Windows.Forms.Label labelTwitterApiKeySecret;
        private System.Windows.Forms.Label labelTwitterApiKey;
        private System.Windows.Forms.Label labelCredentials;
        private System.Windows.Forms.Label labelTwitterProfile;
        private System.Windows.Forms.TabPage tabPageInit;
        private System.Windows.Forms.LinkLabel linkLabelSelectTab;
        private System.Windows.Forms.Label labelWelcomeTilte;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private CustomControls.ItemSelectorUserControl<Property> propertySelectorUserControl;
        private System.Windows.Forms.Button buttonPropertyDelete;
        private System.Windows.Forms.Button buttonPropertyDetail;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Panel panelProperties;
        private System.Windows.Forms.Button buttonClientNew;
        private System.Windows.Forms.Button buttonClientDetail;
        private System.Windows.Forms.Button buttonClientDelete;
        private CustomControls.ItemSelectorUserControl<Client> clientSelectorUserControl;
        private System.Windows.Forms.TextBox textBoxTwitterAccessToken;
        private System.Windows.Forms.Label labelTwitterAccessToken;
        private System.Windows.Forms.TextBox textBoxTwitterAccessTokenSecret;
        private System.Windows.Forms.Label labelTwitterAccessTokenSecret;
        private System.Windows.Forms.Button buttonSelectPropertyToPublish;
        private System.Windows.Forms.Button buttonPublishPropertyOnTwitter;
        private System.Windows.Forms.Label labelSelectedPropertyTitle;
        private System.Windows.Forms.Label labelSelectedProperty;
    }
}