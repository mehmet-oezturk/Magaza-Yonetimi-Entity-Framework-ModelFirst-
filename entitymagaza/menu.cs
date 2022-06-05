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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public void mlistele()
        {
            
            dataGridView1.DataSource = baglanti.Magaza.ToList();
            dataGridView1.Visible = true;
            
        }
        public void slistele()
        {

            dataGridView1.DataSource = baglanti.Sorumlular.ToList();
            dataGridView1.Visible = true;
           
        }
        public void blistele()
        {

            dataGridView1.DataSource = baglanti.Bolumler.ToList();
            dataGridView1.Visible = true;
          
        }
        public void malistele()
        {

            dataGridView1.DataSource = baglanti.Malzemeler.ToList();
            dataGridView1.Visible = true;
          
        }
        magazaEntities1 baglanti = new magazaEntities1();
        private void button1_Click(object sender, EventArgs e)
        {
            Magaza m = new Magaza();
            m.MagazaAdi = textBox1.Text;
            m.MagazaCiro = Convert.ToDecimal(textBox2.Text);
            m.MagazaAdres = textBox3.Text;
            m.SevkiyatTarihi = dateTimePicker1.Value;//mouse clik için dateTimePicker1.Text yazacağız
            m.SevkiyatGunu = comboBox1.Text;
            baglanti.Magaza.Add(m);
            baglanti.SaveChanges();
            mlistele();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            mlistele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gm = Convert.ToInt32(textBox1.Tag);
            var g = baglanti.Magaza.Where(z => z.MagazaNo == gm).SingleOrDefault();
            g.MagazaNo = Convert.ToInt32(textBox1.Tag);
            g.MagazaAdi = textBox1.Text;
            g.MagazaCiro = Convert.ToDecimal(textBox2.Text);
            g.MagazaAdres = textBox3.Text;
            g.SevkiyatTarihi = dateTimePicker1.Value;//mouse clik için dateTimePicker1.Text yazacağız
            g.SevkiyatGunu = comboBox1.Text;
          
            baglanti.SaveChanges();
            mlistele();

         
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                
                DataGridViewRow s = dataGridView1.CurrentRow;
                textBox1.Tag = s.Cells[0].Value.ToString();
                textBox1.Text = s.Cells[1].Value.ToString();
                textBox2.Text = s.Cells[2].Value.ToString();
                textBox3.Text = s.Cells[3].Value.ToString();
                dateTimePicker1.Text = s.Cells[4].Value.ToString();
                comboBox1.Text = s.Cells[5].Value.ToString();
            }
            else if(tabControl1.SelectedIndex == 1)
            {

                
                DataGridViewRow s = dataGridView1.CurrentRow;
                textBox4.Tag = s.Cells[0].Value.ToString();
                textBox4.Text = s.Cells[1].Value.ToString();
                textBox5.Text = s.Cells[2].Value.ToString();
                textBox6.Text = s.Cells[3].Value.ToString();
                textBox7.Text = s.Cells[4].Value.ToString();
                textBox8.Text = s.Cells[5].Value.ToString();
            }
            else if (tabControl1.SelectedIndex == 2)
            {

                
                DataGridViewRow s = dataGridView1.CurrentRow;
                textBox12.Tag = s.Cells[0].Value.ToString();
                textBox12.Text = s.Cells[1].Value.ToString();
                textBox11.Text = s.Cells[2].Value.ToString();
                textBox10.Text = s.Cells[3].Value.ToString();
            }
            else if (tabControl1.SelectedIndex == 3)
            {

                
                DataGridViewRow s = dataGridView1.CurrentRow;
                textBox16.Tag = s.Cells[0].Value.ToString();
                textBox16.Text = s.Cells[1].Value.ToString();
                textBox15.Text = s.Cells[2].Value.ToString();
                textBox14.Text = s.Cells[3].Value.ToString();
                textBox13.Text = s.Cells[4].Value.ToString();
                textBox9.Text = s.Cells[5].Value.ToString();
                textBox17.Text = s.Cells[6].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gm = Convert.ToInt32(textBox1.Tag);
            var sil = baglanti.Magaza.Where(z => z.MagazaNo == gm).FirstOrDefault();
            baglanti.Magaza.Remove(sil);
            baglanti.SaveChanges();
            mlistele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sorumlular s = new Sorumlular();
            s.MagazaNo = Convert.ToInt32(textBox4.Text);
            s.SorumluAdi = textBox5.Text;
            s.SorumluMaas= Convert.ToDecimal(textBox6.Text);
            s.SorumluPrim = Convert.ToDecimal(textBox7.Text);
            s.SorumluVardiya = textBox8.Text;
            baglanti.Sorumlular.Add(s);
            baglanti.SaveChanges();
            slistele();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            slistele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int gm = Convert.ToInt32(textBox4.Tag);
            var sil = baglanti.Sorumlular.Where(z => z.SorumluNo == gm).FirstOrDefault();
            baglanti.Sorumlular.Remove(sil);
            baglanti.SaveChanges();
            slistele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int gm = Convert.ToInt32(textBox4.Tag);
            var s = baglanti.Sorumlular.Where(z => z.SorumluNo == gm).SingleOrDefault();
            s.SorumluNo = Convert.ToInt32(textBox4.Tag);
            s.MagazaNo = Convert.ToInt32(textBox4.Text);
            s.SorumluAdi = textBox5.Text;
            s.SorumluMaas = Convert.ToDecimal(textBox6.Text);
            s.SorumluPrim = Convert.ToDecimal(textBox7.Text);
            s.SorumluVardiya = textBox8.Text;
          
            baglanti.SaveChanges();
            slistele();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            blistele();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bolumler b = new Bolumler();
            b.SorumluNo = Convert.ToInt32(textBox12.Text);
            b.BolumAdi = textBox11.Text;
            b.BolumUrunSayisi = Convert.ToInt32(textBox10.Text);
            baglanti.Bolumler.Add(b);
            baglanti.SaveChanges();
            blistele();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int gm = Convert.ToInt32(textBox12.Tag);
            var b = baglanti.Bolumler.Where(z => z.BolumNo == gm).SingleOrDefault();
          
            b.SorumluNo = Convert.ToInt32(textBox12.Text);
            b.BolumAdi = textBox11.Text;
            b.BolumUrunSayisi = Convert.ToInt32(textBox10.Text);
           
            baglanti.SaveChanges();
            blistele();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int gm = Convert.ToInt32(textBox12.Tag);
            var b = baglanti.Bolumler.Where(z => z.BolumNo == gm).FirstOrDefault();
            baglanti.Bolumler.Remove(b);
            baglanti.SaveChanges();
            blistele();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            malistele();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Malzemeler m = new Malzemeler();
            m.MagazaNo = Convert.ToInt32(textBox16.Text);
            m.MalzemeAdi = textBox15.Text;
            m.MalzemeAdet= Convert.ToInt32(textBox14.Text);
            m.MalzemeBirimFiyat = Convert.ToDecimal(textBox13.Text);
            m.MalzemeKod = Convert.ToInt32(textBox9.Text);
            m.MalzemeAciklama = textBox17.Text;
            baglanti.Malzemeler.Add(m);
            baglanti.SaveChanges();
            malistele();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            int gm = Convert.ToInt32(textBox16.Tag);
            var m = baglanti.Malzemeler.Where(z => z.MalzemeNo == gm).SingleOrDefault();
            m.MagazaNo = Convert.ToInt32(textBox16.Text);
            m.MalzemeAdi = textBox15.Text;
            m.MalzemeAdet = Convert.ToInt32(textBox14.Text);
            m.MalzemeBirimFiyat = Convert.ToDecimal(textBox13.Text);
            m.MalzemeKod = Convert.ToInt32(textBox9.Text);
            m.MalzemeAciklama = textBox17.Text;
           
            baglanti.SaveChanges();
            malistele();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int gm = Convert.ToInt32(textBox16.Tag);
            var m = baglanti.Malzemeler.Where(z => z.MalzemeNo == gm).SingleOrDefault();
            baglanti.Malzemeler.Remove(m);
            baglanti.SaveChanges();
            malistele();

        }

        private void menu_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
           

        }

        private void button4_Click(object sender, EventArgs e)//ARAMA
        {
            var sorgu = from s in baglanti.Magaza where s.MagazaAdi.Contains(textBox1.Text) select s;
            dataGridView1.DataSource = sorgu.ToList();
            dataGridView1.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var sorgu = from s in baglanti.Sorumlular where s.SorumluAdi.Contains(textBox5.Text) select s;
            //dataGridView1.DataSource = sorgu.ToList();
            dataGridView1.Visible = true;

            //hocanın yaptığı arama
            dataGridView1.DataSource = baglanti.Sorumlular.Where(x => x.SorumluAdi.ToLower().Contains(textBox5.Text) || x.SorumluAdi.ToUpper().Contains(textBox5.Text)).ToList();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sorgu = from s in baglanti.Bolumler where s.BolumAdi.Contains(textBox11.Text) select s;
            dataGridView1.DataSource = sorgu.ToList();
            dataGridView1.Visible = true;
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var sorgu = from s in baglanti.Malzemeler where s.MalzemeAdi.Contains(textBox15.Text) select s;
            dataGridView1.DataSource = sorgu.ToList();
            dataGridView1.Visible = true;
        
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }
    }
}
