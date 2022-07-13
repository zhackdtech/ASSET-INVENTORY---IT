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
            fc.Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
