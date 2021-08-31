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
    public partial class detailcopie : Form
    {
        public detailcopie()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchcopdata()
        {
            Con.Open();
            string query = "select * from Copie where IDCop ='" + IDCop1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                IDCop.Text = dr["IDCop"].ToString();
                NomCop.Text = dr["NomCop"].ToString();
                Iddep.Text = dr["Iddep"].ToString();
                Idimp.Text = dr["Idimp"].ToString();
                MAtemp.Text = dr["MAtemp"].ToString();
                NBTCop.Text = dr["NBTCop"].ToString();
                TypeCop.Text = dr["TypeCop"].ToString();
               
                
                IDCop.Visible = true;
                NomCop.Visible = true;
                Iddep.Visible = true;
                Idimp.Visible = true;
                MAtemp.Visible = true;
                NBTCop.Visible = true;
                TypeCop.Visible = true;
                CoutCop.Visible = true;
            }
        
            Con.Close();
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

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            fetchcopdata();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("======detail copie======", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(200));
            e.Graphics.DrawString("ID copie: " + IDCop.Text + "\tNom copie: " + NomCop.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 110));
            e.Graphics.DrawString("ID imprimante: " + Idimp.Text + "\tMatricule employer: " + MAtemp.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 150));
            e.Graphics.DrawString("ID departement: " + Iddep.Text + "\tNBT Copie: " + NBTCop.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 190));
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void detailcopie_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            CoutDate CDT = new CoutDate();
            CDT.Show();
            this.Hide();
        }
    }
}
