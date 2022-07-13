namespace IT_Asset_Inventory.Forms
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.bnfElipseMainForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.switchingPanell = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.bnfElipseMainPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.bnfElipseDashboardBtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnlDamageReport = new System.Windows.Forms.Panel();
            this.pnlAsset = new System.Windows.Forms.Panel();
            this.pnlRepair = new System.Windows.Forms.Panel();
            this.bnfElipseInventory = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfElipseDamageReport = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfElipseAssets = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfElipseRepair = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.bnfSettings = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.titleDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlPurchaseHistory = new System.Windows.Forms.Panel();
            this.bnfElipsePurchaseHistory = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRepairHistory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBorrowedAsset = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDamageReport = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnInventory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPurchaseHistory = new Bunifu.Framework.UI.BunifuImageButton();
            this.zTextBox1 = new IT_ASSET_INVENTORY.UserInterface.Components.zTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.pnlDamageReport.SuspendLayout();
            this.pnlAsset.SuspendLayout();
            this.pnlRepair.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlPurchaseHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepairHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrowedAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDamageReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // bnfElipseMainForm
            // 
            this.bnfElipseMainForm.ElipseRadius = 35;
            this.bnfElipseMainForm.TargetControl = this;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.switchingPanell);
            this.pnlMain.Controls.Add(this.pnlTitleBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(76, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1204, 720);
            this.pnlMain.TabIndex = 0;
            // 
            // switchingPanell
            // 
            this.switchingPanell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchingPanell.Location = new System.Drawing.Point(0, 76);
            this.switchingPanell.Name = "switchingPanell";
            this.switchingPanell.Size = new System.Drawing.Size(1204, 644);
            this.switchingPanell.TabIndex = 3;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnUser);
            this.pnlTitleBar.Controls.Add(this.zTextBox1);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1204, 76);
            this.pnlTitleBar.TabIndex = 2;
            // 
            // bnfElipseMainPanel
            // 
            this.bnfElipseMainPanel.ElipseRadius = 35;
            this.bnfElipseMainPanel.TargetControl = this.pnlMain;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(149)))), ((int)(((byte)(251)))));
            this.pnlDashboard.Controls.Add(this.btnDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(13, 132);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(48, 48);
            this.pnlDashboard.TabIndex = 1;
            // 
            // bnfElipseDashboardBtn
            // 
            this.bnfElipseDashboardBtn.ElipseRadius = 15;
            this.bnfElipseDashboardBtn.TargetControl = this.pnlDashboard;
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.pnlInventory.Controls.Add(this.btnInventory);
            this.pnlInventory.Location = new System.Drawing.Point(13, 214);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(48, 48);
            this.pnlInventory.TabIndex = 1;
            // 
            // pnlDamageReport
            // 
            this.pnlDamageReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.pnlDamageReport.Controls.Add(this.btnDamageReport);
            this.pnlDamageReport.Location = new System.Drawing.Point(13, 299);
            this.pnlDamageReport.Name = "pnlDamageReport";
            this.pnlDamageReport.Size = new System.Drawing.Size(48, 48);
            this.pnlDamageReport.TabIndex = 1;
            // 
            // pnlAsset
            // 
            this.pnlAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.pnlAsset.Controls.Add(this.btnBorrowedAsset);
            this.pnlAsset.Location = new System.Drawing.Point(13, 385);
            this.pnlAsset.Name = "pnlAsset";
            this.pnlAsset.Size = new System.Drawing.Size(48, 48);
            this.pnlAsset.TabIndex = 1;
            // 
            // pnlRepair
            // 
            this.pnlRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.pnlRepair.Controls.Add(this.btnRepairHistory);
            this.pnlRepair.Location = new System.Drawing.Point(13, 465);
            this.pnlRepair.Name = "pnlRepair";
            this.pnlRepair.Size = new System.Drawing.Size(48, 48);
            this.pnlRepair.TabIndex = 1;
            // 
            // bnfElipseInventory
            // 
            this.bnfElipseInventory.ElipseRadius = 15;
            this.bnfElipseInventory.TargetControl = this.pnlInventory;
            // 
            // bnfElipseDamageReport
            // 
            this.bnfElipseDamageReport.ElipseRadius = 15;
            this.bnfElipseDamageReport.TargetControl = this.pnlDamageReport;
            // 
            // bnfElipseAssets
            // 
            this.bnfElipseAssets.ElipseRadius = 15;
            this.bnfElipseAssets.TargetControl = this.pnlAsset;
            // 
            // bnfElipseRepair
            // 
            this.bnfElipseRepair.ElipseRadius = 15;
            this.bnfElipseRepair.TargetControl = this.pnlRepair;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Location = new System.Drawing.Point(13, 660);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(48, 48);
            this.pnlSettings.TabIndex = 1;
            // 
            // bnfSettings
            // 
            this.bnfSettings.ElipseRadius = 15;
            this.bnfSettings.TargetControl = this.pnlSettings;
            // 
            // titleDrag
            // 
            this.titleDrag.Fixed = true;
            this.titleDrag.Horizontal = true;
            this.titleDrag.TargetControl = this.pnlTitleBar;
            this.titleDrag.Vertical = true;
            // 
            // pnlPurchaseHistory
            // 
            this.pnlPurchaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.pnlPurchaseHistory.Controls.Add(this.btnPurchaseHistory);
            this.pnlPurchaseHistory.Location = new System.Drawing.Point(13, 544);
            this.pnlPurchaseHistory.Name = "pnlPurchaseHistory";
            this.pnlPurchaseHistory.Size = new System.Drawing.Size(48, 48);
            this.pnlPurchaseHistory.TabIndex = 1;
            // 
            // bnfElipsePurchaseHistory
            // 
            this.bnfElipsePurchaseHistory.ElipseRadius = 5;
            this.bnfElipsePurchaseHistory.TargetControl = this.pnlPurchaseHistory;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IT_Asset_Inventory.Properties.Resources.circles;
            this.pictureBox2.Location = new System.Drawing.Point(22, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::IT_Asset_Inventory.Properties.Resources.settings_32px;
            this.btnSettings.ImageActive = null;
            this.btnSettings.Location = new System.Drawing.Point(8, 8);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TabStop = false;
            this.btnSettings.Zoom = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRepairHistory
            // 
            this.btnRepairHistory.Image = global::IT_Asset_Inventory.Properties.Resources.computer_support_32px;
            this.btnRepairHistory.ImageActive = null;
            this.btnRepairHistory.Location = new System.Drawing.Point(8, 8);
            this.btnRepairHistory.Name = "btnRepairHistory";
            this.btnRepairHistory.Size = new System.Drawing.Size(32, 32);
            this.btnRepairHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRepairHistory.TabIndex = 0;
            this.btnRepairHistory.TabStop = false;
            this.btnRepairHistory.Zoom = 10;
            this.btnRepairHistory.Click += new System.EventHandler(this.btnRepairHistory_Click);
            // 
            // btnBorrowedAsset
            // 
            this.btnBorrowedAsset.Image = global::IT_Asset_Inventory.Properties.Resources.company_assets_32px;
            this.btnBorrowedAsset.ImageActive = null;
            this.btnBorrowedAsset.Location = new System.Drawing.Point(8, 8);
            this.btnBorrowedAsset.Name = "btnBorrowedAsset";
            this.btnBorrowedAsset.Size = new System.Drawing.Size(32, 32);
            this.btnBorrowedAsset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrowedAsset.TabIndex = 0;
            this.btnBorrowedAsset.TabStop = false;
            this.btnBorrowedAsset.Zoom = 10;
            this.btnBorrowedAsset.Click += new System.EventHandler(this.btnBorrowedAsset_Click);
            // 
            // btnDamageReport
            // 
            this.btnDamageReport.Image = global::IT_Asset_Inventory.Properties.Resources.broken;
            this.btnDamageReport.ImageActive = null;
            this.btnDamageReport.Location = new System.Drawing.Point(8, 8);
            this.btnDamageReport.Name = "btnDamageReport";
            this.btnDamageReport.Size = new System.Drawing.Size(32, 32);
            this.btnDamageReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDamageReport.TabIndex = 0;
            this.btnDamageReport.TabStop = false;
            this.btnDamageReport.Zoom = 10;
            this.btnDamageReport.Click += new System.EventHandler(this.btnDamageReport_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Image = global::IT_Asset_Inventory.Properties.Resources.inventory_logo;
            this.btnInventory.ImageActive = null;
            this.btnInventory.Location = new System.Drawing.Point(8, 8);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(32, 32);
            this.btnInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInventory.TabIndex = 0;
            this.btnInventory.TabStop = false;
            this.btnInventory.Zoom = 10;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Image = global::IT_Asset_Inventory.Properties.Resources.dashboard_layout_32px;
            this.btnDashboard.ImageActive = null;
            this.btnDashboard.Location = new System.Drawing.Point(8, 8);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(32, 32);
            this.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Zoom = 10;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IT_Asset_Inventory.Properties.Resources.circles;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.Image = global::IT_Asset_Inventory.Properties.Resources.name_32px;
            this.btnUser.ImageActive = null;
            this.btnUser.Location = new System.Drawing.Point(1092, 28);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(32, 32);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 2;
            this.btnUser.TabStop = false;
            this.btnUser.Zoom = 10;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::IT_Asset_Inventory.Properties.Resources.minimize_window_32px1;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1127, 28);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::IT_Asset_Inventory.Properties.Resources.exit1;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1162, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.Image = global::IT_Asset_Inventory.Properties.Resources.transaction_list_32px;
            this.btnPurchaseHistory.ImageActive = null;
            this.btnPurchaseHistory.Location = new System.Drawing.Point(8, 8);
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.Size = new System.Drawing.Size(32, 32);
            this.btnPurchaseHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPurchaseHistory.TabIndex = 1;
            this.btnPurchaseHistory.TabStop = false;
            this.btnPurchaseHistory.Zoom = 10;
            this.btnPurchaseHistory.Click += new System.EventHandler(this.btnPurchaseHistory_Click);
            // 
            // zTextBox1
            // 
            this.zTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.zTextBox1.BorderColor = System.Drawing.Color.White;
            this.zTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.zTextBox1.BorderRadius = 15;
            this.zTextBox1.BorderSize = 2;
            this.zTextBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zTextBox1.Location = new System.Drawing.Point(10, 25);
            this.zTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.zTextBox1.Multiline = false;
            this.zTextBox1.Name = "zTextBox1";
            this.zTextBox1.Padding = new System.Windows.Forms.Padding(10);
            this.zTextBox1.PasswordChar = false;
            this.zTextBox1.passwordCharacter = '\0';
            this.zTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.zTextBox1.PlaceholderText = "search";
            this.zTextBox1.Size = new System.Drawing.Size(712, 39);
            this.zTextBox1.TabIndex = 0;
            this.zTextBox1.Texts = "";
            this.zTextBox1.UnderlinedStyle = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlPurchaseHistory);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlRepair);
            this.Controls.Add(this.pnlAsset);
            this.Controls.Add(this.pnlDamageReport);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlInventory.ResumeLayout(false);
            this.pnlDamageReport.ResumeLayout(false);
            this.pnlAsset.ResumeLayout(false);
            this.pnlRepair.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlPurchaseHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepairHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrowedAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDamageReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPurchaseHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bnfElipseMainForm;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseMainPanel;
        private System.Windows.Forms.Panel pnlDashboard;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseDashboardBtn;
        private Bunifu.Framework.UI.BunifuImageButton btnDashboard;
        private System.Windows.Forms.Panel pnlInventory;
        private Bunifu.Framework.UI.BunifuImageButton btnInventory;
        private System.Windows.Forms.Panel pnlAsset;
        private Bunifu.Framework.UI.BunifuImageButton btnBorrowedAsset;
        private System.Windows.Forms.Panel pnlDamageReport;
        private Bunifu.Framework.UI.BunifuImageButton btnDamageReport;
        private IT_ASSET_INVENTORY.UserInterface.Components.zTextBox zTextBox1;
        private System.Windows.Forms.Panel pnlRepair;
        private Bunifu.Framework.UI.BunifuImageButton btnRepairHistory;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseInventory;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseDamageReport;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseAssets;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseRepair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSettings;
        private Bunifu.Framework.UI.BunifuImageButton btnSettings;
        private Bunifu.Framework.UI.BunifuElipse bnfSettings;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel pnlTitleBar;
        private Bunifu.Framework.UI.BunifuDragControl titleDrag;
        private System.Windows.Forms.Panel switchingPanell;
        private Bunifu.Framework.UI.BunifuImageButton btnUser;
        private System.Windows.Forms.Panel pnlPurchaseHistory;
        private Bunifu.Framework.UI.BunifuElipse bnfElipsePurchaseHistory;
        private Bunifu.Framework.UI.BunifuImageButton btnPurchaseHistory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}