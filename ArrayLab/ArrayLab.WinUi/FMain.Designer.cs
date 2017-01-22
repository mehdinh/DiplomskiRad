namespace ArrayLab.WinUi
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.treeView = new System.Windows.Forms.TreeView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.loadArrayToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.treeContentSplitter = new System.Windows.Forms.Splitter();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.arrayGridView = new System.Windows.Forms.DataGridView();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.Location = new System.Drawing.Point(0, 25);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(249, 678);
            this.treeView.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadArrayToolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1136, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // loadArrayToolStripDropDownButton
            // 
            this.loadArrayToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadArrayToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.loadArrayToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("loadArrayToolStripDropDownButton.Image")));
            this.loadArrayToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadArrayToolStripDropDownButton.Name = "loadArrayToolStripDropDownButton";
            this.loadArrayToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.loadArrayToolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 703);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1136, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // treeContentSplitter
            // 
            this.treeContentSplitter.Location = new System.Drawing.Point(249, 25);
            this.treeContentSplitter.Name = "treeContentSplitter";
            this.treeContentSplitter.Size = new System.Drawing.Size(5, 678);
            this.treeContentSplitter.TabIndex = 3;
            this.treeContentSplitter.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.arrayGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(254, 25);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(882, 678);
            this.contentPanel.TabIndex = 4;
            // 
            // arrayGridView
            // 
            this.arrayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayGridView.Location = new System.Drawing.Point(240, 137);
            this.arrayGridView.Name = "arrayGridView";
            this.arrayGridView.Size = new System.Drawing.Size(426, 91);
            this.arrayGridView.TabIndex = 0;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.loaderMenuItem_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 725);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.treeContentSplitter);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "FMain";
            this.Text = "Form1";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arrayGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton loadArrayToolStripDropDownButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Splitter treeContentSplitter;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView arrayGridView;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

