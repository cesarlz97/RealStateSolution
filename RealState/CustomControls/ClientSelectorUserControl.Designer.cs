namespace RealState.CustomControls
{
    partial class ClientSelectorUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelItemsPreview = new System.Windows.Forms.Panel();
            this.buttonPaginationPrevious = new System.Windows.Forms.Button();
            this.labelPagination = new System.Windows.Forms.Label();
            this.buttonPaginationNext = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.exListBoxUserControl = new RealState.CustomControls.ExListBoxUserControl();
            this.panelItemsPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemsPreview
            // 
            this.panelItemsPreview.Controls.Add(this.buttonPaginationPrevious);
            this.panelItemsPreview.Controls.Add(this.labelPagination);
            this.panelItemsPreview.Controls.Add(this.buttonPaginationNext);
            this.panelItemsPreview.Controls.Add(this.textBoxSearch);
            this.panelItemsPreview.Controls.Add(this.labelSearch);
            this.panelItemsPreview.Controls.Add(this.exListBoxUserControl);
            this.panelItemsPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItemsPreview.Location = new System.Drawing.Point(0, 0);
            this.panelItemsPreview.Name = "panelItemsPreview";
            this.panelItemsPreview.Size = new System.Drawing.Size(750, 380);
            this.panelItemsPreview.TabIndex = 0;
            // 
            // buttonPaginationPrevious
            // 
            this.buttonPaginationPrevious.Location = new System.Drawing.Point(259, 348);
            this.buttonPaginationPrevious.Name = "buttonPaginationPrevious";
            this.buttonPaginationPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPaginationPrevious.TabIndex = 18;
            this.buttonPaginationPrevious.Text = "<<";
            this.buttonPaginationPrevious.UseVisualStyleBackColor = true;
            this.buttonPaginationPrevious.Click += new System.EventHandler(this.buttonPaginationPrevious_Click);
            // 
            // labelPagination
            // 
            this.labelPagination.AutoSize = true;
            this.labelPagination.Location = new System.Drawing.Point(340, 353);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(70, 13);
            this.labelPagination.TabIndex = 17;
            this.labelPagination.Text = "1 - 10 de 100";
            // 
            // buttonPaginationNext
            // 
            this.buttonPaginationNext.Location = new System.Drawing.Point(416, 348);
            this.buttonPaginationNext.Name = "buttonPaginationNext";
            this.buttonPaginationNext.Size = new System.Drawing.Size(75, 23);
            this.buttonPaginationNext.TabIndex = 16;
            this.buttonPaginationNext.Text = ">>";
            this.buttonPaginationNext.UseVisualStyleBackColor = true;
            this.buttonPaginationNext.Click += new System.EventHandler(this.buttonPaginationNext_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(188, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(375, 20);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(124, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(58, 13);
            this.labelSearch.TabIndex = 13;
            this.labelSearch.Text = "Búsqueda:";
            // 
            // exListBoxUserControl
            // 
            this.exListBoxUserControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.exListBoxUserControl.FormattingEnabled = true;
            this.exListBoxUserControl.ItemHeight = 66;
            this.exListBoxUserControl.Location = new System.Drawing.Point(5, 42);
            this.exListBoxUserControl.Name = "exListBoxUserControl";
            this.exListBoxUserControl.Size = new System.Drawing.Size(740, 300);
            this.exListBoxUserControl.TabIndex = 15;
            // 
            // ClientSelectorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelItemsPreview);
            this.Name = "ClientSelectorUserControl";
            this.Size = new System.Drawing.Size(750, 380);
            this.panelItemsPreview.ResumeLayout(false);
            this.panelItemsPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemsPreview;
        private System.Windows.Forms.Button buttonPaginationPrevious;
        private System.Windows.Forms.Label labelPagination;
        private System.Windows.Forms.Button buttonPaginationNext;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private ExListBoxUserControl exListBoxUserControl;
    }
}
