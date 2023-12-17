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
            this.buttonNewBuidling = new System.Windows.Forms.Button();
            this.buttonPaginationPreviousBuilding = new System.Windows.Forms.Button();
            this.labelPaginationBuilding = new System.Windows.Forms.Label();
            this.buttonPaginationNextBuilding = new System.Windows.Forms.Button();
            this.exListBoxUserControlBuilding = new RealState.CustomControls.ExListBoxUserControl();
            this.textBoxSearchBuilding = new System.Windows.Forms.TextBox();
            this.labelSearchBuilding = new System.Windows.Forms.Label();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.buttonPaginationPreviousClient = new System.Windows.Forms.Button();
            this.labelPaginationClient = new System.Windows.Forms.Label();
            this.buttonPaginationNextClient = new System.Windows.Forms.Button();
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.labelSearchClient = new System.Windows.Forms.Label();
            this.exListBoxUserControlClient = new RealState.CustomControls.ExListBoxUserControl();
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
            this.tabControlMain.SuspendLayout();
            this.tabPageInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabPageBuildings.SuspendLayout();
            this.tabPageClients.SuspendLayout();
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
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
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
            this.tabPageInit.Size = new System.Drawing.Size(768, 400);
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
            this.tabPageBuildings.Controls.Add(this.buttonNewBuidling);
            this.tabPageBuildings.Controls.Add(this.buttonPaginationPreviousBuilding);
            this.tabPageBuildings.Controls.Add(this.labelPaginationBuilding);
            this.tabPageBuildings.Controls.Add(this.buttonPaginationNextBuilding);
            this.tabPageBuildings.Controls.Add(this.exListBoxUserControlBuilding);
            this.tabPageBuildings.Controls.Add(this.textBoxSearchBuilding);
            this.tabPageBuildings.Controls.Add(this.labelSearchBuilding);
            this.tabPageBuildings.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuildings.Name = "tabPageBuildings";
            this.tabPageBuildings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuildings.Size = new System.Drawing.Size(768, 400);
            this.tabPageBuildings.TabIndex = 0;
            this.tabPageBuildings.Text = "Inmuebles";
            this.tabPageBuildings.UseVisualStyleBackColor = true;
            // 
            // buttonNewBuidling
            // 
            this.buttonNewBuidling.Location = new System.Drawing.Point(687, 351);
            this.buttonNewBuidling.Name = "buttonNewBuidling";
            this.buttonNewBuidling.Size = new System.Drawing.Size(75, 23);
            this.buttonNewBuidling.TabIndex = 6;
            this.buttonNewBuidling.Text = "Nuevo";
            this.buttonNewBuidling.UseVisualStyleBackColor = true;
            this.buttonNewBuidling.Click += new System.EventHandler(this.buttonNewBuidling_Click);
            // 
            // buttonPaginationPreviousBuilding
            // 
            this.buttonPaginationPreviousBuilding.Location = new System.Drawing.Point(286, 351);
            this.buttonPaginationPreviousBuilding.Name = "buttonPaginationPreviousBuilding";
            this.buttonPaginationPreviousBuilding.Size = new System.Drawing.Size(75, 23);
            this.buttonPaginationPreviousBuilding.TabIndex = 5;
            this.buttonPaginationPreviousBuilding.Text = "<<";
            this.buttonPaginationPreviousBuilding.UseVisualStyleBackColor = true;
            // 
            // labelPaginationBuilding
            // 
            this.labelPaginationBuilding.AutoSize = true;
            this.labelPaginationBuilding.Location = new System.Drawing.Point(367, 356);
            this.labelPaginationBuilding.Name = "labelPaginationBuilding";
            this.labelPaginationBuilding.Size = new System.Drawing.Size(34, 13);
            this.labelPaginationBuilding.TabIndex = 4;
            this.labelPaginationBuilding.Text = "1 - 10";
            // 
            // buttonPaginationNextBuilding
            // 
            this.buttonPaginationNextBuilding.Location = new System.Drawing.Point(407, 351);
            this.buttonPaginationNextBuilding.Name = "buttonPaginationNextBuilding";
            this.buttonPaginationNextBuilding.Size = new System.Drawing.Size(75, 23);
            this.buttonPaginationNextBuilding.TabIndex = 3;
            this.buttonPaginationNextBuilding.Text = ">>";
            this.buttonPaginationNextBuilding.UseVisualStyleBackColor = true;
            // 
            // exListBoxUserControlBuilding
            // 
            this.exListBoxUserControlBuilding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.exListBoxUserControlBuilding.FormattingEnabled = true;
            this.exListBoxUserControlBuilding.ItemHeight = 66;
            this.exListBoxUserControlBuilding.Location = new System.Drawing.Point(6, 32);
            this.exListBoxUserControlBuilding.Name = "exListBoxUserControlBuilding";
            this.exListBoxUserControlBuilding.Size = new System.Drawing.Size(756, 300);
            this.exListBoxUserControlBuilding.TabIndex = 2;
            this.exListBoxUserControlBuilding.SelectedValueChanged += new System.EventHandler(this.ExListBoxUserControlBuilding_ItemSelectionChanged);
            // 
            // textBoxSearchBuilding
            // 
            this.textBoxSearchBuilding.Location = new System.Drawing.Point(210, 6);
            this.textBoxSearchBuilding.Name = "textBoxSearchBuilding";
            this.textBoxSearchBuilding.Size = new System.Drawing.Size(375, 20);
            this.textBoxSearchBuilding.TabIndex = 1;
            // 
            // labelSearchBuilding
            // 
            this.labelSearchBuilding.AutoSize = true;
            this.labelSearchBuilding.Location = new System.Drawing.Point(146, 9);
            this.labelSearchBuilding.Name = "labelSearchBuilding";
            this.labelSearchBuilding.Size = new System.Drawing.Size(58, 13);
            this.labelSearchBuilding.TabIndex = 0;
            this.labelSearchBuilding.Text = "Búsqueda:";
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.buttonNewClient);
            this.tabPageClients.Controls.Add(this.buttonPaginationPreviousClient);
            this.tabPageClients.Controls.Add(this.labelPaginationClient);
            this.tabPageClients.Controls.Add(this.buttonPaginationNextClient);
            this.tabPageClients.Controls.Add(this.textBoxSearchClient);
            this.tabPageClients.Controls.Add(this.labelSearchClient);
            this.tabPageClients.Controls.Add(this.exListBoxUserControlClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(768, 400);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clientes";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(687, 351);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(75, 23);
            this.buttonNewClient.TabIndex = 13;
            this.buttonNewClient.Text = "Nuevo";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // buttonPaginationPreviousClient
            // 
            this.buttonPaginationPreviousClient.Location = new System.Drawing.Point(286, 351);
            this.buttonPaginationPreviousClient.Name = "buttonPaginationPreviousClient";
            this.buttonPaginationPreviousClient.Size = new System.Drawing.Size(75, 23);
            this.buttonPaginationPreviousClient.TabIndex = 12;
            this.buttonPaginationPreviousClient.Text = "<<";
            this.buttonPaginationPreviousClient.UseVisualStyleBackColor = true;
            // 
            // labelPaginationClient
            // 
            this.labelPaginationClient.AutoSize = true;
            this.labelPaginationClient.Location = new System.Drawing.Point(367, 356);
            this.labelPaginationClient.Name = "labelPaginationClient";
            this.labelPaginationClient.Size = new System.Drawing.Size(34, 13);
            this.labelPaginationClient.TabIndex = 11;
            this.labelPaginationClient.Text = "1 - 10";
            // 
            // buttonPaginationNextClient
            // 
            this.buttonPaginationNextClient.Location = new System.Drawing.Point(407, 351);
            this.buttonPaginationNextClient.Name = "buttonPaginationNextClient";
            this.buttonPaginationNextClient.Size = new System.Drawing.Size(75, 23);
            this.buttonPaginationNextClient.TabIndex = 10;
            this.buttonPaginationNextClient.Text = ">>";
            this.buttonPaginationNextClient.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(210, 6);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(375, 20);
            this.textBoxSearchClient.TabIndex = 8;
            // 
            // labelSearchClient
            // 
            this.labelSearchClient.AutoSize = true;
            this.labelSearchClient.Location = new System.Drawing.Point(146, 9);
            this.labelSearchClient.Name = "labelSearchClient";
            this.labelSearchClient.Size = new System.Drawing.Size(58, 13);
            this.labelSearchClient.TabIndex = 7;
            this.labelSearchClient.Text = "Búsqueda:";
            // 
            // exListBoxUserControlClient
            // 
            this.exListBoxUserControlClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.exListBoxUserControlClient.FormattingEnabled = true;
            this.exListBoxUserControlClient.ItemHeight = 66;
            this.exListBoxUserControlClient.Location = new System.Drawing.Point(6, 32);
            this.exListBoxUserControlClient.Name = "exListBoxUserControlClient";
            this.exListBoxUserControlClient.Size = new System.Drawing.Size(756, 300);
            this.exListBoxUserControlClient.TabIndex = 9;
            this.exListBoxUserControlClient.SelectedValueChanged += new System.EventHandler(this.ExListBoxUserControlClient_ItemSelectionChanged);
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
            this.tabPageSocialMedia.Size = new System.Drawing.Size(768, 400);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageInit.ResumeLayout(false);
            this.tabPageInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabPageBuildings.ResumeLayout(false);
            this.tabPageBuildings.PerformLayout();
            this.tabPageClients.ResumeLayout(false);
            this.tabPageClients.PerformLayout();
            this.tabPageSocialMedia.ResumeLayout(false);
            this.tabPageSocialMedia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageBuildings;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageSocialMedia;
        private System.Windows.Forms.TextBox textBoxSearchBuilding;
        private System.Windows.Forms.Label labelSearchBuilding;
        private System.Windows.Forms.Button buttonPaginationPreviousBuilding;
        private System.Windows.Forms.Label labelPaginationBuilding;
        private System.Windows.Forms.Button buttonPaginationNextBuilding;
        private CustomControls.ExListBoxUserControl exListBoxUserControlBuilding;
        private System.Windows.Forms.Button buttonNewBuidling;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Button buttonPaginationPreviousClient;
        private System.Windows.Forms.Label labelPaginationClient;
        private System.Windows.Forms.Button buttonPaginationNextClient;
        private CustomControls.ExListBoxUserControl exListBoxUserControlClient;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.Label labelSearchClient;
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
    }
}