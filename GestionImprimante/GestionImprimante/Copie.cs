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
    public partial class Copie : Form
    {
        public Copie()
        {
            InitializeComponent();
        }
SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GestionImprimante.mdf;Integrated Security=True;Connect Timeout=30");
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            Con.Open();
            string query = "select * from Copie";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CopDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Copie_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (IDCop.Text == "" || NomCop.Text == "" || TypeCop.SelectedItem.ToString() == "" ||  NBTCop.Text == "" || Iddep.Text == "" || Idimp.Text == "" || MAtemp.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Copie values('" + IDCop.Text + "','" + NomCop.Text + "','" + TypeCop.SelectedItem.ToString() + "','" + NBTCop.Text + "','" + Iddep.Text + "','" + Idimp.Text + "','" + MAtemp.Text + "','" + DateCop.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Copie Successfully Added");
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
            if (IDCop.Text == "" || NomCop.Text == "" || NBTCop.Text == "" || Iddep.Text == "" || Idimp.Text == "" || MAtemp.Text == "")
            {
                MessageBox.Show("Missing Information ");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Copie set NomCop = '" + NomCop.Text + "',TypeCop='" + TypeCop.SelectedItem.ToString() + "',NBTCop='" + NBTCop.Text + "',Iddep='" + Iddep.Text + "',Idimp='" + Idimp.Text + "',Matemp='" + MAtemp.Text + "',DateCop='" + DateCop.Value.Date + "'where IDCop='" + IDCop.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Copie Updated successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (IDCop.Text == "")
            {
                MessageBox.Show("Enter The Copie Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Copie where IDCop='" + IDCop.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Copie deleted successfully ");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
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

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCop.Text = CopDGV.SelectedRows[0].Cells[0].Value.ToString();
            NomCop.Text = CopDGV.SelectedRows[0].Cells[1].Value.ToString();
            TypeCop.SelectedItem = CopDGV.SelectedRows[0].Cells[2].Value.ToString();
            NBTCop.Text = CopDGV.SelectedRows[0].Cells[3].Value.ToString();
            Iddep.Text = CopDGV.SelectedRows[0].Cells[4].Value.ToString();
            Idimp.Text = CopDGV.SelectedRows[0].Cells[5].Value.ToString();
            MAtemp.Text = CopDGV.SelectedRows[0].Cells[6].Value.ToString();


        }

        private void TypeCop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int n = 0, GrdTotal=0;
        private void CoutTCop_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
