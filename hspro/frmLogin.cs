using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hspro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new frmSplah());
        }



        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn;
                string connString;

                connString = "SERVER= 127.0.0.1; PORT=3307;DATABASE=alfaelixre;UID=root;password=ericspookyx2!;";

                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                MySqlCommand SelectCommand = new MySqlCommand("Select * from alfaelixre.admin where username='" + this.usernametxt.Text + "' + password='" + this.passwordtxt.Text + "';", conn);
                MySqlDataReader myReader;
                conn.Open();
                //show lable at bottom on user login.//on prompt window, show db connection as active
                myReader = SelectCommand.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (usernametxt.Text == "" || passwordtxt.Text == "")
                {
                    MessageBox.Show("Enter Credentials");
                }
                else if (count == 1 || count > 0)
                {
                    MessageBox.Show("Try Again");
                }

                else
                {


                    MessageBox.Show("Acess Granted, Welcome " + usernametxt.Text);
                    usernametxt.Clear();
                    passwordtxt.Clear();



                    //open up uniqueID form
                    dashboard dash = new dashboard();


                    dash.Show();
                    this.Hide();
                }
                
        }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
