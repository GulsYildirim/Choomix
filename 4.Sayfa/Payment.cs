﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _4.Sayfa
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
           



            
            Catalog geri = new Catalog();
            geri.Show();
            this.Hide();

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           


            LoginAssign.kullanıcı = "0";
          
            MessageBox.Show("Sayın," + Environment.NewLine + Environment.NewLine + textBox8.Text + Environment.NewLine +
               Environment.NewLine + textBox1.Text + Environment.NewLine +
               Environment.NewLine + maskedTextBox1.Text + Environment.NewLine + Environment.NewLine +
              "Toplam Odenen: " + Basket.total + Environment.NewLine + Environment.NewLine +
              "ÖDEMENİZ TAMAMLANMIŞTIR. :)" + Environment.NewLine + Environment.NewLine +
              "Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");

        }

       
        public String  sonuç,click1,click2,click3,click4,click5;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox8.Clear();
            maskedTextBox1.Clear();
            Basket.totalPrice = 0;
            label5.Text = " ";  label8.Text = " ";     label10.Text = " ";   
            label14.Text = ""; label18.Text = " ";    label19.Text = " ";    
            label32.Text = " "; label34.Text = " ";    label35.Text = " ";    
            label43.Text = " "; label49.Text = " ";    label52.Text = " ";    
            label48.Text = " "; label47.Text = " ";
            label23.Text = " "; label37.Text = " ";
            label12.Text = " "; label11.Text = " ";
            label25.Text = " "; label26.Text = " ";
            label39.Text = " "; label40.Text = " ";
            label51.Text = " "; label53.Text = " ";

            Basket.oteltoplam = "0";
            Basket.müzetoplam = "0";
            Basket.turtoplam = "0";
            Basket.restorantoplam = "0";
            Basket.ulaşımtoplam = "0";
            Basket.kisisayisi = "0";
            Basket.kisisayisimüze = "0";
            Basket.kisisayisirestoran = "0";
            Basket.kisisayisitur = "0";
            Basket.kisisayisiulaşım = "0";
            Basket.günlükfiyati = "0";
            Basket.günlükfiyatmüze = "0";
            Basket.günlükfiyatrestoran = "0";
            Basket.günlükfiyattur = "0";
            Basket.fiyatulaşım = "0";
            Basket.müzeisim = "";
            Basket.isim = "";
            Basket.restoranisim = "";
            Basket.turisim = "";

            groupBox1.BackColor = Color.Silver;
            groupBox2.BackColor = Color.Silver;
            groupBox3.BackColor = Color.Silver;
            groupBox4.BackColor = Color.Silver;
            groupBox5.BackColor = Color.Silver;
            MessageBox.Show("Çıkış Yaptınız. Anasayfaya Dönünüz.");

            HomePage a = new HomePage();
            this.Hide();
            a.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HomePage ana = new HomePage();
            ana.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        Basket sepet = new Basket();

        private void Fatura_Load(object sender, EventArgs e)
        {  
            this.AutoScroll = true; 
            this.MaximizeBox = false;

            BaseClass.kategori = "Odeme";

            AdminCity.kisi = LoginAssign.kullanıcı;

            
            pictureBox1.ImageLocation = "addbasket.png";
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = "creditcard.png";
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

          
            label47.Text = LoginAssign.kullanıcı;
            if ((label47.Text != LoginAssign.kullanıcı) || (LoginAssign.kullanıcı == "0"))
            {
                label54.Text = "Giriş Yapınız.";
                label54.ForeColor = Color.Maroon;
            }
            else
            {
                label54.Text = "HOŞGELDİN " + LoginAssign.kullanıcı;
                label54.ForeColor = Color.SeaGreen;
            }

           
            this.AutoScroll = true;
            this.MaximizeBox = false;
            label1.Text = "ÖDEME";

            label6.Text = Basket.isim + " Seçtiniz.";
            label16.Text = Basket.müzeisim +" Seçtiniz.";
            label30.Text = Basket.turisim + " Seçtiniz.";
            label41.Text = Basket.restoranisim + " Seçtiniz.";


            label7.Text = "Bilgilerinizi tamamlayınız:";

            label4.Text = "Kişi Sayısı:";
            label15.Text = "Kişi Sayısı: ";
            label31.Text = "Kişi Sayısı: ";
            label42.Text = "Kişi Sayısı: ";
            label45.Text = "Kişi Sayısı: ";

           
            button1.Text = "Sepeti Onayla";
            button3.Text = "Giriş Yapın";
            button4.Text = "Kayıt Olun";
            button5.Text = "Çıkış Yap";

            
            label14.Text = Basket.kisisayisimüze;
            label5.Text = Basket.kisisayisi;
            label32.Text = Basket.kisisayisitur;


           
            label43.Text = Basket.kisisayisirestoran;
          
            label48.Text = Basket.kisisayisiulaşım;

            label9.Text = "Günlük Fiyat:";
            label33.Text = "Günlük Fiyat:"; 
            label17.Text = "Fiyat:";
            label20.Text = "Fiyat";
            label55.Text = "Fiyat";

           
            label8.Text = Basket.günlükfiyati;
            label18.Text = Basket.günlükfiyatmüze;
            label34.Text = Basket.günlükfiyattur; 
            label49.Text = Basket.günlükfiyatrestoran;
            label58.Text = Basket.fiyatulaşım;

           
            label10.Text = sepet.birim;
            label19.Text = sepet.birim;
            label35.Text = sepet.birim; 
            label52.Text = sepet.birim;
            label53.Text = sepet.birim;
            label56.Text= sepet.birim;
            label57.Text= sepet.birim;

            
            label13.Text = "Toplam";
            label12.Text = Basket.oteltoplam;
            label39.Text = Basket.turtoplam; 
            label50.Text = "Toplam";
            label51.Text = Basket.restorantoplam;
            label27.Text = "Toplam";
            label38.Text = "Toplam";
            label25.Text = Basket.müzetoplam;
            label46.Text = "Toplam";
            label47.Text= Basket.ulaşımtoplam;

            label26.Text = sepet.birim;
          
            groupBox1.Text = "Otel";
            groupBox2.Text = "Müze";
            groupBox3.Text = "Tur"; 
            groupBox4.Text = "Restoran";
            groupBox5.Text = "Ulaşım";

            label11.Text = sepet.birim;
            label40.Text = sepet.birim;

           
            label2.Text = "Mail Adresi:";
            label3.Text = "Telefon Numarası:";
            label21.Text = "Ad Soyad: ";


          
            label24.Text = "Gün Sayısı:";
            label36.Text = "Gün Sayısı:";
            label23.Text = Basket.günsayisi.ToString();
            label37.Text = Basket.günsayisitur.ToString(); 
            button2.Text = "Geri";

          
            label22.Text = Basket.total.ToString();
            label28.Text = "Genel Toplam:";
            label29.Text = sepet.birim;

 
            if (Basket.oteltoplam != "0")
            {
                groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            }
            if (Basket.müzetoplam != "0")
            {
                groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            }
            if (Basket.turtoplam != "0")
            {
                groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            }
            if (Basket.restorantoplam != "0")
            {
                groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            }
            if (Basket.ulaşımtoplam != "0")
            {
                groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            }


            textBox1.Text = LoginAssign.mailadresi;
            maskedTextBox1.Text = LoginAssign.telnumarasi;

            textBox8.Text = LoginAssign.kullanıcı;
            if (textBox8.Text != LoginAssign.kullanıcı || (LoginAssign.kullanıcı == "0"))
            {
                MessageBox.Show("Lütfen Önce Giriş Yapınız!");
                button1.Enabled = false;
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignIn giris = new SignIn();
            giris.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignUp kayıt = new SignUp();
            this.Hide();
            kayıt.Show();
        }

    }
}
