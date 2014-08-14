namespace CompositeWFModuleLib
{
    partial class ModuleView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_SaveSelection = new System.Windows.Forms.Button();
            this.m_ProductsList = new System.Windows.Forms.ComboBox();
            this.m_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_ProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_SaveSelection
            // 
            this.m_SaveSelection.Location = new System.Drawing.Point(72, 58);
            this.m_SaveSelection.Name = "m_SaveSelection";
            this.m_SaveSelection.Size = new System.Drawing.Size(167, 23);
            this.m_SaveSelection.TabIndex = 0;
            this.m_SaveSelection.Text = "Save Selection";
            this.m_SaveSelection.UseVisualStyleBackColor = true;
            this.m_SaveSelection.Click += new System.EventHandler(this.OnSaveSelection);
            // 
            // m_ProductsList
            // 
            this.m_ProductsList.DataSource = this.m_ProductsBindingSource;
            this.m_ProductsList.DisplayMember = "Name";
            this.m_ProductsList.FormattingEnabled = true;
            this.m_ProductsList.Location = new System.Drawing.Point(19, 20);
            this.m_ProductsList.Name = "m_ProductsList";
            this.m_ProductsList.Size = new System.Drawing.Size(220, 21);
            this.m_ProductsList.TabIndex = 2;
            // 
            // m_ProductsBindingSource
            // 
            this.m_ProductsBindingSource.DataMember = "Products";
            this.m_ProductsBindingSource.DataSource = typeof(CompositeWFModuleLib.ModuleViewPresentationModel);
            // 
            // ModuleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_ProductsList);
            this.Controls.Add(this.m_SaveSelection);
            this.Name = "ModuleView";
            this.Size = new System.Drawing.Size(256, 104);
            ((System.ComponentModel.ISupportInitialize)(this.m_ProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_SaveSelection;
        private System.Windows.Forms.ComboBox m_ProductsList;
        private System.Windows.Forms.BindingSource m_ProductsBindingSource;
    }
}
