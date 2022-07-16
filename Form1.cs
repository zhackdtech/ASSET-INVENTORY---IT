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
        /// <summary>
        /// fields
        /// </summary>
        NoNetwork nonet = new NoNetwork();
        //custom encryption and decryption C# module 
        readonly ZHCrypto.Sec security = new ZHCrypto.Sec();
        //for the username and password
        String d_username, d_password;
        //the main form
        Mainform main = new Mainform();


        /// <summary>
        /// connection string
        /// </summary>
        /// datasource is the server
        /// database is the schema
        /// port is the port of the mysql service in the machine
        /// username is the username in mysql
        /// password is the password
        /// 

        //allow user to edit a config file for this connectionstring
        private string connectionString = "datasource=10.10.1.100;database=itusers;port=3306;username=itstaff;password=contactit123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //minimize the window
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //check if connected to the server
            //by pinging the database server
            if(ConnectionInfo.CheckNetwork())
            {
                //encrypt the password before comparing to the stored data
                //in the database
                d_username = security.Encrypt(txtUsername.Texts);
                d_password = security.Encrypt(txtPassword.Texts);
                //we found the server!
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                { 
                    //open the connection
                    conn.Open();
                    //for debugging purposes
                    Console.WriteLine(conn.State.ToString());
                    //check if the connection is open
                    if (conn.State == ConnectionState.Open)
                    {
                        //the query
                        MySqlCommand cmd = new MySqlCommand("SELECT `users`.`id`,`users`.`username`,`users`.`password`,`users`.`email`,`users`.`name`,`users`.`surname`,`users`.`position` FROM `itusers`.`users` where `users`.`username` = '"+d_username+"'  && `users`.`password`='"+d_password+"';", conn);
                        
                        //read the result of the query
                        MySqlDataReader reader = cmd.ExecuteReader();
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
                        nonet.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    //show exception
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                //cannot connect :(
                //show no network diaglog 
                nonet.ShowDialog();
            }
        }
    }
}
