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
    public partial class Imprimante : Form
    {
        public Imprimante()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(IDImp.Text == "" || NomImp.Text == "" || NBTCopImp.Text == "" || CoutTImp.Text == "" || IDdep.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Imprimante values('"+IDImp.Text+"','"+NomImp.Text+"','"+NBTCopImp.Text+"','"+CoutTImp.Text+"','"+IDdep.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imprimante Successfully Added");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from Imprimante";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ImpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Imprimante_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ImpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDImp.Text = ImpDGV.SelectedRows[0].Cells[0].Value.ToString();
            NomImp.Text = ImpDGV.SelectedRows[0].Cells[1].Value.ToString();
            NBTCopImp.Text = ImpDGV.SelectedRows[0].Cells[2].Value.ToString();
            CoutTImp.Text = ImpDGV.SelectedRows[0].Cells[3].Value.ToString();
            IDdep.Text = ImpDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(IDImp.Text == "")
            {
                MessageBox.Show("Enter The Imprimante Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Imprimante where IDImp='" + IDImp.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imprimante deleted successfully ");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (IDImp.Text == "" || NomImp.Text == "" || NBTCopImp.Text == "" || CoutTImp.Text == "" || IDdep.Text == "")
            {
                MessageBox.Show("Missing Information ");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Imprimante set NomImp = '" + NomImp.Text + "',NBTCopieImp='" + NBTCopImp.Text + "',CoutTImp='" + CoutTImp.Text + "',IDdep='" + IDdep.Text + "'where IDImp='"+IDImp.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imprimante Updated successfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NomImp_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
