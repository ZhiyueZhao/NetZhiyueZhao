namespace NETZhiyueZhao
{
    partial class frmMDIFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIFrame));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileOpenService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenCarWash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataVehicleStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsiOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiOpenSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiOpenService = new System.Windows.Forms.ToolStripMenuItem();
            this.carWashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiTitle = new System.Windows.Forms.ToolStripButton();
            this.tsiLayer = new System.Windows.Forms.ToolStripButton();
            this.tsiCascade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiAbout = new System.Windows.Forms.ToolStripButton();
            this.tsiExit = new System.Windows.Forms.ToolStripButton();
            this.msMainMenu.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuWindow,
            this.mnuData,
            this.mnuHelp});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(809, 28);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "msMainMenu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenSalesQuote,
            this.toolStripSeparator3,
            this.mnuFileOpenService,
            this.mnuFileOpenCarWash});
            this.mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpen.Image")));
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(159, 24);
            this.mnuFileOpen.Text = "&Open";
            // 
            // mnuFileOpenSalesQuote
            // 
            this.mnuFileOpenSalesQuote.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpenSalesQuote.Image")));
            this.mnuFileOpenSalesQuote.Name = "mnuFileOpenSalesQuote";
            this.mnuFileOpenSalesQuote.Size = new System.Drawing.Size(157, 24);
            this.mnuFileOpenSalesQuote.Text = "Sales Quote";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // mnuFileOpenService
            // 
            this.mnuFileOpenService.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpenService.Image")));
            this.mnuFileOpenService.Name = "mnuFileOpenService";
            this.mnuFileOpenService.Size = new System.Drawing.Size(157, 24);
            this.mnuFileOpenService.Text = "Service";
            this.mnuFileOpenService.Click += new System.EventHandler(this.mnuFileOpenService_Click);
            // 
            // mnuFileOpenCarWash
            // 
            this.mnuFileOpenCarWash.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpenCarWash.Image")));
            this.mnuFileOpenCarWash.Name = "mnuFileOpenCarWash";
            this.mnuFileOpenCarWash.Size = new System.Drawing.Size(157, 24);
            this.mnuFileOpenCarWash.Text = "Car Wash";
            this.mnuFileOpenCarWash.Click += new System.EventHandler(this.mnuFileOpenCarWash_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileExit.Image")));
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(159, 24);
            this.mnuFileExit.Text = "E&xit";
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowTile,
            this.mnuWindowLayer,
            this.mnuWindowCascade});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(76, 24);
            this.mnuWindow.Text = "&Window";
            // 
            // mnuWindowTile
            // 
            this.mnuWindowTile.Image = ((System.Drawing.Image)(resources.GetObject("mnuWindowTile.Image")));
            this.mnuWindowTile.Name = "mnuWindowTile";
            this.mnuWindowTile.Size = new System.Drawing.Size(152, 24);
            this.mnuWindowTile.Text = "&Tile";
            // 
            // mnuWindowLayer
            // 
            this.mnuWindowLayer.Image = ((System.Drawing.Image)(resources.GetObject("mnuWindowLayer.Image")));
            this.mnuWindowLayer.Name = "mnuWindowLayer";
            this.mnuWindowLayer.Size = new System.Drawing.Size(152, 24);
            this.mnuWindowLayer.Text = "&Layer";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Image = ((System.Drawing.Image)(resources.GetObject("mnuWindowCascade.Image")));
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(152, 24);
            this.mnuWindowCascade.Text = "&Cascade";
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataVehicleStock});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(53, 24);
            this.mnuData.Text = "&Data";
            // 
            // mnuDataVehicleStock
            // 
            this.mnuDataVehicleStock.Name = "mnuDataVehicleStock";
            this.mnuDataVehicleStock.Size = new System.Drawing.Size(166, 24);
            this.mnuDataVehicleStock.Text = "&Vehicle Stock";
            this.mnuDataVehicleStock.Click += new System.EventHandler(this.vehicleStockToolStripMenuItem_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelpAbout.Image")));
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(119, 24);
            this.mnuHelpAbout.Text = "&About";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiOpen,
            this.toolStripSeparator1,
            this.tsiTitle,
            this.tsiLayer,
            this.tsiCascade,
            this.toolStripSeparator2,
            this.tsiAbout,
            this.tsiExit});
            this.tsMain.Location = new System.Drawing.Point(0, 28);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(809, 25);
            this.tsMain.TabIndex = 3;
            this.tsMain.Text = "tsMain";
            // 
            // tsiOpen
            // 
            this.tsiOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiOpenSalesQuote,
            this.tsiOpenService,
            this.carWashToolStripMenuItem});
            this.tsiOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsiOpen.Image")));
            this.tsiOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiOpen.Name = "tsiOpen";
            this.tsiOpen.Size = new System.Drawing.Size(29, 22);
            this.tsiOpen.Text = "Open";
            // 
            // tsiOpenSalesQuote
            // 
            this.tsiOpenSalesQuote.Image = ((System.Drawing.Image)(resources.GetObject("tsiOpenSalesQuote.Image")));
            this.tsiOpenSalesQuote.Name = "tsiOpenSalesQuote";
            this.tsiOpenSalesQuote.Size = new System.Drawing.Size(157, 24);
            this.tsiOpenSalesQuote.Text = "Sales Quote";
            // 
            // tsiOpenService
            // 
            this.tsiOpenService.Image = ((System.Drawing.Image)(resources.GetObject("tsiOpenService.Image")));
            this.tsiOpenService.Name = "tsiOpenService";
            this.tsiOpenService.Size = new System.Drawing.Size(157, 24);
            this.tsiOpenService.Text = "Service";
            this.tsiOpenService.Click += new System.EventHandler(this.mnuFileOpenService_Click);
            // 
            // carWashToolStripMenuItem
            // 
            this.carWashToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carWashToolStripMenuItem.Image")));
            this.carWashToolStripMenuItem.Name = "carWashToolStripMenuItem";
            this.carWashToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.carWashToolStripMenuItem.Text = "Car wash";
            this.carWashToolStripMenuItem.Click += new System.EventHandler(this.mnuFileOpenCarWash_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsiTitle
            // 
            this.tsiTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiTitle.Image = ((System.Drawing.Image)(resources.GetObject("tsiTitle.Image")));
            this.tsiTitle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiTitle.Name = "tsiTitle";
            this.tsiTitle.Size = new System.Drawing.Size(23, 22);
            this.tsiTitle.Text = "Title";
            // 
            // tsiLayer
            // 
            this.tsiLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiLayer.Image = ((System.Drawing.Image)(resources.GetObject("tsiLayer.Image")));
            this.tsiLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiLayer.Name = "tsiLayer";
            this.tsiLayer.Size = new System.Drawing.Size(23, 22);
            this.tsiLayer.Text = "Layer";
            // 
            // tsiCascade
            // 
            this.tsiCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiCascade.Image = ((System.Drawing.Image)(resources.GetObject("tsiCascade.Image")));
            this.tsiCascade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiCascade.Name = "tsiCascade";
            this.tsiCascade.Size = new System.Drawing.Size(23, 22);
            this.tsiCascade.Text = "Cascade";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsiAbout
            // 
            this.tsiAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsiAbout.Image")));
            this.tsiAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiAbout.Name = "tsiAbout";
            this.tsiAbout.Size = new System.Drawing.Size(23, 22);
            this.tsiAbout.Text = "About";
            // 
            // tsiExit
            // 
            this.tsiExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsiExit.Image")));
            this.tsiExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(23, 22);
            this.tsiExit.Text = "Exit";
            // 
            // frmMDIFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 524);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmMDIFrame";
            this.Text = "frmMDIFrame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenSalesQuote;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTile;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowLayer;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsiOpenSalesQuote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsiTitle;
        private System.Windows.Forms.ToolStripButton tsiLayer;
        private System.Windows.Forms.ToolStripButton tsiCascade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsiAbout;
        private System.Windows.Forms.ToolStripButton tsiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenService;
        private System.Windows.Forms.ToolStripMenuItem tsiOpenService;
        private System.Windows.Forms.ToolStripMenuItem carWashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenCarWash;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuDataVehicleStock;
    }
}