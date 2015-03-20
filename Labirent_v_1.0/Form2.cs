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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // (Leveller için Açıklama Tek form 2de yapılmıştır....)

        int sn = 71;  //Oyun Süresi için değişken ataması yapılıyor Belirleniyor....

        int[,] tablo = {    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},   //Hareket Edicek Oyuncunun Hareketini Kısıtlamak 
                            {0,1,1,1,1,1,1,1,1,1,1,0,6,1,1,1,1,1,1,0},   //İçin Atanan Dizi Değişkenleri
                            {0,1,3,0,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0},
                            {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                            {0,1,1,1,1,0,1,1,0,0,0,0,1,0,0,0,0,0,1,0},
                            {0,1,0,1,1,0,0,0,0,1,1,0,1,0,1,1,1,0,1,0},
                            {0,1,0,0,0,0,1,1,1,1,2,0,1,0,0,0,1,0,1,0},
                            {0,1,0,1,1,1,1,1,0,0,0,0,1,1,1,0,1,0,1,0},
                            {0,1,0,1,1,0,1,1,0,1,1,1,1,1,1,0,1,0,0,0},
                            {0,1,0,0,0,0,1,1,0,1,1,1,1,1,4,0,1,0,1,0},
                            {0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,1,1,1,0},
                            {0,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0},
                            {0,1,0,1,0,0,0,1,1,1,1,0,0,0,0,1,1,0,1,0},
                            {0,1,1,1,1,1,0,1,1,1,1,1,1,1,0,1,1,0,1,0},
                            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},


                       };

        int xIndis = 13, yIndis = 5;  //pbOyuncu'nun  Konumunu Belirtiyor..... 

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Up && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.yukari; // Oyuncunun gideceği konuma göre pb_oyuncu arkaplanı değişiyor.
                pbGolgem.Top -= 40;// pbGolge 1 dizi değerinde yukarı  çıkıyor
                pbOyuncu.Top -= 40;// pbOyuncu 1 dizi değerinde yukarı  çıkıyor
            }
            else if (e.KeyCode == Keys.Left && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.sol;
                pbGolgem.Left -= 40;// pbGolge 1 dizi değerinde sola  gidiyor
                pbOyuncu.Left -= 40;// pbOyuncu 1 dizi değerinde sola  gidiyor
            }
            else if (e.KeyCode == Keys.Down && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.asagi;
                pbGolgem.Top += 40;// pbGolge 1 dizi değerinde aşagı iniyor
                pbOyuncu.Top += 40;// pbOyuncu 1 dizi değerinde aşagı iniyor
            }
            else if (e.KeyCode == Keys.Right && GidebilirMi(e.KeyCode))
            {
                pbOyuncu.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.sag;
                pbGolgem.Left += 40;// pbGolge 1 dizi değerinde sağa gidiyor
                pbOyuncu.Left += 40;// pbGolge 1 dizi değerinde sağa gidiyor
            }


            if (tablo[xIndis, yIndis] == 7) //pbOyuncunun xindis ve yindis değeri 7 eşit olunca level atlanıyor.
            {
                MessageBox.Show("Tebrikler Bu Bölümü Geçtiniz Level 2 Başlıyor");
                this.Close();            // form2 kapanması için gereken kod.
                Form3 frm3 = new Form3();// değer eşitlenince form3 geçiş yapması için gereken kod.
                frm3.Show();

            }
            if (tablo[xIndis, yIndis] == 2) //pbOyuncunun xindis ve yindis değeri 2 eşit olunca Harita açılıyor.
            {

                Form9 frm9 = new Form9();
                frm9.Show();
                tablo[xIndis, yIndis] = 1; // Harıta Jokerı Bıdaha Kullanılmaması için indisleri geçiş indisi olan 1 eşitlenmesini sağlamakta

            }

            if (tablo[xIndis, yIndis] == 3) // Süre Jokeri İndisler 3 eşit oldugunda sn değişkenini 10 saniye arttırıp indisleri 1 eşitliyor.
            {
                sn += 10;
                tablo[xIndis, yIndis] = 1;

            }

            if (tablo[xIndis, yIndis] == 4)// Süre Jokeri İndisler 4 eşit oldugunda sn değişkenini 10 saniye arttırıp indisleri 1 eşitliyor.
            {
                sn += 10;

                tablo[xIndis, yIndis] = 1;

            }

            if (tablo[xIndis, yIndis] == 6) //Anahtar Jokeri pbOyuncu Xindis ve Yindisi 6 eşitlenince kapının yeni değeri 7 eşitleniyor.
            {
                this.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.level_1_acik;// anahtar jokeri alındıgında joker resmının değişmesi için formun arkaplanı değişiyor..
                if (tablo[14, 16] == 0) // tablo 14-16 değer kontrol ediliyor 0 ise yeni değer 7 oluyor..
                {
                    tablo[14, 16] = 7;

                }
            }


        }


        //(Derste Öğrenilen Rabirent Kodu)
        private bool GidebilirMi(Keys keys)
        {
            bool gidis = false; //gidis Değişkeni İlk Aşamada False 
            switch (keys)
            {
                case Keys.Up:
                    if (xIndis - 1 >= 0 && tablo[xIndis - 1, yIndis] > 0)
                    {
                        gidis = true;// Şart Dogruysa pbOyuncu gidis değeri true olup 
                        xIndis--;  //pbOyuncuyu yukarı Bir dizi kadar Yukarı çıkar
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


        private void timer1_Tick(object sender, EventArgs e) // Geri Sayım Kontrolu Yapılmakta 
        {
            if (timer1.Enabled == true)// timer değeri Enabled ise sn birer birer azaltılıyor..
            {
                sn--;
               
            }
            lbl_sure.Text = sn.ToString();// sn değeri labelde yazdırılıyor.
            if (sn == 0)// sn değişkeni = 0 eşitlendiğinde messageBox ta sürenin bittiği yazıp form oyun başlangıcına yonlendırılıyor..
            {

                MessageBox.Show("Süreniz Bitti Üzgünüm..");
                this.Close();
                Form1 frm1 = new Form1();
                frm1.Show();
                sn = 0;

            }
        }




        private void Form2_Deactivate(object sender, EventArgs e)// form Aktif olmadıgında süre ve müzik durduruluyor...(Haritalar için)
        {
            timer1.Stop();
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath + "";
            player.SoundLocation = path;
            player.Stop();
        }

        private void Form2_Activated(object sender, EventArgs e)// form Aktif olduğunda süre ve müzik devam ediyor.
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

        private void pictureBox4_Click(object sender, EventArgs e)// Oyun Kapatma çıkış işlemi Cıkarken messageBox ta oyunu kapatmak istediğinizden eminmisiniz sorusu belirtiyor...
        {



            DialogResult cevap = MessageBox.Show("Oyunu Kapatmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (cevap == DialogResult.Yes)// cevap evet ise uygulama kapatılıyor
            {


                Application.Exit();


            }


            if (cevap == DialogResult.No)// hayır ise uygulama kaldıgı yerden calısmaya devam ediyor
            {


                return;


            }

        }


    }
}
