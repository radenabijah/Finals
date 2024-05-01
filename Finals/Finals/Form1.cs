using System.Data;
using System.Data.OleDb;

namespace Finals
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Form1()
        {
            InitializeComponent();
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= D:\\Skwela pa nga\\CPE262\\FProfDB.accdb");
            GetTotInc();
            GetTotExp();
            GetNumExp();
            GetNumInc();
            GetIncLDate();
            GetExpLDate();
            GetMaxInc();
            GetMaxExp();
            GetMinInc();
            GetMinExp();
            GetBalance();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Inclbl_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expense Obj = new Expense();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewExpense Obj = new ViewExpense();
            Obj.Show();
            this.Hide();
        }
        int Inc, Exp;
        private void GetTotInc()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Sum(IncAmt) from IncomeTbl where IncUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Inc = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotIncLbl.Text = "₱ " + dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetTotExp()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Exp = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotExpLbl.Text = "₱ " + dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetBalance()
        {
            double Bal = Inc - Exp;
            BalanceLbl.Text = "₱ " + Bal;
        }
        private void GetNumExp()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                NumExpLbl.Text = dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetNumInc()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Count(*) from IncomeTbl where IncUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                NumIncLbl.Text = dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetIncLDate()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Max(IncDate) from IncomeTbl where IncUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DateIncLbl.Text = dt.Rows[0][0].ToString();
                DateIncLbl1.Text = dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetMaxInc()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Max(IncAmt) from IncomeTbl where IncUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MaxIncLbl.Text = "₱ " + dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetMinInc()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Min(IncAmt) from IncomeTbl where IncUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MinIncLbl.Text = "₱ " + dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetExpLDate()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Max(ExpDate) from ExpenseTbl where ExpUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DateExpLbl.Text = dt.Rows[0][0].ToString();
                DateExpLbl1.Text = dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetMaxExp()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Max(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MaxExpLbl.Text = "₱ " + dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void GetMinExp()
        {
            try
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MinExpLbl.Text = "₱ " + dt.Rows[0][0].ToString();
                myConn.Close();
            }
            catch (Exception Ex)
            {
                myConn.Close();
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Chat Obj = new Chat();
            Obj.Show();
            this.Hide();
        }

        private void MinIncLbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}