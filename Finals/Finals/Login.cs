using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Login : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Login()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source= C:\\Users\\Predator\\Downloads\\FinalsDB.mdb");
            PasswordTb.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
        }
        public static string User;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else
            {
                myConn.Open();
                da = new OleDbDataAdapter("SELECT COUNT(*) FROM UserTbl WHERE UName = @UName AND UPass = @UPass", myConn);
                da.SelectCommand.Parameters.AddWithValue("@UName", UnameTb.Text);
                da.SelectCommand.Parameters.AddWithValue("@UPass", PasswordTb.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = UnameTb.Text;
                    Form1 Obj = new Form1();
                    Obj.Show();
                    this.Hide();
                    myConn.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
                myConn.Close();
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
