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
    public partial class departement : Form
    {
        public departement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(IDDep.Text == "" || NomDep.Text == "" || NBTEmpDep.Text == "" || NBTCopieDep.Text == "" || CoutDep.Text == "" || idimp.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into departement values ('"+ IDDep.Text +"','" + NomDep.Text + "','"+NBTEmpDep.Text+"','"+NBTCopieDep.Text+"','"+CoutDep.Text+ "','" + idimp.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("departement successfully added");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
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
            string query = "select * from departement ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DepDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void departement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(IDDep.Text == "" )
            {
                MessageBox.Show("enter the departement id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from departement where IDDep ='" + IDDep.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Departement deleted successfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DepDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (IDDep.Text == "" || NomDep.Text == "" || NBTEmpDep.Text == "" || NBTCopieDep.Text == "" || CoutDep.Text == "" || idimp.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update departement set NomDep ='" + NomDep.Text + "',NBTEmpDep ='" + NBTEmpDep.Text + "',NBTCopieDep ='" + NBTCopieDep.Text + "',CoutDep ='" + CoutDep.Text + "',idimp ='" + idimp.Text + "'where IDDep='" + IDDep.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("employer update successfully");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NBTCopieDep_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CoutDep_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DepDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IDDep.Text = DepDGV.SelectedRows[0].Cells[0].Value.ToString();
            NomDep.Text = DepDGV.SelectedRows[0].Cells[1].Value.ToString();
            NBTEmpDep.Text = DepDGV.SelectedRows[0].Cells[2].Value.ToString();
            NBTCopieDep.Text = DepDGV.SelectedRows[0].Cells[3].Value.ToString();
            CoutDep.Text = DepDGV.SelectedRows[0].Cells[4].Value.ToString();
            idimp.Text = DepDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
