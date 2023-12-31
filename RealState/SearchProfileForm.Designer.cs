namespace RealState
{
    partial class SearchProfileForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxPropertiesMatching = new System.Windows.Forms.ListBox();
            this.labelInterestingBuildings = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMeters = new System.Windows.Forms.Label();
            this.labelEurosPrice = new System.Windows.Forms.Label();
            this.checkBoxPool = new System.Windows.Forms.CheckBox();
            this.numericUpDownAreaMin = new System.Windows.Forms.NumericUpDown();
            this.labelAreaMin = new System.Windows.Forms.Label();
            this.numericUpDownPriceMax = new System.Windows.Forms.NumericUpDown();
            this.labelPriceMax = new System.Windows.Forms.Label();
            this.comboBoxBuildingRegime = new System.Windows.Forms.ComboBox();
            this.labelBuildingRegime = new System.Windows.Forms.Label();
            this.numericUpDownParkingCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBathRoomCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRoomMin = new System.Windows.Forms.NumericUpDown();
            this.labelParkingMin = new System.Windows.Forms.Label();
            this.labelBathRoomMin = new System.Windows.Forms.Label();
            this.labelRoomMin = new System.Windows.Forms.Label();
            this.dateTimePickerBuildingMaxAge = new System.Windows.Forms.DateTimePicker();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboBoxBuildingType = new System.Windows.Forms.ComboBox();
            this.labelBuildingType = new System.Windows.Forms.Label();
            this.labelSearchProfile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParkingCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathRoomCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxPropertiesMatching);
            this.panel1.Controls.Add(this.labelInterestingBuildings);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelMeters);
            this.panel1.Controls.Add(this.labelEurosPrice);
            this.panel1.Controls.Add(this.checkBoxPool);
            this.panel1.Controls.Add(this.numericUpDownAreaMin);
            this.panel1.Controls.Add(this.labelAreaMin);
            this.panel1.Controls.Add(this.numericUpDownPriceMax);
            this.panel1.Controls.Add(this.labelPriceMax);
            this.panel1.Controls.Add(this.comboBoxBuildingRegime);
            this.panel1.Controls.Add(this.labelBuildingRegime);
            this.panel1.Controls.Add(this.numericUpDownParkingCount);
            this.panel1.Controls.Add(this.numericUpDownBathRoomCount);
            this.panel1.Controls.Add(this.numericUpDownRoomMin);
            this.panel1.Controls.Add(this.labelParkingMin);
            this.panel1.Controls.Add(this.labelBathRoomMin);
            this.panel1.Controls.Add(this.labelRoomMin);
            this.panel1.Controls.Add(this.dateTimePickerBuildingMaxAge);
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.comboBoxBuildingType);
            this.panel1.Controls.Add(this.labelBuildingType);
            this.panel1.Controls.Add(this.labelSearchProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // listBoxPropertiesMatching
            // 
            this.listBoxPropertiesMatching.FormattingEnabled = true;
            this.listBoxPropertiesMatching.Location = new System.Drawing.Point(386, 44);
            this.listBoxPropertiesMatching.Name = "listBoxPropertiesMatching";
            this.listBoxPropertiesMatching.Size = new System.Drawing.Size(402, 394);
            this.listBoxPropertiesMatching.TabIndex = 77;
            this.listBoxPropertiesMatching.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPropertiesMatching_MouseDoubleClick);
            // 
            // labelInterestingBuildings
            // 
            this.labelInterestingBuildings.AutoSize = true;
            this.labelInterestingBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterestingBuildings.Location = new System.Drawing.Point(382, 11);
            this.labelInterestingBuildings.Name = "labelInterestingBuildings";
            this.labelInterestingBuildings.Size = new System.Drawing.Size(177, 20);
            this.labelInterestingBuildings.TabIndex = 76;
            this.labelInterestingBuildings.Text = "Inmuebles de interés";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 75;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 74;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 73;
            this.labelName.Text = "Nombre";
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(212, 300);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(21, 13);
            this.labelMeters.TabIndex = 72;
            this.labelMeters.Text = "m2";
            // 
            // labelEurosPrice
            // 
            this.labelEurosPrice.AutoSize = true;
            this.labelEurosPrice.Location = new System.Drawing.Point(212, 358);
            this.labelEurosPrice.Name = "labelEurosPrice";
            this.labelEurosPrice.Size = new System.Drawing.Size(13, 13);
            this.labelEurosPrice.TabIndex = 71;
            this.labelEurosPrice.Text = "€";
            // 
            // checkBoxPool
            // 
            this.checkBoxPool.AutoSize = true;
            this.checkBoxPool.Location = new System.Drawing.Point(18, 334);
            this.checkBoxPool.Name = "checkBoxPool";
            this.checkBoxPool.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPool.TabIndex = 70;
            this.checkBoxPool.Text = "Piscina";
            this.checkBoxPool.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAreaMin
            // 
            this.numericUpDownAreaMin.Location = new System.Drawing.Point(116, 298);
            this.numericUpDownAreaMin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownAreaMin.Name = "numericUpDownAreaMin";
            this.numericUpDownAreaMin.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAreaMin.TabIndex = 69;
            // 
            // labelAreaMin
            // 
            this.labelAreaMin.AutoSize = true;
            this.labelAreaMin.Location = new System.Drawing.Point(15, 300);
            this.labelAreaMin.Name = "labelAreaMin";
            this.labelAreaMin.Size = new System.Drawing.Size(77, 13);
            this.labelAreaMin.TabIndex = 68;
            this.labelAreaMin.Text = "Superficie Min.";
            // 
            // numericUpDownPriceMax
            // 
            this.numericUpDownPriceMax.Location = new System.Drawing.Point(116, 356);
            this.numericUpDownPriceMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownPriceMax.Name = "numericUpDownPriceMax";
            this.numericUpDownPriceMax.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownPriceMax.TabIndex = 67;
            // 
            // labelPriceMax
            // 
            this.labelPriceMax.AutoSize = true;
            this.labelPriceMax.Location = new System.Drawing.Point(15, 363);
            this.labelPriceMax.Name = "labelPriceMax";
            this.labelPriceMax.Size = new System.Drawing.Size(63, 13);
            this.labelPriceMax.TabIndex = 66;
            this.labelPriceMax.Text = "Precio Max.";
            // 
            // comboBoxBuildingRegime
            // 
            this.comboBoxBuildingRegime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuildingRegime.FormattingEnabled = true;
            this.comboBoxBuildingRegime.Items.AddRange(new object[] {
            "Alquiler",
            "Compra/Venta"});
            this.comboBoxBuildingRegime.Location = new System.Drawing.Point(116, 126);
            this.comboBoxBuildingRegime.Name = "comboBoxBuildingRegime";
            this.comboBoxBuildingRegime.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBuildingRegime.TabIndex = 65;
            // 
            // labelBuildingRegime
            // 
            this.labelBuildingRegime.AutoSize = true;
            this.labelBuildingRegime.Location = new System.Drawing.Point(15, 129);
            this.labelBuildingRegime.Name = "labelBuildingRegime";
            this.labelBuildingRegime.Size = new System.Drawing.Size(49, 13);
            this.labelBuildingRegime.TabIndex = 64;
            this.labelBuildingRegime.Text = "Régimen";
            // 
            // numericUpDownParkingCount
            // 
            this.numericUpDownParkingCount.Location = new System.Drawing.Point(116, 266);
            this.numericUpDownParkingCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownParkingCount.Name = "numericUpDownParkingCount";
            this.numericUpDownParkingCount.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownParkingCount.TabIndex = 63;
            // 
            // numericUpDownBathRoomCount
            // 
            this.numericUpDownBathRoomCount.Location = new System.Drawing.Point(116, 234);
            this.numericUpDownBathRoomCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownBathRoomCount.Name = "numericUpDownBathRoomCount";
            this.numericUpDownBathRoomCount.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBathRoomCount.TabIndex = 62;
            // 
            // numericUpDownRoomMin
            // 
            this.numericUpDownRoomMin.Location = new System.Drawing.Point(116, 198);
            this.numericUpDownRoomMin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownRoomMin.Name = "numericUpDownRoomMin";
            this.numericUpDownRoomMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRoomMin.TabIndex = 61;
            // 
            // labelParkingMin
            // 
            this.labelParkingMin.AutoSize = true;
            this.labelParkingMin.Location = new System.Drawing.Point(15, 268);
            this.labelParkingMin.Name = "labelParkingMin";
            this.labelParkingMin.Size = new System.Drawing.Size(93, 13);
            this.labelParkingMin.TabIndex = 60;
            this.labelParkingMin.Text = "Plazas garaje Min.";
            // 
            // labelBathRoomMin
            // 
            this.labelBathRoomMin.AutoSize = true;
            this.labelBathRoomMin.Location = new System.Drawing.Point(15, 236);
            this.labelBathRoomMin.Name = "labelBathRoomMin";
            this.labelBathRoomMin.Size = new System.Drawing.Size(60, 13);
            this.labelBathRoomMin.TabIndex = 59;
            this.labelBathRoomMin.Text = "Baños Min.";
            // 
            // labelRoomMin
            // 
            this.labelRoomMin.AutoSize = true;
            this.labelRoomMin.Location = new System.Drawing.Point(15, 198);
            this.labelRoomMin.Name = "labelRoomMin";
            this.labelRoomMin.Size = new System.Drawing.Size(92, 13);
            this.labelRoomMin.TabIndex = 58;
            this.labelRoomMin.Text = "Habitaciones Min.";
            // 
            // dateTimePickerBuildingMaxAge
            // 
            this.dateTimePickerBuildingMaxAge.Location = new System.Drawing.Point(116, 163);
            this.dateTimePickerBuildingMaxAge.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBuildingMaxAge.Name = "dateTimePickerBuildingMaxAge";
            this.dateTimePickerBuildingMaxAge.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBuildingMaxAge.TabIndex = 57;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(15, 163);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(61, 13);
            this.labelAge.TabIndex = 56;
            this.labelAge.Text = "Antigüedad";
            // 
            // comboBoxBuildingType
            // 
            this.comboBoxBuildingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuildingType.FormattingEnabled = true;
            this.comboBoxBuildingType.Items.AddRange(new object[] {
            "Casa",
            "Piso"});
            this.comboBoxBuildingType.Location = new System.Drawing.Point(116, 90);
            this.comboBoxBuildingType.Name = "comboBoxBuildingType";
            this.comboBoxBuildingType.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBuildingType.TabIndex = 55;
            // 
            // labelBuildingType
            // 
            this.labelBuildingType.AutoSize = true;
            this.labelBuildingType.Location = new System.Drawing.Point(15, 98);
            this.labelBuildingType.Name = "labelBuildingType";
            this.labelBuildingType.Size = new System.Drawing.Size(88, 13);
            this.labelBuildingType.TabIndex = 54;
            this.labelBuildingType.Text = "Tipo de inmueble";
            // 
            // labelSearchProfile
            // 
            this.labelSearchProfile.AutoSize = true;
            this.labelSearchProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchProfile.Location = new System.Drawing.Point(12, 9);
            this.labelSearchProfile.Name = "labelSearchProfile";
            this.labelSearchProfile.Size = new System.Drawing.Size(159, 20);
            this.labelSearchProfile.TabIndex = 53;
            this.labelSearchProfile.Text = "Perfil de búsqueda";
            // 
            // SearchProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SearchProfileForm";
            this.Text = "SearchProfileForm";
            this.Load += new System.EventHandler(this.SearchProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParkingCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathRoomCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMeters;
        private System.Windows.Forms.Label labelEurosPrice;
        private System.Windows.Forms.CheckBox checkBoxPool;
        private System.Windows.Forms.NumericUpDown numericUpDownAreaMin;
        private System.Windows.Forms.Label labelAreaMin;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceMax;
        private System.Windows.Forms.Label labelPriceMax;
        private System.Windows.Forms.ComboBox comboBoxBuildingRegime;
        private System.Windows.Forms.Label labelBuildingRegime;
        private System.Windows.Forms.NumericUpDown numericUpDownParkingCount;
        private System.Windows.Forms.NumericUpDown numericUpDownBathRoomCount;
        private System.Windows.Forms.NumericUpDown numericUpDownRoomMin;
        private System.Windows.Forms.Label labelParkingMin;
        private System.Windows.Forms.Label labelBathRoomMin;
        private System.Windows.Forms.Label labelRoomMin;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuildingMaxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ComboBox comboBoxBuildingType;
        private System.Windows.Forms.Label labelBuildingType;
        private System.Windows.Forms.Label labelSearchProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxPropertiesMatching;
        private System.Windows.Forms.Label labelInterestingBuildings;
    }
}