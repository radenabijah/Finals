using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Expense : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Expense()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExpNameTb.Text) || string.IsNullOrEmpty(ExpAmtTb.Text) || string.IsNullOrEmpty(ExpDescTb.Text) || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (ExpDate.Value != null)
                    {
                        using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb"))
                        {
                            myConn.Open();
                            string query = "INSERT INTO ExpenseTbl (ExpName, ExpAmt, ExpCat, ExpDate, ExpDesc, ExpUser) VALUES (@EN, @EA, @EC, @ED, @EDe, @EU)";
                            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                            {
                                cmd.Parameters.AddWithValue("@EN", ExpNameTb.Text);

                                // Convert IncAmtTb.Text to a decimal value
                                if (decimal.TryParse(ExpAmtTb.Text, out decimal amount))
                                    cmd.Parameters.AddWithValue("@IA", amount);
                                else
                                    throw new Exception("Invalid amount format");

                                cmd.Parameters.AddWithValue("@EC", CatCb.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@ED", ExpDate.Value.Date);
                                cmd.Parameters.AddWithValue("@EDe", ExpDescTb.Text);
                                cmd.Parameters.AddWithValue("@EU", Login.User);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Expense added successfully");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid Date.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void label2_Click_1(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void Inclbl_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            ViewExpense Obj = new ViewExpense();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Chat Obj = new Chat();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
