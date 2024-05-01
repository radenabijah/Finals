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
using System.Xml.Linq;

namespace Finals
{
    public partial class ViewIncome : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public ViewIncome()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb");
            DisplayIncomes();

            IncomeDGV.CellClick += IncomeDGV_CellClick;
        }

        private void IncomeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                indexRow = e.RowIndex; // Update indexRow with the clicked row index

                // Get the selected row
                DataGridViewRow selectedRow = IncomeDGV.Rows[e.RowIndex];

                // Update text boxes with values from the selected row
                tbxName.Text = selectedRow.Cells["IncName"].Value.ToString();
                cbxCategory.Text = selectedRow.Cells["IncCat"].Value.ToString();
                tbxAmount.Text = selectedRow.Cells["IncAmt"].Value.ToString();
                tbxDescription.Text = selectedRow.Cells["IncDesc"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(selectedRow.Cells["IncDate"].Value);
            }
        }

        private void DisplayIncomes()
        {
            myConn.Open();
            string Query = "SELECT * FROM IncomeTbl";
            OleDbDataAdapter da = new OleDbDataAdapter(Query, myConn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            myConn.Close();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexRow >= 0)
                {
                    string query = "UPDATE IncomeTbl SET IncName = @Name, IncCat = @Category, IncAmt = @Amount, IncDesc = @Description, IncDate = @Date WHERE IncName = @OriginalName AND IncCat = @OriginalCategory AND IncAmt = @OriginalAmount AND IncDesc = @OriginalDescription AND IncDate = @OriginalDate";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@Name", tbxName.Text);
                        cmd.Parameters.AddWithValue("@Category", cbxCategory.Text);
                        cmd.Parameters.AddWithValue("@Amount", tbxAmount.Text);
                        cmd.Parameters.AddWithValue("@Description", tbxDescription.Text);
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value); // Use Value property for DateTimePicker
                        cmd.Parameters.AddWithValue("@OriginalName", IncomeDGV.Rows[indexRow].Cells["IncName"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalCategory", IncomeDGV.Rows[indexRow].Cells["IncCat"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalAmount", IncomeDGV.Rows[indexRow].Cells["IncAmt"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalDescription", IncomeDGV.Rows[indexRow].Cells["IncDesc"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalDate", IncomeDGV.Rows[indexRow].Cells["IncDate"].Value.ToString());

                        myConn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        myConn.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated Successfully");
                            btnLoad_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (IncomeDGV.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow selectedRow = IncomeDGV.CurrentRow;
                    string incName = selectedRow.Cells["IncName"].Value.ToString();
                    string amount = selectedRow.Cells["IncAmt"].Value.ToString();
                    string category = selectedRow.Cells["IncCat"].Value.ToString();
                    string date = selectedRow.Cells["IncDate"].Value.ToString();
                    string description = selectedRow.Cells["IncDesc"].Value.ToString();
                    string user = selectedRow.Cells["IncUser"].Value.ToString();

                    string query = "DELETE FROM IncomeTbl WHERE IncName = @IncName AND IncAmt = @IncAmt AND IncCat = @IncCat AND IncDate = @IncDate AND IncDesc = @IncDesc AND IncUser = @IncUser";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@IncName", incName);
                        cmd.Parameters.AddWithValue("@IncAmt", amount);
                        cmd.Parameters.AddWithValue("@IncCat", category);
                        cmd.Parameters.AddWithValue("@IncDate", date);
                        cmd.Parameters.AddWithValue("@IncDesc", description);
                        cmd.Parameters.AddWithValue("@IncUser", user);

                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully");
                        btnLoad_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
                finally
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb");
            da = new OleDbDataAdapter("SELECT * FROM IncomeTbl", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "IncomeTbl");
            IncomeDGV.DataSource = ds.Tables["IncomeTbl"];
            myConn.Close();



        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
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

        private void label4_Click_1(object sender, EventArgs e)
        {
            Expense Obj = new Expense();
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

        private void label7_Click_1(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
