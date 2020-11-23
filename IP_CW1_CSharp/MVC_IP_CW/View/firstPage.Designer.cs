using System;

namespace MVC_IP_CW
{
    // <summary> Class <c> firstPage /c>
    /// 
    /// Creates and initialises the skeleton of the GUI. 
    /// 
    /// </summary>
    partial class firstPage
    {
        /// <summary>
        /// Form Designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Used to release unmanaged resources.
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

        /// <summary>
        /// Initialises Components for the firstPage
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderWebPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBrowsingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBrowsingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.statusCodeLabel = new System.Windows.Forms.Label();
            this.resfreshButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.NavigateButton = new System.Windows.Forms.Button();
            this.htmlCodeTextBox = new System.Windows.Forms.TextBox();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addressBoxLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.NavigateButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.forwardsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.homeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.favouritesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addressBarToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.resfreshToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.htmlCodetoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.renderWebPageToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // renderWebPageToolStripMenuItem
            // 
            this.renderWebPageToolStripMenuItem.Name = "renderWebPageToolStripMenuItem";
            this.renderWebPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renderWebPageToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.renderWebPageToolStripMenuItem.Text = "Render WebPage";
            this.renderWebPageToolStripMenuItem.Click += new System.EventHandler(this.renderWebPageToolStripMenuItem_Click_1);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFavouritesToolStripMenuItem});
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            // 
            // manageFavouritesToolStripMenuItem
            // 
            this.manageFavouritesToolStripMenuItem.Name = "manageFavouritesToolStripMenuItem";
            this.manageFavouritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.manageFavouritesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.manageFavouritesToolStripMenuItem.Text = "Manage Favourites";
            this.manageFavouritesToolStripMenuItem.Click += new System.EventHandler(this.manageFavouritesToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBrowsingHistoryToolStripMenuItem,
            this.clearBrowsingHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // viewBrowsingHistoryToolStripMenuItem
            // 
            this.viewBrowsingHistoryToolStripMenuItem.Name = "viewBrowsingHistoryToolStripMenuItem";
            this.viewBrowsingHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.viewBrowsingHistoryToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.viewBrowsingHistoryToolStripMenuItem.Text = "View Browsing History";
            this.viewBrowsingHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewBrowsingHistoryToolStripMenuItem_Click);
            // 
            // clearBrowsingHistoryToolStripMenuItem
            // 
            this.clearBrowsingHistoryToolStripMenuItem.Name = "clearBrowsingHistoryToolStripMenuItem";
            this.clearBrowsingHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearBrowsingHistoryToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.clearBrowsingHistoryToolStripMenuItem.Text = "Clear Browsing History";
            this.clearBrowsingHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearBrowsingHistoryToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.homeTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 4;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.navigationPanel);
            this.homeTab.Location = new System.Drawing.Point(4, 22);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(768, 385);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home Page";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigationPanel.Controls.Add(this.statusCodeLabel);
            this.navigationPanel.Controls.Add(this.resfreshButton);
            this.navigationPanel.Controls.Add(this.statusTextBox);
            this.navigationPanel.Controls.Add(this.NavigateButton);
            this.navigationPanel.Controls.Add(this.htmlCodeTextBox);
            this.navigationPanel.Controls.Add(this.favoritesButton);
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Controls.Add(this.forwardButton);
            this.navigationPanel.Controls.Add(this.backButton);
            this.navigationPanel.Controls.Add(this.addressBoxLabel);
            this.navigationPanel.Controls.Add(this.addressBox);
            this.navigationPanel.Location = new System.Drawing.Point(6, 6);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(756, 373);
            this.navigationPanel.TabIndex = 1;
            // 
            // statusCodeLabel
            // 
            this.statusCodeLabel.AutoSize = true;
            this.statusCodeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCodeLabel.Location = new System.Drawing.Point(12, 355);
            this.statusCodeLabel.Name = "statusCodeLabel";
            this.statusCodeLabel.Size = new System.Drawing.Size(102, 15);
            this.statusCodeLabel.TabIndex = 9;
            this.statusCodeLabel.Text = "HTTP Status Code";
            // 
            // resfreshButton
            // 
            this.resfreshButton.AccessibleName = "Navigate Button";
            this.resfreshButton.BackColor = System.Drawing.Color.Transparent;
            this.resfreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resfreshButton.ForeColor = System.Drawing.SystemColors.Window;
            this.resfreshButton.Image = ((System.Drawing.Image)(resources.GetObject("resfreshButton.Image")));
            this.resfreshButton.Location = new System.Drawing.Point(549, 7);
            this.resfreshButton.Name = "resfreshButton";
            this.resfreshButton.Size = new System.Drawing.Size(29, 30);
            this.resfreshButton.TabIndex = 8;
            this.resfreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resfreshToolTip.SetToolTip(this.resfreshButton, "Press this button to resfresh the current page");
            this.resfreshButton.UseVisualStyleBackColor = false;
            this.resfreshButton.Click += new System.EventHandler(this.resfreshButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.Location = new System.Drawing.Point(120, 353);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(621, 20);
            this.statusTextBox.TabIndex = 7;
            // 
            // NavigateButton
            // 
            this.NavigateButton.AccessibleName = "Navigate Button";
            this.NavigateButton.BackColor = System.Drawing.Color.Transparent;
            this.NavigateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigateButton.ForeColor = System.Drawing.SystemColors.Window;
            this.NavigateButton.Image = ((System.Drawing.Image)(resources.GetObject("NavigateButton.Image")));
            this.NavigateButton.Location = new System.Drawing.Point(504, 7);
            this.NavigateButton.Name = "NavigateButton";
            this.NavigateButton.Size = new System.Drawing.Size(39, 30);
            this.NavigateButton.TabIndex = 6;
            this.NavigateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NavigateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NavigateButtonToolTip.SetToolTip(this.NavigateButton, "Press this button to navigate to the URL provided in the address box to the left");
            this.NavigateButton.UseVisualStyleBackColor = false;
            this.NavigateButton.Click += new System.EventHandler(this.NavigateButton_Click);
            // 
            // htmlCodeTextBox
            // 
            this.htmlCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlCodeTextBox.Location = new System.Drawing.Point(15, 43);
            this.htmlCodeTextBox.Multiline = true;
            this.htmlCodeTextBox.Name = "htmlCodeTextBox";
            this.htmlCodeTextBox.Size = new System.Drawing.Size(726, 308);
            this.htmlCodeTextBox.TabIndex = 2;
            this.htmlCodetoolTip.SetToolTip(this.htmlCodeTextBox, "This is where any html code will display ");
            // 
            // favoritesButton
            // 
            this.favoritesButton.BackColor = System.Drawing.Color.Transparent;
            this.favoritesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.favoritesButton.ForeColor = System.Drawing.Color.Transparent;
            this.favoritesButton.Image = ((System.Drawing.Image)(resources.GetObject("favoritesButton.Image")));
            this.favoritesButton.Location = new System.Drawing.Point(709, 7);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(32, 30);
            this.favoritesButton.TabIndex = 5;
            this.favouritesToolTip.SetToolTip(this.favoritesButton, "Press this to add a website to your favourites");
            this.favoritesButton.UseVisualStyleBackColor = false;
            this.favoritesButton.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(669, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(34, 30);
            this.homeButton.TabIndex = 4;
            this.homeToolTip.SetToolTip(this.homeButton, "Press this to go to your homepage");
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forwardButton.ForeColor = System.Drawing.Color.Transparent;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.Location = new System.Drawing.Point(626, 7);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(37, 30);
            this.forwardButton.TabIndex = 3;
            this.forwardsToolTip.SetToolTip(this.forwardButton, "Press this to undo one press of the back button");
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(584, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(36, 30);
            this.backButton.TabIndex = 2;
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backToolTip.SetToolTip(this.backButton, "Press this button to go to the last site you visited");
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addressBoxLabel
            // 
            this.addressBoxLabel.AutoSize = true;
            this.addressBoxLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBoxLabel.Location = new System.Drawing.Point(12, 15);
            this.addressBoxLabel.Name = "addressBoxLabel";
            this.addressBoxLabel.Size = new System.Drawing.Size(51, 15);
            this.addressBoxLabel.TabIndex = 1;
            this.addressBoxLabel.Text = "Address";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(73, 13);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(425, 20);
            this.addressBox.TabIndex = 0;
            this.addressBarToolTip.SetToolTip(this.addressBox, "Enter a URL here, then press GO to navigate there. ");
            // 
            // NavigateButtonToolTip
            // 
            this.NavigateButtonToolTip.AutoPopDelay = 5000;
            this.NavigateButtonToolTip.InitialDelay = 1000;
            this.NavigateButtonToolTip.ReshowDelay = 100;
            this.NavigateButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NavigateButtonToolTip.ToolTipTitle = "Navigate Button";
            // 
            // backToolTip
            // 
            this.backToolTip.AutoPopDelay = 5000;
            this.backToolTip.InitialDelay = 1000;
            this.backToolTip.ReshowDelay = 100;
            this.backToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.backToolTip.ToolTipTitle = "Back Button";
            // 
            // forwardsToolTip
            // 
            this.forwardsToolTip.AutoPopDelay = 5000;
            this.forwardsToolTip.InitialDelay = 1000;
            this.forwardsToolTip.ReshowDelay = 100;
            this.forwardsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.forwardsToolTip.ToolTipTitle = "Forwards Button";
            // 
            // homeToolTip
            // 
            this.homeToolTip.AutoPopDelay = 5000;
            this.homeToolTip.InitialDelay = 1000;
            this.homeToolTip.ReshowDelay = 100;
            this.homeToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.homeToolTip.ToolTipTitle = "Home Button";
            // 
            // favouritesToolTip
            // 
            this.favouritesToolTip.AutoPopDelay = 5000;
            this.favouritesToolTip.InitialDelay = 1000;
            this.favouritesToolTip.ReshowDelay = 100;
            this.favouritesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.favouritesToolTip.ToolTipTitle = "Add to Favourites Button";
            // 
            // addressBarToolTip
            // 
            this.addressBarToolTip.AutoPopDelay = 5000;
            this.addressBarToolTip.InitialDelay = 1000;
            this.addressBarToolTip.ReshowDelay = 100;
            this.addressBarToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.addressBarToolTip.ToolTipTitle = "Address Bar";
            // 
            // resfreshToolTip
            // 
            this.resfreshToolTip.AutoPopDelay = 5000;
            this.resfreshToolTip.InitialDelay = 1000;
            this.resfreshToolTip.ReshowDelay = 100;
            this.resfreshToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.resfreshToolTip.ToolTipTitle = "Address Bar";
            // 
            // firstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "firstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpiderWEB";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Initialises Components for the historyTab
        /// </summary>
        private void InitializeHistoryTabComponents()
        {

            tabControl1.TabPages.Add(historyTab);
            historyTab.Controls.Add(historyMainLabel);
            historyTab.Controls.Add(historySearchGroupBox);
            historyTab.Controls.Add(historyGroupBox);
            historyTab.Controls.Add(closeHistoryTabButton);
            historySearchGroupBox.SuspendLayout();
            historyGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // historyMainLabel
            // 
            historyMainLabel.AutoSize = true;
            historyMainLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            historyMainLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            historyMainLabel.Location = new System.Drawing.Point(12, 12);
            historyMainLabel.Name = "historyMainLabel";
            historyMainLabel.Size = new System.Drawing.Size(73, 26);
            historyMainLabel.TabIndex = 5;
            historyMainLabel.Text = "History";
            // 
            // historySearchGroupBox
            // 
            historySearchGroupBox.Controls.Add(this.historySearchButton);
            historySearchGroupBox.Controls.Add(this.historySearchTermTextBox);
            historySearchGroupBox.Controls.Add(this.historySearchGridDataView);
            historySearchGroupBox.Location = new System.Drawing.Point(381, 54);
            historySearchGroupBox.Name = "historySearchGroupBox";
            historySearchGroupBox.Size = new System.Drawing.Size(354, 296);
            historySearchGroupBox.TabIndex = 4;
            historySearchGroupBox.TabStop = false;
            historySearchGroupBox.Text = "History Search";
            // 
            // historySearchButton
            // 
            historySearchButton.Location = new System.Drawing.Point(268, 45);
            historySearchButton.Name = "historySearchButton";
            historySearchButton.Size = new System.Drawing.Size(75, 23);
            historySearchButton.TabIndex = 2;
            historySearchButton.Text = "Search";
            historySearchButton.UseVisualStyleBackColor = true;
            historySearchButton.Click += new System.EventHandler(this.historySearchButton_Click);
            //
            // closeTabButton
            // 
            closeHistoryTabButton.Location = new System.Drawing.Point(745, 5);
            closeHistoryTabButton.Name = "closeTabButton";
            closeHistoryTabButton.Size = new System.Drawing.Size(20, 20);
            closeHistoryTabButton.TabIndex = 2;
            closeHistoryTabButton.Text = "X";
            closeHistoryTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            closeHistoryTabButton.Click += new System.EventHandler(this.closeHistoryTabButton_Click);

            // 
            // historySearchTermTextBox
            // 
            historySearchTermTextBox.Location = new System.Drawing.Point(6, 19);
            historySearchTermTextBox.Name = "textBox1";
            historySearchTermTextBox.Size = new System.Drawing.Size(337, 20);
            historySearchTermTextBox.TabIndex = 1;
            // 
            // historySearchDataGridView
            // 
            historySearchGridDataView.Location = new System.Drawing.Point(6, 75);
            historySearchGridDataView.Name = "historySearchListView";
            historySearchGridDataView.Size = new System.Drawing.Size(337, 209);
            historySearchGridDataView.TabIndex = 0;
            historySearchGridDataView.ReadOnly = true; 
            historySearchGridDataView.CellContentDoubleClick += historySearchGridDataView_CellContentDoubleClick;
            // 
            // historyGroupBox
            // 
            historyGroupBox.Controls.Add(this.historyDataGridView);
            historyGroupBox.Location = new System.Drawing.Point(12, 54);
            historyGroupBox.Name = "historyGroupBox";
            historyGroupBox.Size = new System.Drawing.Size(363, 296);
            historyGroupBox.TabIndex = 3;
            historyGroupBox.TabStop = false;
            historyGroupBox.Text = "Browsing History";
            // 
            // historyDataGridView
            //     
            historyDataGridView.Location = new System.Drawing.Point(6, 19);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.Size = new System.Drawing.Size(351, 265);
            historyDataGridView.TabIndex = 0;
            historyDataGridView.ReadOnly = true; 
            historyDataGridView.CellContentDoubleClick += historyGridDataView_CellContentDoubleClick;
            // 
            // historyPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            historyTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            historySearchGroupBox.ResumeLayout(false);
            historySearchGroupBox.PerformLayout();
            historyGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Initialises Components for the favouritesTabPage
        /// </summary>
        private void InitializeFavouritesTabComponents()
        {

            tabControl1.TabPages.Add(favouritesTab);
            favouritesTab.Controls.Add(this.homePageGroupBox);
            favouritesTab.Controls.Add(this.favouritesGroupBox);
            favouritesTab.Controls.Add(this.favouritesMainLabel);
            favouritesTab.Controls.Add(closeFavouritesTabButton);
            favouritesTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            homePageGroupBox.SuspendLayout();
            favouritesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // homePageGroupBox
            // 
            homePageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            homePageGroupBox.Controls.Add(this.changeHomePageButton);
            homePageGroupBox.Controls.Add(this.homePageTextBox);
            homePageGroupBox.Location = new System.Drawing.Point(12, 264);
            homePageGroupBox.Name = "homePageGroupBox";
            homePageGroupBox.Size = new System.Drawing.Size(495, 50);
            homePageGroupBox.TabIndex = 10;
            homePageGroupBox.TabStop = false;
            homePageGroupBox.Text = "Home Page";
            // 
            // changeHomePageButton
            // 
            changeHomePageButton.Location = new System.Drawing.Point(362, 20);
            changeHomePageButton.Name = "changeHomePageButton";
            changeHomePageButton.Size = new System.Drawing.Size(75, 23);
            changeHomePageButton.TabIndex = 1;
            changeHomePageButton.Text = "Change";
            changeHomePageButton.UseVisualStyleBackColor = true;
            changeHomePageButton.Click += new System.EventHandler(this.changeHomePageButton_Click);
            // 
            // homePageTextBox
            // 
            homePageTextBox.Location = new System.Drawing.Point(7, 20);
            homePageTextBox.Name = "homePageTextBox";
            homePageTextBox.Size = new System.Drawing.Size(344, 20);
            homePageTextBox.TabIndex = 0;
            
            // 
            // favouritesGroupBox
            // 
            favouritesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            favouritesGroupBox.Controls.Add(this.favouritesGridDataView);
            favouritesGroupBox.Controls.Add(this.removeFavouriteButton);
            favouritesGroupBox.Controls.Add(this.addFavouritesButton);
            favouritesGroupBox.Location = new System.Drawing.Point(12, 35);
            favouritesGroupBox.Name = "favouritesGroupBox";
            favouritesGroupBox.Size = new System.Drawing.Size(495, 223);
            favouritesGroupBox.TabIndex = 9;
            favouritesGroupBox.TabStop = false;
            favouritesGroupBox.Text = "Favourites";
            // 
            // favouritesGridDataView
            // 
            favouritesGridDataView.Location = new System.Drawing.Point(6, 19);
            favouritesGridDataView.Name = "favouritesGridDataView";
            favouritesGridDataView.Size = new System.Drawing.Size(351, 198);
            favouritesGridDataView.TabIndex = 0;
            favouritesGridDataView.ReadOnly = true;
            favouritesGridDataView.CellContentDoubleClick += favouritesGridDataView_CellContentDoubleClick;
            // 
            // removeFavouriteButton
            // 
            removeFavouriteButton.Location = new System.Drawing.Point(368, 48);
            removeFavouriteButton.Name = "removeFavouriteButton";
            removeFavouriteButton.Size = new System.Drawing.Size(121, 23);
            removeFavouriteButton.TabIndex = 6;
            removeFavouriteButton.Text = "Remove Favourite";
            removeFavouriteButton.UseVisualStyleBackColor = true;
            removeFavouriteButton.Click += new System.EventHandler(this.removeFavouriteButton_Click);
            // 
            // addFavouritesButton
            // 
            addFavouritesButton.Location = new System.Drawing.Point(368, 19);
            addFavouritesButton.Name = "addFavouritesButton";
            addFavouritesButton.Size = new System.Drawing.Size(121, 23);
            addFavouritesButton.TabIndex = 5;
            addFavouritesButton.Text = "Add New Favourite";
            addFavouritesButton.UseVisualStyleBackColor = true;
            addFavouritesButton.Click += new System.EventHandler(this.addFavouritesButton_Click);
            // 
            // favouritesMainLabel
            // 
            favouritesMainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            favouritesMainLabel.AutoSize = true;
            favouritesMainLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            favouritesMainLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            favouritesMainLabel.Location = new System.Drawing.Point(7, 6);
            favouritesMainLabel.Name = "favouritesMainLabel";
            favouritesMainLabel.Size = new System.Drawing.Size(101, 26);
            favouritesMainLabel.TabIndex = 8;
            favouritesMainLabel.Text = "Favourites";
            //
            // closeTabButton
            // 
            closeFavouritesTabButton.Location = new System.Drawing.Point(745, 5);
            closeFavouritesTabButton.Name = "closeTabButton";
            closeFavouritesTabButton.Size = new System.Drawing.Size(20, 20);
            closeFavouritesTabButton.TabIndex = 2;
            closeFavouritesTabButton.Text = "X";
            closeFavouritesTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            closeFavouritesTabButton.Click += new System.EventHandler(this.closeFavouritesTabButton_Click);
            // 
            // favouritesPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            homePageGroupBox.ResumeLayout(false);
            homePageGroupBox.PerformLayout();
            favouritesGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        /// <summary>
        /// Initialises Components for the AddNewFavouriteTabComponent
        /// </summary>
        private void InitializeAddNewFavouriteTabComponent()
        {
            tabControl1.TabPages.Add(addNewFavouriteTab);
            addNewFavouriteTab.Controls.Add(aliasTextBox);
            addNewFavouriteTab.Controls.Add(favouritesURLTextBox);
            addNewFavouriteTab.Controls.Add(homePageCheckBox);
            addNewFavouriteTab.Controls.Add(aliasLabel);
            addNewFavouriteTab.Controls.Add(urlLabel);
            addNewFavouriteTab.Controls.Add(favouriteAddLabel);
            addNewFavouriteTab.Controls.Add(submitFavouriteButton);
            addNewFavouriteTab.Controls.Add(cancelAddButton);
            this.SuspendLayout();
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(98, 54);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(209, 20);
            this.aliasTextBox.TabIndex = 0;
            // 
            // favouritesURLTextBox
            // 
            this.favouritesURLTextBox.Location = new System.Drawing.Point(98, 90);
            this.favouritesURLTextBox.Name = "favouritesURLTextBox";
            this.favouritesURLTextBox.Size = new System.Drawing.Size(209, 20);
            this.favouritesURLTextBox.TabIndex = 1;
            // 
            // homePageCheckBox
            // 
            this.homePageCheckBox.AutoSize = true;
            this.homePageCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageCheckBox.Location = new System.Drawing.Point(98, 125);
            this.homePageCheckBox.Name = "homePageCheckBox";
            this.homePageCheckBox.Size = new System.Drawing.Size(152, 19);
            this.homePageCheckBox.TabIndex = 2;
            this.homePageCheckBox.Text = "Set as new homepage?";
            this.homePageCheckBox.UseVisualStyleBackColor = true;
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(15, 57);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(77, 13);
            this.aliasLabel.TabIndex = 3;
            this.aliasLabel.Text = "Add Nickname";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(57, 93);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "URL";
            // 
            // favouriteAddLabel
            // 
            this.favouriteAddLabel.AutoSize = true;
            this.favouriteAddLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouriteAddLabel.Location = new System.Drawing.Point(14, 14);
            this.favouriteAddLabel.Name = "favouriteAddLabel";
            this.favouriteAddLabel.Size = new System.Drawing.Size(162, 23);
            this.favouriteAddLabel.TabIndex = 5;
            this.favouriteAddLabel.Text = "Add New Favourite";
            // 
            // submitFavouriteButton
            // 
            this.submitFavouriteButton.Location = new System.Drawing.Point(232, 164);
            this.submitFavouriteButton.Name = "submitFavouriteButton";
            this.submitFavouriteButton.Size = new System.Drawing.Size(75, 23);
            this.submitFavouriteButton.TabIndex = 6;
            this.submitFavouriteButton.Text = "Submit";
            this.submitFavouriteButton.UseVisualStyleBackColor = true;
            this.submitFavouriteButton.Click += new System.EventHandler(this.submitFavouriteButton_Click);
            //
            //cancelAddFavouriteButton
            //
            this.cancelAddButton.Location = new System.Drawing.Point(132, 164);
            this.cancelAddButton.Name = "cancelAddFavouriteButton";
            this.cancelAddButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddButton.TabIndex = 7;
            this.cancelAddButton.Text = "Cancel";
            this.cancelAddButton.UseVisualStyleBackColor = true;
            this.cancelAddButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // addNewFavouriteForm
            // 
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBrowsingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearBrowsingHistoryToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button NavigateButton;
        private System.Windows.Forms.TextBox htmlCodeTextBox;
        private System.Windows.Forms.Button favoritesButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label addressBoxLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ToolStripMenuItem renderWebPageToolStripMenuItem;
        private System.Windows.Forms.ToolTip NavigateButtonToolTip;
        private System.Windows.Forms.ToolTip backToolTip;
        private System.Windows.Forms.ToolTip favouritesToolTip;
        private System.Windows.Forms.ToolTip homeToolTip;
        private System.Windows.Forms.ToolTip forwardsToolTip;
        private System.Windows.Forms.ToolTip addressBarToolTip;
        private System.Windows.Forms.ToolTip resfreshToolTip;
        private System.Windows.Forms.ToolTip htmlCodetoolTip;
        private System.Windows.Forms.Button resfreshButton;
        private System.Windows.Forms.Label statusCodeLabel;

    }
}

