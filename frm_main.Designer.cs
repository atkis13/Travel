namespace Travel
{
    partial class frm_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRealCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.destinationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1509, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // destinationToolStripMenuItem
            // 
            this.destinationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDestinationToolStripMenuItem,
            this.addRoutesToolStripMenuItem,
            this.addCostToolStripMenuItem,
            this.addRealCostToolStripMenuItem});
            this.destinationToolStripMenuItem.Name = "destinationToolStripMenuItem";
            this.destinationToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.destinationToolStripMenuItem.Text = "Destination";
            // 
            // addDestinationToolStripMenuItem
            // 
            this.addDestinationToolStripMenuItem.Name = "addDestinationToolStripMenuItem";
            this.addDestinationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addDestinationToolStripMenuItem.Text = "Add destination";
            // 
            // addRoutesToolStripMenuItem
            // 
            this.addRoutesToolStripMenuItem.Name = "addRoutesToolStripMenuItem";
            this.addRoutesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addRoutesToolStripMenuItem.Text = "Add Routes";
            // 
            // addCostToolStripMenuItem
            // 
            this.addCostToolStripMenuItem.Name = "addCostToolStripMenuItem";
            this.addCostToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addCostToolStripMenuItem.Text = "Estimate Expense";
            // 
            // addRealCostToolStripMenuItem
            // 
            this.addRealCostToolStripMenuItem.Name = "addRealCostToolStripMenuItem";
            this.addRealCostToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addRealCostToolStripMenuItem.Text = "Add real cost";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Complete Travel";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1509, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 627);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRealCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}