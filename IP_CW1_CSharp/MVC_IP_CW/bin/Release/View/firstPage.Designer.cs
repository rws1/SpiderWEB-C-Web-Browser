using System;

namespace MVC_IP_CW
{
    partial class firstPage
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.renderWebPageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // renderWebPageToolStripMenuItem
            // 
            this.renderWebPageToolStripMenuItem.Name = "renderWebPageToolStripMenuItem";
            this.renderWebPageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.navigationPanel.Controls.Add(this.statusTextBox);
            this.navigationPanel.Controls.Add(this.NavigateButton);
            this.navigationPanel.Controls.Add(this.htmlCodeTextBox);
            this.navigationPanel.Controls.Add(this.favoritesButton);
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Controls.Add(this.forwardButton);
            this.navigationPanel.Controls.Add(this.backButton);
            this.navigationPanel.Controls.Add(this.addressBoxLabel);
            this.navigationPanel.Controls.Add(this.addressBox);
            this.navigationPanel.Location = new System.Drawing.Point(23, 24);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(721, 339);
            this.navigationPanel.TabIndex = 1;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.Location = new System.Drawing.Point(15, 284);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(691, 52);
            this.statusTextBox.TabIndex = 7;
            // 
            // NavigateButton
            // 
            this.NavigateButton.AccessibleDescription = "Press button to receive the HTML of the URL provided in the address box to the le" +
    "ft";
            this.NavigateButton.AccessibleName = "Navigate Button";
            this.NavigateButton.BackColor = System.Drawing.Color.SeaGreen;
            this.NavigateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigateButton.ForeColor = System.Drawing.SystemColors.Window;
            this.NavigateButton.Location = new System.Drawing.Point(509, 3);
            this.NavigateButton.Name = "NavigateButton";
            this.NavigateButton.Size = new System.Drawing.Size(34, 20);
            this.NavigateButton.TabIndex = 6;
            this.NavigateButton.Text = "GO";
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
            this.htmlCodeTextBox.Location = new System.Drawing.Point(15, 29);
            this.htmlCodeTextBox.Multiline = true;
            this.htmlCodeTextBox.Name = "htmlCodeTextBox";
            this.htmlCodeTextBox.Size = new System.Drawing.Size(691, 249);
            this.htmlCodeTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.htmlCodeTextBox, "This is where any ");
            // 
            // favoritesButton
            // 
            this.favoritesButton.BackColor = System.Drawing.Color.Transparent;
            this.favoritesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.favoritesButton.ForeColor = System.Drawing.Color.Transparent;
            this.favoritesButton.Image = ((System.Drawing.Image)(resources.GetObject("favoritesButton.Image")));
            this.favoritesButton.Location = new System.Drawing.Point(672, 3);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(34, 20);
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
            this.homeButton.Location = new System.Drawing.Point(632, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(34, 20);
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
            this.forwardButton.Location = new System.Drawing.Point(592, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(34, 20);
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
            this.backButton.Location = new System.Drawing.Point(552, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(34, 20);
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
            this.addressBoxLabel.Location = new System.Drawing.Point(12, 7);
            this.addressBoxLabel.Name = "addressBoxLabel";
            this.addressBoxLabel.Size = new System.Drawing.Size(51, 15);
            this.addressBoxLabel.TabIndex = 1;
            this.addressBoxLabel.Text = "Address";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(69, 3);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(434, 20);
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
            this.Text = "SpiderWEB";
            this.Load += new System.EventHandler(this.firstPage_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeHistoryTabComponents()
        {

            tabControl1.TabPages.Add(historyTab);
            historyTab.Controls.Add(historyMainLabel);
            historyTab.Controls.Add(historySearchGroupBox);
            //historyTab.Controls.Add(historySearchButton);
            //historyTab.Controls.Add(textBox1);
            //historyTab.Controls.Add(historySearchListView);
            historyTab.Controls.Add(historyGroupBox);
            //historyTab.Controls.Add(historyDataView);
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
            historySearchGroupBox.Controls.Add(this.textBox1);
            historySearchGroupBox.Controls.Add(this.historySearchGridDataView);
            historySearchGroupBox.Location = new System.Drawing.Point(381, 54);
            historySearchGroupBox.Name = "historySearchGroupBox";
            historySearchGroupBox.Size = new System.Drawing.Size(204, 296);
            historySearchGroupBox.TabIndex = 4;
            historySearchGroupBox.TabStop = false;
            historySearchGroupBox.Text = "History Search";
            // 
            // historySearchButton
            // 
            historySearchButton.Location = new System.Drawing.Point(118, 45);
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
            closeHistoryTabButton.Click += new System.EventHandler(this.closeTabButton_Click);

            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(6, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(187, 20);
            textBox1.TabIndex = 1;
            // 
            // historySearchListView
            // 
            //historySearchGridDataView.HideSelection = false;
            historySearchGridDataView.Location = new System.Drawing.Point(6, 75);
            historySearchGridDataView.Name = "historySearchListView";
            historySearchGridDataView.Size = new System.Drawing.Size(187, 209);
            historySearchGridDataView.TabIndex = 0;
            historySearchGridDataView.Enabled = false;
           // historySearchGridDataView.UseCompatibleStateImageBehavior = false;
            // 
            // historyGroupBox
            // 
            historyGroupBox.Controls.Add(this.historyDataView);
            historyGroupBox.Location = new System.Drawing.Point(12, 54);
            historyGroupBox.Name = "historyGroupBox";
            historyGroupBox.Size = new System.Drawing.Size(363, 296);
            historyGroupBox.TabIndex = 3;
            historyGroupBox.TabStop = false;
            historyGroupBox.Text = "Browsing History";
            // 
            // historyDataView
            // 
            //historyDataView.HideSelection = false;
            historyDataView.Location = new System.Drawing.Point(6, 19);
            historyDataView.Name = "historyListView";
            historyDataView.Size = new System.Drawing.Size(351, 265);
            historyDataView.TabIndex = 0;
            //historyDataView.UseCompatibleStateImageBehavior = false;
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

            //add history data to the list view



        }


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
            //favouritesGridDataView.HideSelection = false;
            favouritesGridDataView.Location = new System.Drawing.Point(6, 19);
            favouritesGridDataView.Name = "favouritesGridDataView";
            favouritesGridDataView.Size = new System.Drawing.Size(351, 198);
            favouritesGridDataView.TabIndex = 0;
            favouritesGridDataView.CellContentDoubleClick += FavouritesGridDataView_CellContentDoubleClick;
            //favouritesGridDataView.UseCompatibleStateImageBehavior = false;
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
            closeFavouritesTabButton.Click += new System.EventHandler(this.closeHistoryTabButton_Click);


            // 
            // favouritesPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // BackColor = System.Drawing.SystemColors.ActiveCaption;
            // ClientSize = new System.Drawing.Size(800, 450);

            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            homePageGroupBox.ResumeLayout(false);
            homePageGroupBox.PerformLayout();
            favouritesGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

            //tabControl1.SelectedTab = historyTab;




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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

