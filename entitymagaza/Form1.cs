using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entitymagaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        magazaEntities1 baglanti = new magazaEntities1();
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
        sorgu s = new sorgu();
        private void button1_Click(object sender, EventArgs e)
        {
            if (s.KullaniciGiris(textBox1.Text, textBox2.Text))
            {
                menu git = new menu();
                git.Show();
                this.Hide();
            }
            else { MessageBox.Show("kullnıcı adı veya şifre hatalı \n Tekrar deneyiniz veya kayıtol butonuna basınız"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanicilar k = new kullanicilar();
            k.KullaniciAd = textBox3.Text;
            k.Sifre = textBox4.Text;
            baglanti.kullanicilar.Add(k);
            MessageBox.Show("Kayıt işleminiz gerçekleşti");
            baglanti.SaveChanges();
        }
    }
}
