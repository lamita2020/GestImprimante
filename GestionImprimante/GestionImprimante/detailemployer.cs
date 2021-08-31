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
namespace GestionImprimante
{
    public partial class detailemployer : Form
    {
        public detailemployer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from Employer where MATEmp ='" + MATEmpl.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MATEmp.Text = dr["MATEmp"].ToString();
                NomEmp.Text = dr["NomEmp"].ToString();
                IDimp.Text = dr["IDimp"].ToString();
                Iddep.Text = dr["iddep"].ToString();
                NBTCopieEmp.Text = dr["NBTCopieEmp"].ToString();
                CoutTEmp.Text = dr["CoutTEmp"].ToString();
                MATEmp.Visible = true;
                NomEmp.Visible = true;
                IDimp.Visible = true;
                Iddep.Visible = true;
                NBTCopieEmp.Visible = true;
                CoutTEmp.Visible = true;

            }
            Con.Close();
        }
        private void detailemployer_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("======detail departement======", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(200));
            e.Graphics.DrawString("ID departement: " + MATEmp.Text + "\tNom departement: " + NomEmp.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 110));
            e.Graphics.DrawString("ID imprimante: " + IDimp.Text + "\tCout departement: " + Iddep.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 150));
            e.Graphics.DrawString("NBT Copie Dep: " + NBTCopieEmp.Text + "\tNBT Emp Dep: " + CoutTEmp.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 190));
        }
    }
}
