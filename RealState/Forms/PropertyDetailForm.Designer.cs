﻿namespace RealState.Forms
{
    partial class PropertyDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyDetailForm));
            this.SelectImage = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAreaBuilt = new System.Windows.Forms.Label();
            this.labelAreaUtil = new System.Windows.Forms.Label();
            this.labelAreaParcel = new System.Windows.Forms.Label();
            this.labelAreaKitchen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAreaBuilt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAreaUtil = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAreParcel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKitchen = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRegime = new System.Windows.Forms.ComboBox();
            this.labelRegime = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.dateTimePickerAge = new System.Windows.Forms.DateTimePicker();
            this.labelRoomCount = new System.Windows.Forms.Label();
            this.labelBathRoomCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxHeatingSystem = new System.Windows.Forms.ComboBox();
            this.checkBoxAirConditioning = new System.Windows.Forms.CheckBox();
            this.checkBoxPool = new System.Windows.Forms.CheckBox();
            this.numericUpDownRoomCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBathRoomCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParkingCount = new System.Windows.Forms.NumericUpDown();
            this.labelHeatingSystem = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelPotentialCustomers = new System.Windows.Forms.Label();
            this.listBoxPotentialCustomers = new System.Windows.Forms.ListBox();
            this.labelEurosPrice = new System.Windows.Forms.Label();
            this.labelMeters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSaveBuilding = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxPropertyOwners = new System.Windows.Forms.ListBox();
            this.buttonAddOwner = new System.Windows.Forms.Button();
            this.buttonDeleteOwner = new System.Windows.Forms.Button();
            this.listBoxContracts = new System.Windows.Forms.ListBox();
            this.labelContracts = new System.Windows.Forms.Label();
            this.buttonAddContract = new System.Windows.Forms.Button();
            this.buttonDeleteContract = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaBuilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreParcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathRoomCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParkingCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(41, 181);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(128, 23);
            this.SelectImage.TabIndex = 1;
            this.SelectImage.Text = "Seleccionar Imagen";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(8, 228);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 20);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Superficies";
            // 
            // labelAreaBuilt
            // 
            this.labelAreaBuilt.AutoSize = true;
            this.labelAreaBuilt.Location = new System.Drawing.Point(13, 338);
            this.labelAreaBuilt.Name = "labelAreaBuilt";
            this.labelAreaBuilt.Size = new System.Drawing.Size(59, 13);
            this.labelAreaBuilt.TabIndex = 5;
            this.labelAreaBuilt.Text = "Construída";
            // 
            // labelAreaUtil
            // 
            this.labelAreaUtil.AutoSize = true;
            this.labelAreaUtil.Location = new System.Drawing.Point(13, 364);
            this.labelAreaUtil.Name = "labelAreaUtil";
            this.labelAreaUtil.Size = new System.Drawing.Size(22, 13);
            this.labelAreaUtil.TabIndex = 7;
            this.labelAreaUtil.Text = "Útil";
            // 
            // labelAreaParcel
            // 
            this.labelAreaParcel.AutoSize = true;
            this.labelAreaParcel.Location = new System.Drawing.Point(13, 390);
            this.labelAreaParcel.Name = "labelAreaParcel";
            this.labelAreaParcel.Size = new System.Drawing.Size(43, 13);
            this.labelAreaParcel.TabIndex = 9;
            this.labelAreaParcel.Text = "Parcela";
            // 
            // labelAreaKitchen
            // 
            this.labelAreaKitchen.AutoSize = true;
            this.labelAreaKitchen.Location = new System.Drawing.Point(13, 416);
            this.labelAreaKitchen.Name = "labelAreaKitchen";
            this.labelAreaKitchen.Size = new System.Drawing.Size(40, 13);
            this.labelAreaKitchen.TabIndex = 10;
            this.labelAreaKitchen.Text = "Cocina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Características";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(240, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 13);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Título";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(341, 47);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxTitle.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(341, 73);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 20);
            this.textBoxAddress.TabIndex = 16;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(240, 76);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 13);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Dirección";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(81, 257);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownPrice.TabIndex = 18;
            // 
            // numericUpDownAreaBuilt
            // 
            this.numericUpDownAreaBuilt.Location = new System.Drawing.Point(81, 336);
            this.numericUpDownAreaBuilt.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownAreaBuilt.Name = "numericUpDownAreaBuilt";
            this.numericUpDownAreaBuilt.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownAreaBuilt.TabIndex = 19;
            // 
            // numericUpDownAreaUtil
            // 
            this.numericUpDownAreaUtil.Location = new System.Drawing.Point(81, 362);
            this.numericUpDownAreaUtil.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownAreaUtil.Name = "numericUpDownAreaUtil";
            this.numericUpDownAreaUtil.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownAreaUtil.TabIndex = 20;
            // 
            // numericUpDownAreParcel
            // 
            this.numericUpDownAreParcel.Location = new System.Drawing.Point(81, 388);
            this.numericUpDownAreParcel.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownAreParcel.Name = "numericUpDownAreParcel";
            this.numericUpDownAreParcel.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownAreParcel.TabIndex = 21;
            // 
            // numericUpDownKitchen
            // 
            this.numericUpDownKitchen.Location = new System.Drawing.Point(81, 414);
            this.numericUpDownKitchen.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownKitchen.Name = "numericUpDownKitchen";
            this.numericUpDownKitchen.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownKitchen.TabIndex = 22;
            // 
            // comboBoxRegime
            // 
            this.comboBoxRegime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegime.FormattingEnabled = true;
            this.comboBoxRegime.Items.AddRange(new object[] {
            "Alquiler",
            "Compra/Venta"});
            this.comboBoxRegime.Location = new System.Drawing.Point(341, 99);
            this.comboBoxRegime.Name = "comboBoxRegime";
            this.comboBoxRegime.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRegime.TabIndex = 23;
            // 
            // labelRegime
            // 
            this.labelRegime.AutoSize = true;
            this.labelRegime.Location = new System.Drawing.Point(240, 102);
            this.labelRegime.Name = "labelRegime";
            this.labelRegime.Size = new System.Drawing.Size(49, 13);
            this.labelRegime.TabIndex = 24;
            this.labelRegime.Text = "Régimen";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(240, 129);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(28, 13);
            this.labelType.TabIndex = 25;
            this.labelType.Text = "Tipo";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Casa",
            "Piso"});
            this.comboBoxType.Location = new System.Drawing.Point(341, 126);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxType.TabIndex = 26;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(240, 154);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(61, 13);
            this.labelAge.TabIndex = 27;
            this.labelAge.Text = "Antigüedad";
            // 
            // dateTimePickerAge
            // 
            this.dateTimePickerAge.Location = new System.Drawing.Point(341, 153);
            this.dateTimePickerAge.Name = "dateTimePickerAge";
            this.dateTimePickerAge.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAge.TabIndex = 28;
            // 
            // labelRoomCount
            // 
            this.labelRoomCount.AutoSize = true;
            this.labelRoomCount.Location = new System.Drawing.Point(240, 181);
            this.labelRoomCount.Name = "labelRoomCount";
            this.labelRoomCount.Size = new System.Drawing.Size(69, 13);
            this.labelRoomCount.TabIndex = 29;
            this.labelRoomCount.Text = "Habitaciones";
            // 
            // labelBathRoomCount
            // 
            this.labelBathRoomCount.AutoSize = true;
            this.labelBathRoomCount.Location = new System.Drawing.Point(240, 207);
            this.labelBathRoomCount.Name = "labelBathRoomCount";
            this.labelBathRoomCount.Size = new System.Drawing.Size(37, 13);
            this.labelBathRoomCount.TabIndex = 30;
            this.labelBathRoomCount.Text = "Baños";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Plazas de garaje";
            // 
            // comboBoxHeatingSystem
            // 
            this.comboBoxHeatingSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeatingSystem.FormattingEnabled = true;
            this.comboBoxHeatingSystem.Items.AddRange(new object[] {
            "Caldera de gas",
            "Aerotermia"});
            this.comboBoxHeatingSystem.Location = new System.Drawing.Point(341, 257);
            this.comboBoxHeatingSystem.Name = "comboBoxHeatingSystem";
            this.comboBoxHeatingSystem.Size = new System.Drawing.Size(200, 21);
            this.comboBoxHeatingSystem.TabIndex = 32;
            // 
            // checkBoxAirConditioning
            // 
            this.checkBoxAirConditioning.AutoSize = true;
            this.checkBoxAirConditioning.Location = new System.Drawing.Point(341, 284);
            this.checkBoxAirConditioning.Name = "checkBoxAirConditioning";
            this.checkBoxAirConditioning.Size = new System.Drawing.Size(117, 17);
            this.checkBoxAirConditioning.TabIndex = 33;
            this.checkBoxAirConditioning.Text = "Aire acondicionado";
            this.checkBoxAirConditioning.UseVisualStyleBackColor = true;
            // 
            // checkBoxPool
            // 
            this.checkBoxPool.AutoSize = true;
            this.checkBoxPool.Location = new System.Drawing.Point(243, 286);
            this.checkBoxPool.Name = "checkBoxPool";
            this.checkBoxPool.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPool.TabIndex = 34;
            this.checkBoxPool.Text = "Piscina";
            this.checkBoxPool.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRoomCount
            // 
            this.numericUpDownRoomCount.Location = new System.Drawing.Point(341, 179);
            this.numericUpDownRoomCount.Name = "numericUpDownRoomCount";
            this.numericUpDownRoomCount.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRoomCount.TabIndex = 35;
            // 
            // numericUpDownBathRoomCount
            // 
            this.numericUpDownBathRoomCount.Location = new System.Drawing.Point(341, 205);
            this.numericUpDownBathRoomCount.Name = "numericUpDownBathRoomCount";
            this.numericUpDownBathRoomCount.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBathRoomCount.TabIndex = 36;
            // 
            // numericUpDownParkingCount
            // 
            this.numericUpDownParkingCount.Location = new System.Drawing.Point(341, 231);
            this.numericUpDownParkingCount.Name = "numericUpDownParkingCount";
            this.numericUpDownParkingCount.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownParkingCount.TabIndex = 37;
            // 
            // labelHeatingSystem
            // 
            this.labelHeatingSystem.AutoSize = true;
            this.labelHeatingSystem.Location = new System.Drawing.Point(240, 260);
            this.labelHeatingSystem.Name = "labelHeatingSystem";
            this.labelHeatingSystem.Size = new System.Drawing.Size(63, 13);
            this.labelHeatingSystem.TabIndex = 38;
            this.labelHeatingSystem.Text = "Calefacción";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(239, 316);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(103, 20);
            this.Description.TabIndex = 39;
            this.Description.Text = "Descripción";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(243, 339);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(298, 108);
            this.richTextBoxDescription.TabIndex = 40;
            this.richTextBoxDescription.Text = "";
            // 
            // labelPotentialCustomers
            // 
            this.labelPotentialCustomers.AutoSize = true;
            this.labelPotentialCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotentialCustomers.Location = new System.Drawing.Point(551, 316);
            this.labelPotentialCustomers.Name = "labelPotentialCustomers";
            this.labelPotentialCustomers.Size = new System.Drawing.Size(171, 20);
            this.labelPotentialCustomers.TabIndex = 41;
            this.labelPotentialCustomers.Text = "Clientes potenciales";
            // 
            // listBoxPotentialCustomers
            // 
            this.listBoxPotentialCustomers.FormattingEnabled = true;
            this.listBoxPotentialCustomers.Location = new System.Drawing.Point(552, 339);
            this.listBoxPotentialCustomers.Name = "listBoxPotentialCustomers";
            this.listBoxPotentialCustomers.Size = new System.Drawing.Size(233, 108);
            this.listBoxPotentialCustomers.TabIndex = 43;
            this.listBoxPotentialCustomers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPotentialCustomers_MouseDoubleClick);
            // 
            // labelEurosPrice
            // 
            this.labelEurosPrice.AutoSize = true;
            this.labelEurosPrice.Location = new System.Drawing.Point(175, 259);
            this.labelEurosPrice.Name = "labelEurosPrice";
            this.labelEurosPrice.Size = new System.Drawing.Size(13, 13);
            this.labelEurosPrice.TabIndex = 44;
            this.labelEurosPrice.Text = "€";
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(175, 338);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(21, 13);
            this.labelMeters.TabIndex = 45;
            this.labelMeters.Text = "m2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "m2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "m2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "m2";
            // 
            // buttonSaveBuilding
            // 
            this.buttonSaveBuilding.Location = new System.Drawing.Point(678, 462);
            this.buttonSaveBuilding.Name = "buttonSaveBuilding";
            this.buttonSaveBuilding.Size = new System.Drawing.Size(107, 23);
            this.buttonSaveBuilding.TabIndex = 50;
            this.buttonSaveBuilding.Text = "Guardar cambios";
            this.buttonSaveBuilding.UseVisualStyleBackColor = true;
            this.buttonSaveBuilding.Click += new System.EventHandler(this.buttonSaveBuilding_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Propietarios";
            // 
            // listBoxPropertyOwners
            // 
            this.listBoxPropertyOwners.FormattingEnabled = true;
            this.listBoxPropertyOwners.Location = new System.Drawing.Point(552, 43);
            this.listBoxPropertyOwners.Name = "listBoxPropertyOwners";
            this.listBoxPropertyOwners.Size = new System.Drawing.Size(233, 108);
            this.listBoxPropertyOwners.TabIndex = 52;
            this.listBoxPropertyOwners.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPropertyOwners_MouseDoubleClick);
            // 
            // buttonAddOwner
            // 
            this.buttonAddOwner.Location = new System.Drawing.Point(762, 14);
            this.buttonAddOwner.Name = "buttonAddOwner";
            this.buttonAddOwner.Size = new System.Drawing.Size(23, 23);
            this.buttonAddOwner.TabIndex = 53;
            this.buttonAddOwner.Text = "+";
            this.buttonAddOwner.UseVisualStyleBackColor = true;
            this.buttonAddOwner.Click += new System.EventHandler(this.buttonAddOwner_Click);
            // 
            // buttonDeleteOwner
            // 
            this.buttonDeleteOwner.Location = new System.Drawing.Point(733, 14);
            this.buttonDeleteOwner.Name = "buttonDeleteOwner";
            this.buttonDeleteOwner.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteOwner.TabIndex = 54;
            this.buttonDeleteOwner.Text = "-";
            this.buttonDeleteOwner.UseVisualStyleBackColor = true;
            this.buttonDeleteOwner.Click += new System.EventHandler(this.buttonDeleteOwner_Click);
            // 
            // listBoxContracts
            // 
            this.listBoxContracts.FormattingEnabled = true;
            this.listBoxContracts.Location = new System.Drawing.Point(555, 193);
            this.listBoxContracts.Name = "listBoxContracts";
            this.listBoxContracts.Size = new System.Drawing.Size(233, 108);
            this.listBoxContracts.TabIndex = 55;
            this.listBoxContracts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxContracts_MouseDoubleClick);
            // 
            // labelContracts
            // 
            this.labelContracts.AutoSize = true;
            this.labelContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContracts.Location = new System.Drawing.Point(551, 170);
            this.labelContracts.Name = "labelContracts";
            this.labelContracts.Size = new System.Drawing.Size(88, 20);
            this.labelContracts.TabIndex = 56;
            this.labelContracts.Text = "Contratos";
            // 
            // buttonAddContract
            // 
            this.buttonAddContract.Location = new System.Drawing.Point(762, 164);
            this.buttonAddContract.Name = "buttonAddContract";
            this.buttonAddContract.Size = new System.Drawing.Size(23, 23);
            this.buttonAddContract.TabIndex = 57;
            this.buttonAddContract.Text = "+";
            this.buttonAddContract.UseVisualStyleBackColor = true;
            this.buttonAddContract.Click += new System.EventHandler(this.buttonAddContract_Click);
            // 
            // buttonDeleteContract
            // 
            this.buttonDeleteContract.Location = new System.Drawing.Point(733, 164);
            this.buttonDeleteContract.Name = "buttonDeleteContract";
            this.buttonDeleteContract.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteContract.TabIndex = 58;
            this.buttonDeleteContract.Text = "-";
            this.buttonDeleteContract.UseVisualStyleBackColor = true;
            this.buttonDeleteContract.Click += new System.EventHandler(this.buttonDeleteContract_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::RealState.Properties.Resources.Property_Dafault_Profile_Image;
            this.pictureBoxImage.Location = new System.Drawing.Point(29, 25);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 59;
            this.pictureBoxImage.TabStop = false;
            // 
            // PropertyDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonDeleteContract);
            this.Controls.Add(this.buttonAddContract);
            this.Controls.Add(this.labelContracts);
            this.Controls.Add(this.listBoxContracts);
            this.Controls.Add(this.buttonDeleteOwner);
            this.Controls.Add(this.buttonAddOwner);
            this.Controls.Add(this.listBoxPropertyOwners);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSaveBuilding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMeters);
            this.Controls.Add(this.labelEurosPrice);
            this.Controls.Add(this.listBoxPotentialCustomers);
            this.Controls.Add(this.labelPotentialCustomers);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.labelHeatingSystem);
            this.Controls.Add(this.numericUpDownParkingCount);
            this.Controls.Add(this.numericUpDownBathRoomCount);
            this.Controls.Add(this.numericUpDownRoomCount);
            this.Controls.Add(this.checkBoxPool);
            this.Controls.Add(this.checkBoxAirConditioning);
            this.Controls.Add(this.comboBoxHeatingSystem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelBathRoomCount);
            this.Controls.Add(this.labelRoomCount);
            this.Controls.Add(this.dateTimePickerAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelRegime);
            this.Controls.Add(this.comboBoxRegime);
            this.Controls.Add(this.numericUpDownKitchen);
            this.Controls.Add(this.numericUpDownAreParcel);
            this.Controls.Add(this.numericUpDownAreaUtil);
            this.Controls.Add(this.numericUpDownAreaBuilt);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelAreaKitchen);
            this.Controls.Add(this.labelAreaParcel);
            this.Controls.Add(this.labelAreaUtil);
            this.Controls.Add(this.labelAreaBuilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.SelectImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PropertyDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propiedad";
            this.Load += new System.EventHandler(this.BuildingDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaBuilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreParcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKitchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBathRoomCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParkingCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAreaBuilt;
        private System.Windows.Forms.Label labelAreaUtil;
        private System.Windows.Forms.Label labelAreaParcel;
        private System.Windows.Forms.Label labelAreaKitchen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownAreaBuilt;
        private System.Windows.Forms.NumericUpDown numericUpDownAreaUtil;
        private System.Windows.Forms.NumericUpDown numericUpDownAreParcel;
        private System.Windows.Forms.NumericUpDown numericUpDownKitchen;
        private System.Windows.Forms.ComboBox comboBoxRegime;
        private System.Windows.Forms.Label labelRegime;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.DateTimePicker dateTimePickerAge;
        private System.Windows.Forms.Label labelRoomCount;
        private System.Windows.Forms.Label labelBathRoomCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxHeatingSystem;
        private System.Windows.Forms.CheckBox checkBoxAirConditioning;
        private System.Windows.Forms.CheckBox checkBoxPool;
        private System.Windows.Forms.NumericUpDown numericUpDownRoomCount;
        private System.Windows.Forms.NumericUpDown numericUpDownBathRoomCount;
        private System.Windows.Forms.NumericUpDown numericUpDownParkingCount;
        private System.Windows.Forms.Label labelHeatingSystem;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelPotentialCustomers;
        private System.Windows.Forms.ListBox listBoxPotentialCustomers;
        private System.Windows.Forms.Label labelEurosPrice;
        private System.Windows.Forms.Label labelMeters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSaveBuilding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxPropertyOwners;
        private System.Windows.Forms.Button buttonAddOwner;
        private System.Windows.Forms.Button buttonDeleteOwner;
        private System.Windows.Forms.ListBox listBoxContracts;
        private System.Windows.Forms.Label labelContracts;
        private System.Windows.Forms.Button buttonAddContract;
        private System.Windows.Forms.Button buttonDeleteContract;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}