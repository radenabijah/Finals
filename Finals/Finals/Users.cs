using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace Finals
{
    public partial class Users : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Users()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || PasswordTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (DOB != null && DOB.Value != null)
                    {
                        myConn.Open();
                        string query = "INSERT INTO UserTbl (UName, UPass, UDoB, UPhone, UAddress) VALUES (@UN, @UPA, @UD, @UP, @UA)";
                        using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                        {
                            cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                            cmd.Parameters.AddWithValue("@UPA", PasswordTb.Text);
                            cmd.Parameters.AddWithValue("@UD", DOB.Value.Date);
                            cmd.Parameters.AddWithValue("@UP", PhoneTb.Text);
                            cmd.Parameters.AddWithValue("@UA", AddressTb.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User Added Successfully");
                            this.Close();
                            Login Obj = new Login();
                            Obj.Show();
                            this.Hide();
                        } // This closes the using block and disposes the command object
                        myConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid Date of Birth.");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
