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

namespace Finals
{
    public partial class Income : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;


        public Income()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Clear()
        {
            IncNameTb.Text = "";
            IncAmtTb.Text = "";
            IncDescTb.Text = "";
            CatCb.SelectedIndex = 0;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IncNameTb.Text) || string.IsNullOrEmpty(IncAmtTb.Text) || string.IsNullOrEmpty(IncDescTb.Text) || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (IncDate.Value != null)
                    {
                        using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb"))
                        {
                            myConn.Open();
                            string query = "INSERT INTO IncomeTbl (IncName, IncAmt, IncCat, IncDate, IncDesc, IncUser) VALUES (@IN, @IA, @IC, @ID, @IDe, @IU)";
                            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                            {
                                cmd.Parameters.AddWithValue("@IN", IncNameTb.Text);

                                // Convert IncAmtTb.Text to a decimal value
                                if (decimal.TryParse(IncAmtTb.Text, out decimal amount))
                                    cmd.Parameters.AddWithValue("@IA", amount);
                                else
                                    throw new Exception("Invalid amount format");

                                cmd.Parameters.AddWithValue("@IC", CatCb.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@ID", IncDate.Value.Date);
                                cmd.Parameters.AddWithValue("@IDe", IncDescTb.Text);
                                cmd.Parameters.AddWithValue("@IU", Login.User);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Income added successfully");

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



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expense Obj = new Expense();
            Obj.Show();
            this.Hide();
        }



        private void label4_Click_1(object sender, EventArgs e)
        {
            Expense Obj = new Expense();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
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

        private void IncNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
