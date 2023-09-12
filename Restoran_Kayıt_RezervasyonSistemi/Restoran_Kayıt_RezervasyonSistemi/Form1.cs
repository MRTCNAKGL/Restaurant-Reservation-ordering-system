using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Kayıt_RezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ad ve Soyad: "+textBox1.Text);
            listBox1.Items.Add("Telefon: "+maskedTextBox1.Text);
            listBox1.Items.Add("Tarih: "+dateTimePicker1.Text);
            listBox1.Items.Add("Saat: "+ maskedTextBox2.Text);
            listBox1.Items.Add("Kişi Sayısı: " + maskedTextBox6.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            maskedTextBox1.Clear();
            dateTimePicker1.ResetText();
            maskedTextBox2.Clear();
            maskedTextBox6.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            if (comboBox1.SelectedIndex == 0)
            {
            int.TryParse(maskedTextBox3.Text,out int girilendeger);

                int sonuc = girilendeger * 50;
                listBox3.Items.Add(sonuc + " ₺ ");
           }

            if (comboBox1.SelectedIndex == 1)
            {
                int.TryParse(maskedTextBox3.Text, out int girilendeger);

                int sonuc = girilendeger * 60;
                listBox3.Items.Add(sonuc + " ₺ " );
            }
            if (comboBox1.SelectedIndex == 2)
            {
                int.TryParse(maskedTextBox3.Text, out int girilendeger);

                int sonuc = girilendeger * 70;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                int.TryParse(maskedTextBox3.Text, out int girilendeger);

                int sonuc = girilendeger * 55;
                listBox3.Items.Add(sonuc + " ₺ ");
            }

            if (comboBox1.SelectedIndex == 4)
            {
                int.TryParse(maskedTextBox3.Text, out int girilendeger);

                int sonuc = girilendeger * 80;
                listBox3.Items.Add(sonuc + " ₺ ");
            }

            if (comboBox2.SelectedIndex == 0)
            {
                int.TryParse(maskedTextBox4.Text, out int girilendeger);

                int sonuc = girilendeger * 5;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox2.SelectedIndex == 1)
            {
                int.TryParse(maskedTextBox4.Text, out int girilendeger);

                int sonuc = girilendeger * 20;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox2.SelectedIndex == 2)
            {
                int.TryParse(maskedTextBox4.Text, out int girilendeger);

                int sonuc = girilendeger * 10;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox2.SelectedIndex == 3)
            {
                int.TryParse(maskedTextBox4.Text, out int girilendeger);

                int sonuc = girilendeger * 10;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox3.SelectedIndex == 0)
            {
                int.TryParse(maskedTextBox5.Text, out int girilendeger);

                int sonuc = girilendeger * 60;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox3.SelectedIndex == 1)
            {
                int.TryParse(maskedTextBox5.Text, out int girilendeger);

                int sonuc = girilendeger * 50;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox3.SelectedIndex == 2)
            {
                int.TryParse(maskedTextBox5.Text, out int girilendeger);

                int sonuc = girilendeger * 60;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            if (comboBox3.SelectedIndex == 3)
            {
                int.TryParse(maskedTextBox5.Text, out int girilendeger);

                int sonuc = girilendeger * 50;
                listBox3.Items.Add(sonuc + " ₺ ");
            }
            listBox2.Items.Add(comboBox1.Text+" "+comboBox2.Text+" "+comboBox3.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            listBox2.Items.Clear();
            maskedTextBox3.Clear();
            comboBox1.ResetText();
            maskedTextBox4.Clear();
            comboBox2.ResetText();
            maskedTextBox5.Clear();
            comboBox3.ResetText();

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Visible=false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
        int saniye = 0, dakika = 0, saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            //Programın ne kadar süre açık kaldığını gösteren kod
            saniye++;
            label14.Text = saniye.ToString();
            if (saniye == 60)
           
            {
                dakika++;
                label13.Text=dakika.ToString();
                saniye = 0;

                if(dakika == 60)
                {
                    saat = saat + 1;
                    label12.Text = saat.ToString();
                    dakika = 0;
                }

            }

        }
    }
}
