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
    public partial class detaildepartement : Form
    {
        public detaildepartement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchdepdata()
        {
            Con.Open();
            string query = "select * from departement where IDDep ='" + IDDepl.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                IDDep.Text = dr["IDDep"].ToString();
                NomDep.Text = dr["NomDep"].ToString();
                idimp.Text = dr["idimp"].ToString();
                CoutDep.Text = dr["CoutDep"].ToString();
                NBTCopieDep.Text = dr["NBTCopieDep"].ToString();
                NBTEmpDep.Text = dr["NBTEmpDep"].ToString();
                IDDep.Visible = true;
                NomDep.Visible = true;
                idimp.Visible = true;
                CoutDep.Visible = true;
                NBTCopieDep.Visible = true;
                NBTEmpDep.Visible = true;

            }
            Con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NBTEmpDep_Click(object sender, EventArgs e)
        {

        }

        private void Viewdepartement_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            fetchdepdata();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("======detail departement======", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(200));
            e.Graphics.DrawString("ID departement: " + IDDep.Text +"\tNom departement: "+ NomDep.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10,110));
            e.Graphics.DrawString("ID imprimante: " + idimp.Text +"\tCout departement: "+ CoutDep.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10,150));
            e.Graphics.DrawString("NBT Copie Dep: " + NBTCopieDep.Text + "\tNBT Emp Dep: " + NBTEmpDep.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 190));
        }

        private void IDDepl_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
