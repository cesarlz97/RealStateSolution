namespace RealState.Forms
{
    partial class ClientContractsForm
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
            this.listBoxContracts = new System.Windows.Forms.ListBox();
            this.labelContracts = new System.Windows.Forms.Label();
            this.labelContractDetails = new System.Windows.Forms.Label();
            this.labelContractType = new System.Windows.Forms.Label();
            this.comboBoxContractType = new System.Windows.Forms.ComboBox();
            this.labelProperty = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSelectProperty = new System.Windows.Forms.Button();
            this.labelSellers = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddSeller = new System.Windows.Forms.Button();
            this.buttonDeleteSeller = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelBuyers = new System.Windows.Forms.Label();
            this.buttonAddBuyer = new System.Windows.Forms.Button();
            this.buttonDeleteBuyer = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelEuros = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxContracts
            // 
            this.listBoxContracts.FormattingEnabled = true;
            this.listBoxContracts.Location = new System.Drawing.Point(12, 32);
            this.listBoxContracts.Name = "listBoxContracts";
            this.listBoxContracts.Size = new System.Drawing.Size(400, 485);
            this.listBoxContracts.TabIndex = 0;
            // 
            // labelContracts
            // 
            this.labelContracts.AutoSize = true;
            this.labelContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContracts.Location = new System.Drawing.Point(12, 9);
            this.labelContracts.Name = "labelContracts";
            this.labelContracts.Size = new System.Drawing.Size(88, 20);
            this.labelContracts.TabIndex = 1;
            this.labelContracts.Text = "Contratos";
            // 
            // labelContractDetails
            // 
            this.labelContractDetails.AutoSize = true;
            this.labelContractDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContractDetails.Location = new System.Drawing.Point(439, 9);
            this.labelContractDetails.Name = "labelContractDetails";
            this.labelContractDetails.Size = new System.Drawing.Size(176, 20);
            this.labelContractDetails.TabIndex = 2;
            this.labelContractDetails.Text = "Detalles del contrato";
            // 
            // labelContractType
            // 
            this.labelContractType.AutoSize = true;
            this.labelContractType.Location = new System.Drawing.Point(440, 105);
            this.labelContractType.Name = "labelContractType";
            this.labelContractType.Size = new System.Drawing.Size(85, 13);
            this.labelContractType.TabIndex = 3;
            this.labelContractType.Text = "Tipo de contrato";
            // 
            // comboBoxContractType
            // 
            this.comboBoxContractType.FormattingEnabled = true;
            this.comboBoxContractType.Location = new System.Drawing.Point(531, 102);
            this.comboBoxContractType.Name = "comboBoxContractType";
            this.comboBoxContractType.Size = new System.Drawing.Size(257, 21);
            this.comboBoxContractType.TabIndex = 4;
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(440, 50);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(55, 13);
            this.labelProperty.TabIndex = 5;
            this.labelProperty.Text = "Propiedad";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(531, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 6;
            // 
            // buttonSelectProperty
            // 
            this.buttonSelectProperty.Location = new System.Drawing.Point(658, 73);
            this.buttonSelectProperty.Name = "buttonSelectProperty";
            this.buttonSelectProperty.Size = new System.Drawing.Size(130, 23);
            this.buttonSelectProperty.TabIndex = 7;
            this.buttonSelectProperty.Text = "Seleccionar propiedad";
            this.buttonSelectProperty.UseVisualStyleBackColor = true;
            // 
            // labelSellers
            // 
            this.labelSellers.AutoSize = true;
            this.labelSellers.Location = new System.Drawing.Point(440, 144);
            this.labelSellers.Name = "labelSellers";
            this.labelSellers.Size = new System.Drawing.Size(64, 13);
            this.labelSellers.TabIndex = 8;
            this.labelSellers.Text = "Vendedores";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(443, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 108);
            this.listBox1.TabIndex = 9;
            // 
            // buttonAddSeller
            // 
            this.buttonAddSeller.Location = new System.Drawing.Point(736, 274);
            this.buttonAddSeller.Name = "buttonAddSeller";
            this.buttonAddSeller.Size = new System.Drawing.Size(23, 23);
            this.buttonAddSeller.TabIndex = 11;
            this.buttonAddSeller.Text = "+";
            this.buttonAddSeller.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSeller
            // 
            this.buttonDeleteSeller.Location = new System.Drawing.Point(765, 274);
            this.buttonDeleteSeller.Name = "buttonDeleteSeller";
            this.buttonDeleteSeller.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteSeller.TabIndex = 12;
            this.buttonDeleteSeller.Text = "-";
            this.buttonDeleteSeller.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(443, 321);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(345, 108);
            this.listBox2.TabIndex = 13;
            // 
            // labelBuyers
            // 
            this.labelBuyers.AutoSize = true;
            this.labelBuyers.Location = new System.Drawing.Point(440, 305);
            this.labelBuyers.Name = "labelBuyers";
            this.labelBuyers.Size = new System.Drawing.Size(69, 13);
            this.labelBuyers.TabIndex = 14;
            this.labelBuyers.Text = "Compradores";
            // 
            // buttonAddBuyer
            // 
            this.buttonAddBuyer.Location = new System.Drawing.Point(736, 435);
            this.buttonAddBuyer.Name = "buttonAddBuyer";
            this.buttonAddBuyer.Size = new System.Drawing.Size(23, 23);
            this.buttonAddBuyer.TabIndex = 15;
            this.buttonAddBuyer.Text = "+";
            this.buttonAddBuyer.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBuyer
            // 
            this.buttonDeleteBuyer.Location = new System.Drawing.Point(765, 435);
            this.buttonDeleteBuyer.Name = "buttonDeleteBuyer";
            this.buttonDeleteBuyer.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteBuyer.TabIndex = 16;
            this.buttonDeleteBuyer.Text = "-";
            this.buttonDeleteBuyer.UseVisualStyleBackColor = true;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(601, 473);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(42, 13);
            this.labelAmount.TabIndex = 17;
            this.labelAmount.Text = "Importe";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(649, 471);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // labelEuros
            // 
            this.labelEuros.AutoSize = true;
            this.labelEuros.Location = new System.Drawing.Point(775, 473);
            this.labelEuros.Name = "labelEuros";
            this.labelEuros.Size = new System.Drawing.Size(13, 13);
            this.labelEuros.TabIndex = 19;
            this.labelEuros.Text = "€";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(713, 507);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // ClientContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEuros);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonDeleteBuyer);
            this.Controls.Add(this.buttonAddBuyer);
            this.Controls.Add(this.labelBuyers);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonDeleteSeller);
            this.Controls.Add(this.buttonAddSeller);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelSellers);
            this.Controls.Add(this.buttonSelectProperty);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelProperty);
            this.Controls.Add(this.comboBoxContractType);
            this.Controls.Add(this.labelContractType);
            this.Controls.Add(this.labelContractDetails);
            this.Controls.Add(this.labelContracts);
            this.Controls.Add(this.listBoxContracts);
            this.Name = "ClientContractsForm";
            this.Text = "ClientContractsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContracts;
        private System.Windows.Forms.Label labelContracts;
        private System.Windows.Forms.Label labelContractDetails;
        private System.Windows.Forms.Label labelContractType;
        private System.Windows.Forms.ComboBox comboBoxContractType;
        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSelectProperty;
        private System.Windows.Forms.Label labelSellers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddSeller;
        private System.Windows.Forms.Button buttonDeleteSeller;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label labelBuyers;
        private System.Windows.Forms.Button buttonAddBuyer;
        private System.Windows.Forms.Button buttonDeleteBuyer;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelEuros;
        private System.Windows.Forms.Button buttonSave;
    }
}