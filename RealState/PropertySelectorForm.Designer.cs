namespace RealState
{
    partial class PropertySelectorForm
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
            this.panelPrpertySelector = new System.Windows.Forms.Panel();
            this.propertySelectorUserControl = new RealState.CustomControls.PropertySelectorUserControl();
            this.buttonSelectProperty = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelPrpertySelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrpertySelector
            // 
            this.panelPrpertySelector.Controls.Add(this.buttonCancel);
            this.panelPrpertySelector.Controls.Add(this.buttonSelectProperty);
            this.panelPrpertySelector.Controls.Add(this.propertySelectorUserControl);
            this.panelPrpertySelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrpertySelector.Location = new System.Drawing.Point(0, 0);
            this.panelPrpertySelector.Name = "panelPrpertySelector";
            this.panelPrpertySelector.Size = new System.Drawing.Size(800, 430);
            this.panelPrpertySelector.TabIndex = 0;
            // 
            // propertySelectorUserControl1
            // 
            this.propertySelectorUserControl.Location = new System.Drawing.Point(26, 12);
            this.propertySelectorUserControl.Name = "propertySelectorUserControl1";
            this.propertySelectorUserControl.Size = new System.Drawing.Size(750, 380);
            this.propertySelectorUserControl.TabIndex = 0;
            // 
            // buttonSelectProperty
            // 
            this.buttonSelectProperty.Location = new System.Drawing.Point(701, 398);
            this.buttonSelectProperty.Name = "buttonSelectProperty";
            this.buttonSelectProperty.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectProperty.TabIndex = 1;
            this.buttonSelectProperty.Text = "OK";
            this.buttonSelectProperty.UseVisualStyleBackColor = true;
            this.buttonSelectProperty.Click += new System.EventHandler(this.buttonSelectProperty_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(620, 398);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PropertySelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.panelPrpertySelector);
            this.Name = "PropertySelectorForm";
            this.Text = "Selecciona una propiedad";
            this.panelPrpertySelector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrpertySelector;
        private CustomControls.PropertySelectorUserControl propertySelectorUserControl;
        private System.Windows.Forms.Button buttonSelectProperty;
        private System.Windows.Forms.Button buttonCancel;
    }
}