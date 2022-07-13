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
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.zTextBox1 = new IT_ASSET_INVENTORY.UserInterface.Components.zTextBox();
            this.bnfElipseMainPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfElipseDashboardBtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.btnInventory = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlDamageReport = new System.Windows.Forms.Panel();
            this.btnDamageReport = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlAsset = new System.Windows.Forms.Panel();
            this.btnBorrowedAsset = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlRepair = new System.Windows.Forms.Panel();
            this.btnRepairHistory = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfElipseInventory = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfElipseDamageReport = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfElipseAssets = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfElipseRepair = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfSettings = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).BeginInit();
            this.pnlDamageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDamageReport)).BeginInit();
            this.pnlAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrowedAsset)).BeginInit();
            this.pnlRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepairHistory)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnfElipseMainForm
            // 
            this.bnfElipseMainForm.ElipseRadius = 30;
            this.bnfElipseMainForm.TargetControl = this;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnMinimize);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.zTextBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(76, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(917, 635);
            this.pnlMain.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::IT_Asset_Inventory.Properties.Resources.minimize_window_32px1;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(840, 29);
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
            this.btnExit.Location = new System.Drawing.Point(873, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.zTextBox1.Location = new System.Drawing.Point(15, 26);
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
            // bnfElipseMainPanel
            // 
            this.bnfElipseMainPanel.ElipseRadius = 30;
            this.bnfElipseMainPanel.TargetControl = this.pnlMain;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(149)))), ((int)(((byte)(251)))));
            this.pnlDashboard.Controls.Add(this.bunifuImageButton1);
            this.pnlDashboard.Location = new System.Drawing.Point(13, 132);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(48, 48);
            this.pnlDashboard.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::IT_Asset_Inventory.Properties.Resources.dashboard_layout_32px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(8, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
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
            this.pnlSettings.Controls.Add(this.bunifuImageButton2);
            this.pnlSettings.Location = new System.Drawing.Point(13, 575);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(48, 48);
            this.pnlSettings.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = global::IT_Asset_Inventory.Properties.Resources.settings_32px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(8, 8);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bnfSettings
            // 
            this.bnfSettings.ElipseRadius = 15;
            this.bnfSettings.TargetControl = this.pnlSettings;
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
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(993, 635);
            this.Controls.Add(this.pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pnlInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).EndInit();
            this.pnlDamageReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDamageReport)).EndInit();
            this.pnlAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrowedAsset)).EndInit();
            this.pnlRepair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRepairHistory)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bnfElipseMainForm;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseMainPanel;
        private System.Windows.Forms.Panel pnlDashboard;
        private Bunifu.Framework.UI.BunifuElipse bnfElipseDashboardBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
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
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuElipse bnfSettings;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
    }
}