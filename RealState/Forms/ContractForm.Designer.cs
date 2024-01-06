using RealState.Properties;

namespace RealState.Forms
{
    partial class ContractForm
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
            this.labelContractDetails = new System.Windows.Forms.Label();
            this.labelContractType = new System.Windows.Forms.Label();
            this.comboBoxContractType = new System.Windows.Forms.ComboBox();
            this.labelProperty = new System.Windows.Forms.Label();
            this.textBoxPropertyTitle = new System.Windows.Forms.TextBox();
            this.buttonSelectProperty = new System.Windows.Forms.Button();
            this.labelSellers = new System.Windows.Forms.Label();
            this.listBoxSellers = new System.Windows.Forms.ListBox();
            this.buttonAddSeller = new System.Windows.Forms.Button();
            this.buttonDeleteSeller = new System.Windows.Forms.Button();
            this.listBoxBuyers = new System.Windows.Forms.ListBox();
            this.labelBuyers = new System.Windows.Forms.Label();
            this.buttonAddBuyer = new System.Windows.Forms.Button();
            this.buttonDeleteBuyer = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelEuros = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerSignatureDate = new System.Windows.Forms.DateTimePicker();
            this.labelSignatureDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContractDetails
            // 
            this.labelContractDetails.AutoSize = true;
            this.labelContractDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContractDetails.Location = new System.Drawing.Point(12, 9);
            this.labelContractDetails.Name = "labelContractDetails";
            this.labelContractDetails.Size = new System.Drawing.Size(176, 20);
            this.labelContractDetails.TabIndex = 2;
            this.labelContractDetails.Text = "Detalles del contrato";
            // 
            // labelContractType
            // 
            this.labelContractType.AutoSize = true;
            this.labelContractType.Location = new System.Drawing.Point(401, 38);
            this.labelContractType.Name = "labelContractType";
            this.labelContractType.Size = new System.Drawing.Size(85, 13);
            this.labelContractType.TabIndex = 3;
            this.labelContractType.Text = "Tipo de contrato";
            // 
            // comboBoxContractType
            // 
            this.comboBoxContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractType.FormattingEnabled = true;
            this.comboBoxContractType.Items.AddRange(new object[] {
            "Alquiler",
            "Compra/Venta"});
            this.comboBoxContractType.Location = new System.Drawing.Point(404, 54);
            this.comboBoxContractType.Name = "comboBoxContractType";
            this.comboBoxContractType.Size = new System.Drawing.Size(250, 21);
            this.comboBoxContractType.TabIndex = 4;
            this.comboBoxContractType.SelectedIndexChanged += new System.EventHandler(this.comboBoxContractType_SelectedIndexChanged);
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(13, 92);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(55, 13);
            this.labelProperty.TabIndex = 5;
            this.labelProperty.Text = "Propiedad";
            // 
            // textBoxPropertyTitle
            // 
            this.textBoxPropertyTitle.Enabled = false;
            this.textBoxPropertyTitle.Location = new System.Drawing.Point(16, 108);
            this.textBoxPropertyTitle.Name = "textBoxPropertyTitle";
            this.textBoxPropertyTitle.Size = new System.Drawing.Size(349, 20);
            this.textBoxPropertyTitle.TabIndex = 6;
            // 
            // buttonSelectProperty
            // 
            this.buttonSelectProperty.Location = new System.Drawing.Point(235, 134);
            this.buttonSelectProperty.Name = "buttonSelectProperty";
            this.buttonSelectProperty.Size = new System.Drawing.Size(130, 23);
            this.buttonSelectProperty.TabIndex = 7;
            this.buttonSelectProperty.Text = "Seleccionar propiedad";
            this.buttonSelectProperty.UseVisualStyleBackColor = true;
            this.buttonSelectProperty.Click += new System.EventHandler(this.buttonSelectProperty_Click);
            // 
            // labelSellers
            // 
            this.labelSellers.AutoSize = true;
            this.labelSellers.Location = new System.Drawing.Point(13, 222);
            this.labelSellers.Name = "labelSellers";
            this.labelSellers.Size = new System.Drawing.Size(64, 13);
            this.labelSellers.TabIndex = 8;
            this.labelSellers.Text = "Vendedores";
            // 
            // listBoxSellers
            // 
            this.listBoxSellers.FormattingEnabled = true;
            this.listBoxSellers.Location = new System.Drawing.Point(16, 238);
            this.listBoxSellers.Name = "listBoxSellers";
            this.listBoxSellers.Size = new System.Drawing.Size(345, 108);
            this.listBoxSellers.TabIndex = 9;
            // 
            // buttonAddSeller
            // 
            this.buttonAddSeller.Location = new System.Drawing.Point(338, 212);
            this.buttonAddSeller.Name = "buttonAddSeller";
            this.buttonAddSeller.Size = new System.Drawing.Size(23, 23);
            this.buttonAddSeller.TabIndex = 11;
            this.buttonAddSeller.Text = "+";
            this.buttonAddSeller.UseVisualStyleBackColor = true;
            this.buttonAddSeller.Click += new System.EventHandler(this.buttonAddSeller_Click);
            // 
            // buttonDeleteSeller
            // 
            this.buttonDeleteSeller.Location = new System.Drawing.Point(309, 212);
            this.buttonDeleteSeller.Name = "buttonDeleteSeller";
            this.buttonDeleteSeller.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteSeller.TabIndex = 12;
            this.buttonDeleteSeller.Text = "-";
            this.buttonDeleteSeller.UseVisualStyleBackColor = true;
            this.buttonDeleteSeller.Click += new System.EventHandler(this.buttonDeleteSeller_Click);
            // 
            // listBoxBuyers
            // 
            this.listBoxBuyers.FormattingEnabled = true;
            this.listBoxBuyers.Location = new System.Drawing.Point(404, 238);
            this.listBoxBuyers.Name = "listBoxBuyers";
            this.listBoxBuyers.Size = new System.Drawing.Size(345, 108);
            this.listBoxBuyers.TabIndex = 13;
            // 
            // labelBuyers
            // 
            this.labelBuyers.AutoSize = true;
            this.labelBuyers.Location = new System.Drawing.Point(401, 222);
            this.labelBuyers.Name = "labelBuyers";
            this.labelBuyers.Size = new System.Drawing.Size(69, 13);
            this.labelBuyers.TabIndex = 14;
            this.labelBuyers.Text = "Compradores";
            // 
            // buttonAddBuyer
            // 
            this.buttonAddBuyer.Location = new System.Drawing.Point(726, 212);
            this.buttonAddBuyer.Name = "buttonAddBuyer";
            this.buttonAddBuyer.Size = new System.Drawing.Size(23, 23);
            this.buttonAddBuyer.TabIndex = 15;
            this.buttonAddBuyer.Text = "+";
            this.buttonAddBuyer.UseVisualStyleBackColor = true;
            this.buttonAddBuyer.Click += new System.EventHandler(this.buttonAddBuyer_Click);
            // 
            // buttonDeleteBuyer
            // 
            this.buttonDeleteBuyer.Location = new System.Drawing.Point(697, 212);
            this.buttonDeleteBuyer.Name = "buttonDeleteBuyer";
            this.buttonDeleteBuyer.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteBuyer.TabIndex = 16;
            this.buttonDeleteBuyer.Text = "-";
            this.buttonDeleteBuyer.UseVisualStyleBackColor = true;
            this.buttonDeleteBuyer.Click += new System.EventHandler(this.buttonDeleteBuyer_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(401, 151);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(42, 13);
            this.labelAmount.TabIndex = 17;
            this.labelAmount.Text = "Importe";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(404, 167);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAmount.TabIndex = 18;
            // 
            // labelEuros
            // 
            this.labelEuros.AutoSize = true;
            this.labelEuros.Location = new System.Drawing.Point(530, 169);
            this.labelEuros.Name = "labelEuros";
            this.labelEuros.Size = new System.Drawing.Size(13, 13);
            this.labelEuros.TabIndex = 19;
            this.labelEuros.Text = "€";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(674, 352);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Nombre";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(349, 20);
            this.textBoxName.TabIndex = 22;
            // 
            // dateTimePickerSignatureDate
            // 
            this.dateTimePickerSignatureDate.Location = new System.Drawing.Point(404, 108);
            this.dateTimePickerSignatureDate.Name = "dateTimePickerSignatureDate";
            this.dateTimePickerSignatureDate.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerSignatureDate.TabIndex = 23;
            // 
            // labelSignatureDate
            // 
            this.labelSignatureDate.AutoSize = true;
            this.labelSignatureDate.Location = new System.Drawing.Point(401, 92);
            this.labelSignatureDate.Name = "labelSignatureDate";
            this.labelSignatureDate.Size = new System.Drawing.Size(88, 13);
            this.labelSignatureDate.TabIndex = 24;
            this.labelSignatureDate.Text = "Fecha de la firma";
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 384);
            this.Controls.Add(this.labelSignatureDate);
            this.Controls.Add(this.dateTimePickerSignatureDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEuros);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonDeleteBuyer);
            this.Controls.Add(this.buttonAddBuyer);
            this.Controls.Add(this.labelBuyers);
            this.Controls.Add(this.listBoxBuyers);
            this.Controls.Add(this.buttonDeleteSeller);
            this.Controls.Add(this.buttonAddSeller);
            this.Controls.Add(this.listBoxSellers);
            this.Controls.Add(this.labelSellers);
            this.Controls.Add(this.buttonSelectProperty);
            this.Controls.Add(this.textBoxPropertyTitle);
            this.Controls.Add(this.labelProperty);
            this.Controls.Add(this.comboBoxContractType);
            this.Controls.Add(this.labelContractType);
            this.Controls.Add(this.labelContractDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelContractDetails;
        private System.Windows.Forms.Label labelContractType;
        private System.Windows.Forms.ComboBox comboBoxContractType;
        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.TextBox textBoxPropertyTitle;
        private System.Windows.Forms.Button buttonSelectProperty;
        private System.Windows.Forms.Label labelSellers;
        private System.Windows.Forms.ListBox listBoxSellers;
        private System.Windows.Forms.Button buttonAddSeller;
        private System.Windows.Forms.Button buttonDeleteSeller;
        private System.Windows.Forms.ListBox listBoxBuyers;
        private System.Windows.Forms.Label labelBuyers;
        private System.Windows.Forms.Button buttonAddBuyer;
        private System.Windows.Forms.Button buttonDeleteBuyer;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelEuros;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerSignatureDate;
        private System.Windows.Forms.Label labelSignatureDate;
    }
}