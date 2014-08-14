namespace CompositeWindowsFormsEventsAndModulesDemo
{
    partial class Shell
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
            this.m_MainRegionPanel = new System.Windows.Forms.Panel();
            this.m_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.mStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_MainRegionPanel
            // 
            this.m_MainRegionPanel.Location = new System.Drawing.Point(42, 32);
            this.m_MainRegionPanel.Name = "m_MainRegionPanel";
            this.m_MainRegionPanel.Size = new System.Drawing.Size(420, 255);
            this.m_MainRegionPanel.TabIndex = 0;
            // 
            // m_StatusStrip
            // 
            this.m_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStatusLabel,
            this.m_StatusLabel});
            this.m_StatusStrip.Location = new System.Drawing.Point(0, 330);
            this.m_StatusStrip.Name = "m_StatusStrip";
            this.m_StatusStrip.Size = new System.Drawing.Size(541, 22);
            this.m_StatusStrip.TabIndex = 1;
            this.m_StatusStrip.Text = "statusStrip1";
            // 
            // mStatusLabel
            // 
            this.mStatusLabel.Name = "mStatusLabel";
            this.mStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // m_StatusLabel
            // 
            this.m_StatusLabel.Name = "m_StatusLabel";
            this.m_StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.m_StatusLabel.Text = "Ready";
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 352);
            this.Controls.Add(this.m_StatusStrip);
            this.Controls.Add(this.m_MainRegionPanel);
            this.Name = "Shell";
            this.Text = "Shell";
            this.m_StatusStrip.ResumeLayout(false);
            this.m_StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel m_MainRegionPanel;
        private System.Windows.Forms.StatusStrip m_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel mStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel m_StatusLabel;
    }
}

