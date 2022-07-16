using IT_Asset_Inventory.DatabaseManager;
using IT_Asset_Inventory.DialogBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Asset_Inventory.Forms
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        readonly ZHCrypto.Sec security = new ZHCrypto.Sec();
        private void Mainform_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(security.Decrypt(Credentials.db_user), security.Decrypt(Credentials.db_password));
        }
        formClose fc = new formClose();
        private void btnExit_Click(object sender, EventArgs e)
        {
            fc.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ActivateBG(int temp)
        {
            switch(temp)
            {
                //active color 99, 149, 251
                case 0: //dashboard
                    RemoveAllBG();
                    pnlDashboard.BackColor = Color.FromArgb(255, (byte)(int)99, (byte)(int)149, (byte)(int)251);
                    break;
                case 1: //inventory
                    RemoveAllBG();
                    pnlInventory.BackColor = Color.FromArgb(255, (byte)(int)99, (byte)(int)149, (byte)(int)251);
                    break; 
                case 2: //damage report
                    RemoveAllBG();
                    pnlDamageReport.BackColor = Color.FromArgb(255, (byte)(int)99, (byte)(int)149, (byte)(int)251);
                    break;
                case 3: //borrowed asset
                    RemoveAllBG();
                    pnlAsset.BackColor = Color.FromArgb(255, (byte)(int)99, (byte)(int)149, (byte)(int)251);
                    break;
                case 4: //repair history
                    RemoveAllBG();
                    pnlRepair.BackColor = Color.FromArgb(255, (byte)(int)99, (byte)(int)149, (byte)(int)251);
                    break;
                case 5: //settings
                    RemoveAllBG();
                    pnlSettings.BackColor = Color.FromArgb(255, (byte)(int)99, (byte)(int)149, (byte)(int)251);
                    break;
                case 6: //ourchase history
                    RemoveAllBG();
                    pnlPurchaseHistory.BackColor = Color.FromArgb(255, (byte)(int)99, (byte)(int)149, (byte)(int)251);
                    break;
                default: //in case there's an error, just display a message box
                    MessageBox.Show("An error occured. Please contact your administrator.");
                    break;
            }
        }
        private void RemoveAllBG()
        {
            //default color 69, 122, 235
            //remove all default color
            pnlDashboard.BackColor = Color.FromArgb(255, (byte)(int)69, (byte)(int)122, (byte)(int)235);
            pnlDamageReport.BackColor = Color.FromArgb(255, (byte)(int)69, (byte)(int)122, (byte)(int)235);
            pnlAsset.BackColor = Color.FromArgb(255, (byte)(int)69, (byte)(int)122, (byte)(int)235);
            pnlInventory.BackColor = Color.FromArgb(255, (byte)(int)69, (byte)(int)122, (byte)(int)235);
            pnlRepair.BackColor = Color.FromArgb(255, (byte)(int)69, (byte)(int)122, (byte)(int)235);
            pnlSettings.BackColor = Color.FromArgb(255, (byte)(int)69, (byte)(int)122, (byte)(int)235);
            pnlPurchaseHistory.BackColor = Color.FromArgb(255, (byte)(int)69, (byte)(int)122, (byte)(int)235);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            //set inventory as active
            ActivateBG(1);
        }

        private void btnDamageReport_Click(object sender, EventArgs e)
        {
            //set damage report as active
            ActivateBG(2);
        }

        private void btnBorrowedAsset_Click(object sender, EventArgs e)
        {
            //set borrowed asset as active
            ActivateBG(3);
        }

        private void btnRepairHistory_Click(object sender, EventArgs e)
        {
            //set repair history as active
            ActivateBG(4);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //set settings as active
            ActivateBG(5);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //set dashboard as active
            ActivateBG(0);
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            //set purchase history as active
            ActivateBG(6);
        }
    }
}
