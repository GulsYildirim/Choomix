using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Text; 

namespace _4.Sayfa
{
    public partial class AdminLogin2 : Form
    {
        public AdminLogin2()
        {
            InitializeComponent();
        }

        public static string oteltoplami;
        public static string kisi;
        public static string muzetoplami;
        public static string muzekisi;
        public static string restorantoplami;
        public static string restorankisi;
        public static string turtoplami;
        public static string turkisi;
        public static string ulasımtoplami;
        public static string ulasımkisi;
        AdminCity gir = new AdminCity();
       

        private void admingiris2_Load(object sender, EventArgs e)
        {
           
           
            this.AutoScroll = true;
            this.MaximizeBox = false;
            BackColor = Color.Silver;
            menuStrip1.BackColor = Color.Silver;

            
            pictureBox1.ImageLocation = "logo1.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            
            label1.Text = gir.lx1;
            label2.Text = gir.lx2;

            
            File.AppendAllText("admin.txt",AdminCity.kisi+": "+Environment.NewLine);
            File.AppendAllText("admin.txt","Restoran: " + Basket.restoranisim + " restoranı " + restorankisi + " kişi için " + restorantoplami + " ücret ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Müze: " + ", " + Basket.müzeisim + " müzesi " + muzekisi + " kişi için " + muzetoplami + " ücret ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Otel: "+ Basket.isim + " oteli " + kisi + " kişi için " + oteltoplami + " ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Tur: " + Basket.turisim + " turu " + turkisi + " kişi için " + turtoplami + " ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Ulasım:" + Basket.ulasimisim + " turizm " + ulasımkisi + " kişi için " + ulasımtoplami + " ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "-----------------------"+Environment.NewLine);

            
            string oku = File.ReadAllText("admin.txt");
            
            richTextBox1.Text = oku;
           
        }

        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminCity.kisi = "0";
            HomePage ana = new HomePage();
            ana.Show();
            this.Hide();
            AdminLogin2.oteltoplami = "0";
            AdminLogin2.kisi = "0";
            AdminLogin2.restorankisi = "0";
            AdminLogin2.restorantoplami = "0";
            AdminLogin2.muzetoplami = "0";
            AdminLogin2.muzekisi = "0";
            AdminLogin2.turtoplami = "0";
            AdminLogin2.turkisi = "0";
            AdminLogin2.ulasımkisi = "0";
            AdminLogin2.ulasımtoplami = "0";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
