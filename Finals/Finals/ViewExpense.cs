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
    public partial class ViewExpense : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public ViewExpense()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb");
            DisplayExpenses();
            ExpenseDGV.CellClick += ExpenseDGV_CellClick;
        }
        private void ExpenseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                indexRow = e.RowIndex; // Update indexRow with the clicked row index

                // Get the selected row
                DataGridViewRow selectedRow = ExpenseDGV.Rows[e.RowIndex];

                // Update text boxes with values from the selected row
                tbxName.Text = selectedRow.Cells["ExpName"].Value.ToString();
                cbxCategory.Text = selectedRow.Cells["ExpCat"].Value.ToString();
                tbxAmount.Text = selectedRow.Cells["ExpAmt"].Value.ToString();
                tbxDescription.Text = selectedRow.Cells["ExpDesc"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(selectedRow.Cells["ExpDate"].Value);
            }
        }
        private void DisplayExpenses()
        {
            myConn.Open();
            string Query = "SELECT * FROM ExpenseTbl";
            OleDbDataAdapter da = new OleDbDataAdapter(Query, myConn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            myConn.Close();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb");
            da = new OleDbDataAdapter("SELECT * FROM ExpenseTbl", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "ExpenseTbl");
            ExpenseDGV.DataSource = ds.Tables["ExpenseTbl"];
            myConn.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexRow >= 0)
                {
                    string query = "UPDATE ExpenseTbl SET ExpName = @Name, ExpCat = @Category, ExpAmt = @Amount, ExpDesc = @Description, ExpDate = @Date WHERE ExpName = @OriginalName AND ExpCat = @OriginalCategory AND ExpAmt = @OriginalAmount AND ExpDesc = @OriginalDescription AND ExpDate = @OriginalDate";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@Name", tbxName.Text);
                        cmd.Parameters.AddWithValue("@Category", cbxCategory.Text);
                        cmd.Parameters.AddWithValue("@Amount", tbxAmount.Text);
                        cmd.Parameters.AddWithValue("@Description", tbxDescription.Text);
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                        cmd.Parameters.AddWithValue("@OriginalName", ExpenseDGV.Rows[indexRow].Cells["ExpName"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalCategory", ExpenseDGV.Rows[indexRow].Cells["ExpCat"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalAmount", ExpenseDGV.Rows[indexRow].Cells["ExpAmt"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalDescription", ExpenseDGV.Rows[indexRow].Cells["ExpDesc"].Value.ToString());
                        cmd.Parameters.AddWithValue("@OriginalDate", ExpenseDGV.Rows[indexRow].Cells["ExpDate"].Value.ToString());

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
            if (ExpenseDGV.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow selectedRow = ExpenseDGV.CurrentRow;
                    string expName = selectedRow.Cells["ExpName"].Value.ToString();
                    string amount = selectedRow.Cells["ExpAmt"].Value.ToString();
                    string category = selectedRow.Cells["ExpCat"].Value.ToString();
                    string date = selectedRow.Cells["ExpDate"].Value.ToString();
                    string description = selectedRow.Cells["ExpDesc"].Value.ToString();
                    string user = selectedRow.Cells["ExpUser"].Value.ToString();

                    string query = "DELETE FROM ExpenseTbl WHERE ExpName = @ExpName AND ExpAmt = @ExpAmt AND ExpCat = @ExpCat AND ExpDate = @ExpDate AND ExpDesc = @ExpDesc AND ExpUser = @ExpUser";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@ExpName", expName);
                        cmd.Parameters.AddWithValue("@ExpAmt", amount);
                        cmd.Parameters.AddWithValue("@ExpCat", category);
                        cmd.Parameters.AddWithValue("@ExpDate", date);
                        cmd.Parameters.AddWithValue("@ExpDesc", description);
                        cmd.Parameters.AddWithValue("@ExpUser", user);

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

        private void label6_Click_1(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
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
