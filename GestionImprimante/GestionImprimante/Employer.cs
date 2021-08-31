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
    public partial class Employer : Form
    {
        public Employer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MATEmp.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            NomEmp.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            NBTCopieEmp.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            CoutTEmp.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            IDimp.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
            Iddep.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (MATEmp.Text == "" || NomEmp.Text == "" || NBTCopieEmp.Text == "" || CoutTEmp.Text == "" || IDimp.Text == "" || Iddep.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Employer values('" + MATEmp.Text + "','" + NomEmp.Text + "','" + NBTCopieEmp.Text + "','" + CoutTEmp.Text + "','" + IDimp.Text + "','" + Iddep.Text +"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employer Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
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
            string query = "select * from Employer";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (MATEmp.Text == "")
            {
                MessageBox.Show("Enter The Employer Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Employer where IDEmp ='" + MATEmp.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employer deleted successfully ");
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
            if (MATEmp.Text == "" || NomEmp.Text == "" || NBTCopieEmp.Text == "" || CoutTEmp.Text == "" || Iddep.Text == "" || IDimp.Text == "")
            {
                MessageBox.Show("Missing Information ");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Employer set NomEmp='" + NomEmp.Text + "',NBTCopieEmp='" + NBTCopieEmp.Text + "',CoutTEmp='" + CoutTEmp.Text + "',Iddep='" + Iddep.Text + "',IDimp='" + IDimp.Text + "' where MATEmp='" + MATEmp.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employer Updated successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Employer_Load(object sender, EventArgs e)
        {
            populate(); 
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
