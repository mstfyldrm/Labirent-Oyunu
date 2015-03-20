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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pb_menu_don_Click(object sender, EventArgs e)// Menüye Dönmek için Gereken Kod 
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)// Uygulamayı Kapatmak için Gereken Kod
        {
            DialogResult cevap = MessageBox.Show("Oyunu Kapatmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }


            if (cevap == DialogResult.No)
            {
                return;
            }
        }

    }
}
