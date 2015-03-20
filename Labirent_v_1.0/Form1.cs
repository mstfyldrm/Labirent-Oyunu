using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labirent_v_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pb_Nasil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm7 = new Form7();
            frm7.Show();


        }

        private void pb_Hakkinda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void pb_Basla_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void pb_Cikis_Click(object sender, EventArgs e)
        {

            DialogResult cevap = MessageBox.Show("Programı Kapatmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (cevap == DialogResult.Yes)
            {


                Application.Exit();


            }


            if (cevap == DialogResult.No)
            {


                return;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






    }
}
