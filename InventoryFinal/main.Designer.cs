namespace InventoryFinal
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.new_fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.asset_new_fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.assets_viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reservations_viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Enabled = false;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(1099, 28);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "Menu Bar";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_fileMenu,
            this.exit_fileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 24);
            this.fileMenu.Text = "File";
            // 
            // new_fileMenu
            // 
            this.new_fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asset_new_fileMenu,
            this.reservationToolStripMenuItem,
            this.userToolStripMenuItem});
            this.new_fileMenu.Name = "new_fileMenu";
            this.new_fileMenu.Size = new System.Drawing.Size(216, 26);
            this.new_fileMenu.Text = "&New";
            // 
            // asset_new_fileMenu
            // 
            this.asset_new_fileMenu.Name = "asset_new_fileMenu";
            this.asset_new_fileMenu.Size = new System.Drawing.Size(216, 26);
            this.asset_new_fileMenu.Text = "&Asset";
            this.asset_new_fileMenu.Click += new System.EventHandler(this.resourceToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.reservationToolStripMenuItem.Text = "&Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.userToolStripMenuItem.Text = "&User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // exit_fileMenu
            // 
            this.exit_fileMenu.Name = "exit_fileMenu";
            this.exit_fileMenu.Size = new System.Drawing.Size(216, 26);
            this.exit_fileMenu.Text = "E&xit";
            this.exit_fileMenu.Click += new System.EventHandler(this.exit_fileMenu_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assets_viewMenu,
            this.reservations_viewMenu});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(53, 24);
            this.viewMenu.Text = "View";
            // 
            // assets_viewMenu
            // 
            this.assets_viewMenu.Name = "assets_viewMenu";
            this.assets_viewMenu.Size = new System.Drawing.Size(216, 26);
            this.assets_viewMenu.Text = "Assets";
            this.assets_viewMenu.Click += new System.EventHandler(this.assets_viewMenu_Click);
            // 
            // reservations_viewMenu
            // 
            this.reservations_viewMenu.Name = "reservations_viewMenu";
            this.reservations_viewMenu.Size = new System.Drawing.Size(216, 26);
            this.reservations_viewMenu.Text = "Reservations";
            this.reservations_viewMenu.Click += new System.EventHandler(this.reservations_viewMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1099, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 645);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainWindow";
            this.Text = "Inventory";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem new_fileMenu;
        private System.Windows.Forms.ToolStripMenuItem asset_new_fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exit_fileMenu;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem assets_viewMenu;
        private System.Windows.Forms.ToolStripMenuItem reservations_viewMenu;
    }
}

