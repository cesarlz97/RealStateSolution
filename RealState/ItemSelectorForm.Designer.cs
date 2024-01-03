using RealState.Models;
using RealState.Models.Interfaces;

namespace RealState
{
    partial class ItemSelectorForm<T> where T : IListable, new()
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
            this.panelItemSelector = new System.Windows.Forms.Panel();
            this.itemSelectorUserControl = new RealState.CustomControls.ItemSelectorUserControl<T>();
            this.buttonSelectItem = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelItemSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemSelector
            // 
            this.panelItemSelector.Controls.Add(this.buttonCancel);
            this.panelItemSelector.Controls.Add(this.buttonSelectItem);
            this.panelItemSelector.Controls.Add(this.itemSelectorUserControl);
            this.panelItemSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItemSelector.Location = new System.Drawing.Point(0, 0);
            this.panelItemSelector.Name = "panelItemSelector";
            this.panelItemSelector.Size = new System.Drawing.Size(800, 430);
            this.panelItemSelector.TabIndex = 0;
            // 
            // itemSelectorUserControl1
            // 
            this.itemSelectorUserControl.Location = new System.Drawing.Point(26, 12);
            this.itemSelectorUserControl.Name = "itemSelectorUserControl1";
            this.itemSelectorUserControl.Size = new System.Drawing.Size(750, 380);
            this.itemSelectorUserControl.TabIndex = 0;
            // 
            // buttonSelectItem
            // 
            this.buttonSelectItem.Location = new System.Drawing.Point(701, 398);
            this.buttonSelectItem.Name = "buttonSelectItem";
            this.buttonSelectItem.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectItem.TabIndex = 1;
            this.buttonSelectItem.Text = "OK";
            this.buttonSelectItem.UseVisualStyleBackColor = true;
            this.buttonSelectItem.Click += new System.EventHandler(this.buttonSelectItem_Click);
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
            // ItemSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.panelItemSelector);
            this.Name = "ItemSelectorForm";
            this.Text = "Selecciona una propiedad";
            this.panelItemSelector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemSelector;
        private CustomControls.ItemSelectorUserControl<T> itemSelectorUserControl;
        private System.Windows.Forms.Button buttonSelectItem;
        private System.Windows.Forms.Button buttonCancel;
    }
}