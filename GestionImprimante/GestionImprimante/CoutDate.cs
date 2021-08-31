using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace GestionImprimante
{
    public partial class CoutDate : Form
    {
        public CoutDate()
        {
            InitializeComponent();
        }

        private void MATEmp_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CoutDate_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Date2_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(Date1.Text);
            DateTime todate = Convert.ToDateTime(Date2.Text);
            if(fromdate <= todate)
            {
                TimeSpan ts = todate.Subtract(fromdate);
                int days = Convert.ToInt16(ts.Days);
                label3.Text = "The Difference Between Days from and to are : " + days;
                label3.Font = new Font("arial", 10);
                label3.ForeColor = System.Drawing.Color.Green;

                string mainconn = ConfigurationManager.ConnectionStrings["GestionImprimante.Properties.Settings.GestionImprimanteConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select * from [dbo].[Copie] where DateCop between '" + Date1.Text + "'and'" + Date2.Text + "'";
                SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
                sqlconn.Open();
                DataTable dt = new DataTable();
                dt.Load(sqlcomm.ExecuteReader());
                CDDGV.DataSource = dt;
                sqlconn.Close();
            }
            else
            {
                label3.Text = "From Date Must Be Lesser Than To Date " ;
                label3.Font = new Font("arial", 10);
                label3.ForeColor = System.Drawing.Color.Red;
            }
          
        }

        private void ImpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
    }
}
