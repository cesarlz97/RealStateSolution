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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelClientPhoneNumber = new System.Windows.Forms.Label();
            this.labelClientEmail = new System.Windows.Forms.Label();
            this.labelClientProfile = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPreferences = new System.Windows.Forms.Label();
            this.labelBuildingType = new System.Windows.Forms.Label();
            this.comboBoxBuildingType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBuildingMaxAge = new System.Windows.Forms.DateTimePicker();
            this.labelAge = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBathRoomCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRoomMin = new System.Windows.Forms.NumericUpDown();
            this.labelParkingMin = new System.Windows.Forms.Label();
            this.labelBathRoomMin = new System.Windows.Forms.Label();
            this.labelRoomMin = new System.Windows.Forms.Label();
            this.labelBuildingRegime = new System.Windows.Forms.Label();
            this.comboBoxBuildingRegime = new System.Windows.Forms.ComboBox();
            this.labelPriceMax = new System.Windows.Forms.Label();
            this.numericUpDownPriceMax = new System.Windows.Forms.NumericUpDown();
            this.labelAreaMin = new System.Windows.Forms.Label();
            this.numericUpDownAreaMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPool = new System.Windows.Forms.CheckBox();
            this.labelEurosPrice = new System.Windows.Forms.Label();
            this.labelMeters = new System.Windows.Forms.Label();
            this.labelInterestingBuildings = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathRoomCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaMin)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // labelClientProfile
            // 
            this.labelClientProfile.AutoSize = true;
            this.labelClientProfile.Location = new System.Drawing.Point(12, 314);
            this.labelClientProfile.Name = "labelClientProfile";
            this.labelClientProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelClientProfile.Size = new System.Drawing.Size(30, 13);
            this.labelClientProfile.TabIndex = 9;
            this.labelClientProfile.Text = "Perfil";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Comprador",
            "Inquilino",
            "Vendedor"});
            this.comboBox1.Location = new System.Drawing.Point(67, 311);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // labelPreferences
            // 
            this.labelPreferences.AutoSize = true;
            this.labelPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferences.Location = new System.Drawing.Point(231, 12);
            this.labelPreferences.Name = "labelPreferences";
            this.labelPreferences.Size = new System.Drawing.Size(110, 20);
            this.labelPreferences.TabIndex = 14;
            this.labelPreferences.Text = "Preferencias";
            // 
            // labelBuildingType
            // 
            this.labelBuildingType.AutoSize = true;
            this.labelBuildingType.Location = new System.Drawing.Point(232, 49);
            this.labelBuildingType.Name = "labelBuildingType";
            this.labelBuildingType.Size = new System.Drawing.Size(88, 13);
            this.labelBuildingType.TabIndex = 15;
            this.labelBuildingType.Text = "Tipo de inmueble";
            // 
            // comboBoxBuildingType
            // 
            this.comboBoxBuildingType.FormattingEnabled = true;
            this.comboBoxBuildingType.Items.AddRange(new object[] {
            "Casa",
            "Piso"});
            this.comboBoxBuildingType.Location = new System.Drawing.Point(333, 41);
            this.comboBoxBuildingType.Name = "comboBoxBuildingType";
            this.comboBoxBuildingType.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBuildingType.TabIndex = 16;
            // 
            // dateTimePickerBuildingMaxAge
            // 
            this.dateTimePickerBuildingMaxAge.Location = new System.Drawing.Point(333, 114);
            this.dateTimePickerBuildingMaxAge.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBuildingMaxAge.Name = "dateTimePickerBuildingMaxAge";
            this.dateTimePickerBuildingMaxAge.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBuildingMaxAge.TabIndex = 30;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(232, 114);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(61, 13);
            this.labelAge.TabIndex = 29;
            this.labelAge.Text = "Antigüedad";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(333, 217);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown8.TabIndex = 43;
            // 
            // numericUpDownBathRoomCount
            // 
            this.numericUpDownBathRoomCount.Location = new System.Drawing.Point(333, 185);
            this.numericUpDownBathRoomCount.Name = "numericUpDownBathRoomCount";
            this.numericUpDownBathRoomCount.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBathRoomCount.TabIndex = 42;
            // 
            // numericUpDownRoomMin
            // 
            this.numericUpDownRoomMin.Location = new System.Drawing.Point(333, 149);
            this.numericUpDownRoomMin.Name = "numericUpDownRoomMin";
            this.numericUpDownRoomMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRoomMin.TabIndex = 41;
            // 
            // labelParkingMin
            // 
            this.labelParkingMin.AutoSize = true;
            this.labelParkingMin.Location = new System.Drawing.Point(232, 219);
            this.labelParkingMin.Name = "labelParkingMin";
            this.labelParkingMin.Size = new System.Drawing.Size(93, 13);
            this.labelParkingMin.TabIndex = 40;
            this.labelParkingMin.Text = "Plazas garaje Min.";
            // 
            // labelBathRoomMin
            // 
            this.labelBathRoomMin.AutoSize = true;
            this.labelBathRoomMin.Location = new System.Drawing.Point(232, 187);
            this.labelBathRoomMin.Name = "labelBathRoomMin";
            this.labelBathRoomMin.Size = new System.Drawing.Size(60, 13);
            this.labelBathRoomMin.TabIndex = 39;
            this.labelBathRoomMin.Text = "Baños Min.";
            // 
            // labelRoomMin
            // 
            this.labelRoomMin.AutoSize = true;
            this.labelRoomMin.Location = new System.Drawing.Point(232, 149);
            this.labelRoomMin.Name = "labelRoomMin";
            this.labelRoomMin.Size = new System.Drawing.Size(92, 13);
            this.labelRoomMin.TabIndex = 38;
            this.labelRoomMin.Text = "Habitaciones Min.";
            // 
            // labelBuildingRegime
            // 
            this.labelBuildingRegime.AutoSize = true;
            this.labelBuildingRegime.Location = new System.Drawing.Point(232, 80);
            this.labelBuildingRegime.Name = "labelBuildingRegime";
            this.labelBuildingRegime.Size = new System.Drawing.Size(49, 13);
            this.labelBuildingRegime.TabIndex = 44;
            this.labelBuildingRegime.Text = "Régimen";
            // 
            // comboBoxBuildingRegime
            // 
            this.comboBoxBuildingRegime.FormattingEnabled = true;
            this.comboBoxBuildingRegime.Items.AddRange(new object[] {
            "Alquiler",
            "Compra/Venta"});
            this.comboBoxBuildingRegime.Location = new System.Drawing.Point(333, 77);
            this.comboBoxBuildingRegime.Name = "comboBoxBuildingRegime";
            this.comboBoxBuildingRegime.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBuildingRegime.TabIndex = 45;
            // 
            // labelPriceMax
            // 
            this.labelPriceMax.AutoSize = true;
            this.labelPriceMax.Location = new System.Drawing.Point(232, 314);
            this.labelPriceMax.Name = "labelPriceMax";
            this.labelPriceMax.Size = new System.Drawing.Size(63, 13);
            this.labelPriceMax.TabIndex = 46;
            this.labelPriceMax.Text = "Precio Max.";
            // 
            // numericUpDownPriceMax
            // 
            this.numericUpDownPriceMax.Location = new System.Drawing.Point(333, 307);
            this.numericUpDownPriceMax.Name = "numericUpDownPriceMax";
            this.numericUpDownPriceMax.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownPriceMax.TabIndex = 47;
            // 
            // labelAreaMin
            // 
            this.labelAreaMin.AutoSize = true;
            this.labelAreaMin.Location = new System.Drawing.Point(232, 251);
            this.labelAreaMin.Name = "labelAreaMin";
            this.labelAreaMin.Size = new System.Drawing.Size(77, 13);
            this.labelAreaMin.TabIndex = 48;
            this.labelAreaMin.Text = "Superficie Min.";
            // 
            // numericUpDownAreaMin
            // 
            this.numericUpDownAreaMin.Location = new System.Drawing.Point(333, 249);
            this.numericUpDownAreaMin.Name = "numericUpDownAreaMin";
            this.numericUpDownAreaMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownAreaMin.TabIndex = 49;
            // 
            // checkBoxPool
            // 
            this.checkBoxPool.AutoSize = true;
            this.checkBoxPool.Location = new System.Drawing.Point(235, 285);
            this.checkBoxPool.Name = "checkBoxPool";
            this.checkBoxPool.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPool.TabIndex = 50;
            this.checkBoxPool.Text = "Piscina";
            this.checkBoxPool.UseVisualStyleBackColor = true;
            // 
            // labelEurosPrice
            // 
            this.labelEurosPrice.AutoSize = true;
            this.labelEurosPrice.Location = new System.Drawing.Point(392, 309);
            this.labelEurosPrice.Name = "labelEurosPrice";
            this.labelEurosPrice.Size = new System.Drawing.Size(13, 13);
            this.labelEurosPrice.TabIndex = 51;
            this.labelEurosPrice.Text = "€";
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(392, 251);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(21, 13);
            this.labelMeters.TabIndex = 52;
            this.labelMeters.Text = "m2";
            // 
            // labelInterestingBuildings
            // 
            this.labelInterestingBuildings.AutoSize = true;
            this.labelInterestingBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterestingBuildings.Location = new System.Drawing.Point(498, 184);
            this.labelInterestingBuildings.Name = "labelInterestingBuildings";
            this.labelInterestingBuildings.Size = new System.Drawing.Size(177, 20);
            this.labelInterestingBuildings.TabIndex = 53;
            this.labelInterestingBuildings.Text = "Inmuebles de interés";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(501, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 147);
            this.listBox1.TabIndex = 54;
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.Location = new System.Drawing.Point(692, 388);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(96, 23);
            this.buttonSaveClient.TabIndex = 55;
            this.buttonSaveClient.Text = "Guardar cambios";
            this.buttonSaveClient.UseVisualStyleBackColor = true;
            // 
            // ClientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveClient);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelInterestingBuildings);
            this.Controls.Add(this.labelMeters);
            this.Controls.Add(this.labelEurosPrice);
            this.Controls.Add(this.checkBoxPool);
            this.Controls.Add(this.numericUpDownAreaMin);
            this.Controls.Add(this.labelAreaMin);
            this.Controls.Add(this.numericUpDownPriceMax);
            this.Controls.Add(this.labelPriceMax);
            this.Controls.Add(this.comboBoxBuildingRegime);
            this.Controls.Add(this.labelBuildingRegime);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.numericUpDownBathRoomCount);
            this.Controls.Add(this.numericUpDownRoomMin);
            this.Controls.Add(this.labelParkingMin);
            this.Controls.Add(this.labelBathRoomMin);
            this.Controls.Add(this.labelRoomMin);
            this.Controls.Add(this.dateTimePickerBuildingMaxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.comboBoxBuildingType);
            this.Controls.Add(this.labelBuildingType);
            this.Controls.Add(this.labelPreferences);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelClientProfile);
            this.Controls.Add(this.labelClientEmail);
            this.Controls.Add(this.labelClientPhoneNumber);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "ClientDetailForm";
            this.Text = "ClientDetailForm";
            this.Load += new System.EventHandler(this.ClientDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathRoomCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelClientPhoneNumber;
        private System.Windows.Forms.Label labelClientEmail;
        private System.Windows.Forms.Label labelClientProfile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPreferences;
        private System.Windows.Forms.Label labelBuildingType;
        private System.Windows.Forms.ComboBox comboBoxBuildingType;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuildingMaxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDownBathRoomCount;
        private System.Windows.Forms.NumericUpDown numericUpDownRoomMin;
        private System.Windows.Forms.Label labelParkingMin;
        private System.Windows.Forms.Label labelBathRoomMin;
        private System.Windows.Forms.Label labelRoomMin;
        private System.Windows.Forms.Label labelBuildingRegime;
        private System.Windows.Forms.ComboBox comboBoxBuildingRegime;
        private System.Windows.Forms.Label labelPriceMax;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceMax;
        private System.Windows.Forms.Label labelAreaMin;
        private System.Windows.Forms.NumericUpDown numericUpDownAreaMin;
        private System.Windows.Forms.CheckBox checkBoxPool;
        private System.Windows.Forms.Label labelEurosPrice;
        private System.Windows.Forms.Label labelMeters;
        private System.Windows.Forms.Label labelInterestingBuildings;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSaveClient;
    }
}