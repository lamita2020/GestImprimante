using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionImprimante
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employer emp = new Employer();
            emp.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Details det = new Details();
            det.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            departement dep = new departement();
            dep.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            departement dep = new departement();
            dep.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employer emp= new Employer();
            emp.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Details det = new Details();
            det.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Imprimante imp = new Imprimante();
            imp.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Imprimante imp = new Imprimante();
            imp.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Copie cop = new Copie();
            cop.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Copie cop = new Copie();
            cop.Show();
            this.Hide();
        }
    }
}
