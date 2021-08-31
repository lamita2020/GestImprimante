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
    public partial class detailimprimante : Form
    {
        public detailimprimante()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchimpdata()
        {
            Con.Open();
            string query = "select * from Imprimante where IDImp ='" +  IDImpl.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                IDImp.Text = dr["IDImp"].ToString();
                NomImp.Text = dr["NomImp"].ToString();
                IDdep.Text = dr["IDdep"].ToString();
                CoutTImp.Text = dr["CoutTImp"].ToString();
                NBTCopImp.Text = dr["NBTCopieImp"].ToString();  
                IDImp.Visible = true;
                NomImp.Visible = true;
                IDdep.Visible = true;
                CoutTImp.Visible = true;
                NBTCopImp.Visible = true;

            }
            Con.Close();
        }
        private void detailimprimante_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            fetchimpdata();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("======detail imprimante======", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(200));
            e.Graphics.DrawString("ID imprimante: " + IDImp.Text + "\tNom imprimante: " + NomImp.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 110));
            e.Graphics.DrawString("ID Departement: " + IDdep.Text + "\tCout Total Imp: " + CoutTImp.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 150));
            e.Graphics.DrawString(" NBT Copie Imp: " + NBTCopImp.Text , new Font("Century Gothic", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(10, 190));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    
    }
}
