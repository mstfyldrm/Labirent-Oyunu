using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Labirent_v_1._0
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int sn = 81;

        int[,] tablo = {    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},   
                            {0,1,0,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,0},  
                            {0,1,0,0,0,0,3,1,0,0,0,0,1,1,1,1,0,0,0,0},
                            {0,1,1,1,1,0,0,0,0,1,1,0,1,0,0,0,0,1,1,0},
                            {0,1,0,0,1,0,1,1,1,1,1,0,1,0,1,1,1,1,1,0},
                            {0,1,1,0,1,0,1,0,1,0,0,0,1,0,1,0,0,0,1,0},
                            {0,1,0,0,1,0,0,0,1,0,4,1,1,0,0,0,1,0,1,0},
                            {0,1,0,1,1,1,1,0,1,0,0,0,1,1,1,1,2,0,1,0},
                            {0,1,0,5,0,1,0,0,1,1,1,0,1,1,1,1,0,0,1,0},
                            {0,1,0,0,0,0,1,1,1,0,0,0,1,0,0,0,0,1,1,0},
                            {0,1,1,1,1,1,1,0,1,0,6,1,1,1,1,1,0,0,1,0},
                            {0,1,0,0,0,0,1,0,1,0,0,0,0,1,0,1,1,0,1,0},
                            {0,1,0,1,1,0,1,0,0,0,1,1,1,1,0,0,0,0,1,0},
                            {0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,8,1,0},
                            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},


                       };

        int xIndis = 5, yIndis = 6;  

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Up && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.yukari;
                pbGolgem.Top -= 40;
                pbOyuncu.Top -= 40;
            }
            else if (e.KeyCode == Keys.Left && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.sol;
                pbGolgem.Left -= 40;
                pbOyuncu.Left -= 40;
            }
            else if (e.KeyCode == Keys.Down && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.asagi;
                pbGolgem.Top += 40;
                pbOyuncu.Top += 40;
            }
            else if (e.KeyCode == Keys.Right && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.sag;
                pbGolgem.Left += 40;
                pbOyuncu.Left += 40;
            }


            if (tablo[xIndis, yIndis] == 7)
            {

                MessageBox.Show("Tebrikler Bu Bölümü Geçtiniz Level 4 Başlıyor");
                this.Close();
                Form5 frm5 = new Form5();
                frm5.Show();




            }
            if (tablo[xIndis, yIndis] == 2)
            {

                Form11 frm11 = new Form11();
                frm11.Show();
                tablo[xIndis, yIndis] = 1;
            }

            if (tablo[xIndis, yIndis] == 3)
            {
                sn += 10;
                tablo[xIndis, yIndis] = 1;

            }

            if (tablo[xIndis, yIndis] == 8)
            {
                sn += 10;
                tablo[xIndis, yIndis] = 1;

            }

            if (tablo[xIndis, yIndis] == 4)
            {
                sn += 10;
                tablo[xIndis, yIndis] = 1;

            }

            if (tablo[xIndis, yIndis] == 6)
            {
                this.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.level_3_acik3;
                if (tablo[1, 19] == 0)
                {
                    tablo[1, 19] = 7;

                }
            }


        }



        private bool GidebilirMi(Keys keys)
        {
            bool gidis = false;
            switch (keys)
            {
                case Keys.Up:
                    if (xIndis - 1 >= 0 && tablo[xIndis - 1, yIndis] > 0)
                    {
                        gidis = true; 
                        xIndis--;  
                    }
                    break;
                case Keys.Down:
                    if (xIndis + 1 <= 19 && tablo[xIndis + 1, yIndis] > 0)
                    {
                        gidis = true;
                        xIndis++;
                    }
                    break;
                case Keys.Left:
                    if (yIndis - 1 >= 0 && tablo[xIndis, yIndis - 1] > 0)
                    {
                        gidis = true;
                        yIndis--;
                    }
                    break;
                case Keys.Right:
                    if (yIndis + 1 <= 19 && tablo[xIndis, yIndis + 1] > 0)
                    {
                        gidis = true;
                        yIndis++;
                    }
                    break;
                default:
                    break;
            }

            return gidis;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                sn--;
            }
            lbl_sure.Text = sn.ToString();
            if (sn == 0)
            {

                MessageBox.Show("Süreniz Bitti Üzgünüm..");
                this.Close();
                Form1 frm1 = new Form1();
                frm1.Show();
                sn = 0;

            }
        }

        private void Form4_Deactivate(object sender, EventArgs e)
        {
            timer1.Stop();
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath + "";
            player.SoundLocation = path;
            player.Stop();
        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath + "//saniyem.wav";
            player.SoundLocation = path;
            player.PlayLooping();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
