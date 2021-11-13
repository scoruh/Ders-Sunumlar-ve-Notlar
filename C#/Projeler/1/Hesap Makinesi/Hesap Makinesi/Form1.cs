using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class HesapMakinesi : Form
    {
        int islem = 0;
        double sayi1 = 0, sayi2 = 0; // sayıları double olarak kullanıyoruz ki küsüratlı işlemler yapılabilsin.

        public HesapMakinesi()
        {
            InitializeComponent();
        }

        public void sifirla()   // bu metod 2. sayı girilmeden önce textbox'ı sıfırlayacak.
        {
            textBox1.Text = "0";
        }

        public double hesapla() // bu metod işlemleri yapan metodumuz.
        {
            double sonuc = 0;

            if (islem == 1)
                sonuc = sayi1 + sayi2;
            else if (islem == 2)
                sonuc = sayi1 - sayi2;
            else if (islem == 3)
                sonuc = sayi1 * sayi2;
            else if (islem == 4)
                sonuc = sayi1 / sayi2;
            else if (islem == 5)
                sonuc = sayi1 * sayi1;
            else if (islem == 6)
                sonuc = 1 / sayi1;
            else if (islem == 7)
                sonuc = Math.Sqrt(sayi1); // karekök fonksiyonu.
            else if (islem == 8)
                sonuc = (sayi1 * sayi2) / 100;
            else
                sonuc = 0;
            return sonuc;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0"; // textbox'ın başlama değerini sıfır olarak giriyoruz.
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // bu if komutunda sayı butonlarına basılınca ne olacağını belirttik.
                textBox1.Text = "";  // bunu takip eden if komutları da aynı işlevi görüyor.
            textBox1.Text += "1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "9";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += ",";
        }

        private void button20_Click(object sender, EventArgs e) // toplama butonununa tıklanınca gerçekleşecek olay.
        {
            islem = 1;
            sayi1 = Convert.ToDouble(textBox1.Text); 
            sifirla();
        }

        private void button16_Click(object sender, EventArgs e) // çıkarma butonununa tıklanınca gerçekleşecek olay.
        {
            islem = 2;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void button12_Click(object sender, EventArgs e) // çarpma butonununa tıklanınca gerçekleşecek olay.
        {
            islem = 3;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void button8_Click(object sender, EventArgs e)  // bölme butonununa tıklanınca gerçekleşecek olay.
        {
            islem = 4;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void button23_Click(object sender, EventArgs e) // eşittir butonunun işlevi.
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = hesapla().ToString();
        }

        private void button4_Click(object sender, EventArgs e) // ekrana yazılan son veriyi silme.
        {
            string veri = textBox1.Text;
            textBox1.Text = "";
            int i;
            for (i = 0; i < veri.Length - 1; i++){ // en son veriyi yazdırmamak için "veri.Lenght - 1" dedik
                textBox1.Text += veri[i].ToString();
            }
            
            }

        private void button6_Click(object sender, EventArgs e) // girilen sayının karesi.
        {
            islem = 5;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = hesapla().ToString();
        }

        private void button2_Click(object sender, EventArgs e) // tamamen silme butonu textbox'ı ilk haline çeviriyor.
        {
            sifirla();
        }

        private void button5_Click(object sender, EventArgs e) // 1/x işlemi.
        {
            islem = 6;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = hesapla().ToString();
        }

        private void button7_Click(object sender, EventArgs e) // karekök işlemi.
        {
            islem = 7;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = hesapla().ToString();
        }

        private void button1_Click(object sender, EventArgs e) // sayının yüzdelik hesaplanması.
        {
            islem = 8;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
            sayi2 = Convert.ToDouble(textBox1.Text);
            sifirla();
            textBox1.Text = hesapla().ToString();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            sifirla(); // tamamen silme butonu textbox'ı ilk haline çeviriyor.
        }
    }
}
