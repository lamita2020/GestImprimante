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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            detaildepartement ddep = new detaildepartement();
            ddep.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            detailemployer demp = new detailemployer();
            demp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            detaildepartement ddep = new detaildepartement();
            ddep.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            detailemployer demp = new detailemployer();
            demp.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            detailimprimante dimp = new detailimprimante();
            dimp.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            detailimprimante dimp = new detailimprimante();
            dimp.Show();
            this.Hide();
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            detailcopie dcop = new detailcopie();
            dcop.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            detailcopie dcop = new detailcopie();
            dcop.Show();
            this.Hide();
        }
    }
}
