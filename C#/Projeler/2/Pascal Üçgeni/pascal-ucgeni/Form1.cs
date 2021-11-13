using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pascal_ucgeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_pascalHesapla_Click(object sender, EventArgs e)
        {

            this.listBox1.Items.Clear();

            yazdırPascal((int)this.num_pascalKatman.Value, this.listBox1);
        }
              
        int binomKatsayısı(int n, int k)
        {
            int res = 1;
            if (k > n - k)
                k = n - k;
            for (int i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }

            return res;
        }

        // Üçgenin ilk n satırını
        // burada yazdırıyoruz.         
        void yazdırPascal(int n, ListBox listBox1)
        {
            // Her bi satırı tekrarlatıp
            // girdileri yazdırıyoruz.
            for (int line = 0; line < n; line++)
            {
                string listboxLine = String.Empty;
                
                for (int i = 0; i <= line; i++)
                    listboxLine += n + binomKatsayısı(line, i);

                listBox1.Items.Add(listboxLine);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
