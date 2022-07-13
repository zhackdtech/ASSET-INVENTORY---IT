using IT_Asset_Inventory.DatabaseManager;
using IT_Asset_Inventory.DialogBoxes;
using IT_Asset_Inventory.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IT_Asset_Inventory
{
    public partial class Form1 : Form
    {
        private string connectionString = "datasource=10.10.1.100;database=itusers;port=3306;username=itstaff;password=contactit123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        NoNetwork nonet = new NoNetwork();
        readonly ZHCrypto.Sec security = new ZHCrypto.Sec();
        String d_username, d_password;
        Mainform main = new Mainform();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(ConnectionInfo.CheckNetwork())
            {
                d_username = security.Encrypt(txtUsername.Texts);
                d_password = security.Encrypt(txtPassword.Texts);
                //we found the server!
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                { 
                    conn.Open();
                    Console.WriteLine(conn.State.ToString());
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT `users`.`id`,`users`.`username`,`users`.`password`,`users`.`email`,`users`.`name`,`users`.`surname`,`users`.`position` FROM `itusers`.`users` where `users`.`username` = '"+d_username+"'  && `users`.`password`='"+d_password+"';", conn);
                        
                        
                        MySqlDataReader reader = cmd.ExecuteReader();
                        Console.WriteLine(reader.ToString());
                        if (reader.Read())
                        {
                            //logged in!
                            //pass the username and password in the next form
                            Credentials.db_user = security.Encrypt(txtUsername.Texts);
                            Credentials.db_password = security.Encrypt(txtPassword.Texts);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            //wrong username or password
                            //display an error
                        }
                    }
                    else
                    {
                        MessageBox.Show("cannot open connection, contact your administrator");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                //cannot connect :(
                nonet.ShowDialog();
            }
        }
    }
}
