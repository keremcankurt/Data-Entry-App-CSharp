using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Kaydı
{
    public partial class Form1 : Form
    {
        Model1 model1 = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Goster();
        }
        public void Goster()
        {

            var ogrenciler = (from i in model1.ogrenciler select i).ToList();
            listView1.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                listView1.Items.Add(ogrenci.OgrID.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(ogrenci.AdSoyad.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(ogrenci.Sehir.ToString());

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string ogrID = textBox1.Text;
            bool kontrol = true;
            for (int i = 0; i < ogrID.Length; i++)
            {
                if (!Char.IsNumber(ogrID[i]))
                {
                    kontrol = false;
                    break;
                }
            }
            if (!kontrol)
            {
                MessageBox.Show("Öğrenci numarasını sayı giriniz!");
            }
            else
            {
                Ogrenci ogrenci = new Ogrenci();

                ogrenci.OgrID = Convert.ToInt32(textBox1.Text);
                ogrenci.AdSoyad = textBox2.Text;
                ogrenci.Sehir = textBox3.Text;
                model1.ogrenciler.Add(ogrenci);
                model1.SaveChanges();
                Goster();
            }

        }
    }
}
