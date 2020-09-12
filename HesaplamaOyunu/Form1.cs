using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesaplamaOyunu
{
    public partial class Form1 : Form
    {
        int x, a, b,k ,sayac=0,sayac2=0,y;
        Random Rasgele = new Random();
        int[] Dizia = new int[5];
        int sorusayisi=0, puan=0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("doğru cevap");
                    puan += 20;
                    label14.Text = Convert.ToString(puan);

                }
                else
                {
                    MessageBox.Show("Yanlış Cevap");
                    puan -= 5;
                    label14.Text = Convert.ToString(puan);
                }
            }
            else if (y == 2)
            {
                if (radioButton2.Checked == true)
                {
                    MessageBox.Show("doğru cevap");
                    puan += 20;
                    label14.Text = Convert.ToString(puan);
                }
                else
                {
                    MessageBox.Show("Yanlış Cevap");
                    puan -= 5;
                    label14.Text = Convert.ToString(puan);
                }
            }
            else if (y == 3)
            {
                if (radioButton3.Checked == true)
                {
                    MessageBox.Show("doğru cevap");
                    puan += 20;
                    label14.Text = Convert.ToString(puan);
                }
                else
                {
                    MessageBox.Show("Yanlış Cevap");
                    puan -= 5;
                    label14.Text = Convert.ToString(puan);
                }
            }
            else if (y == 4)
            {
                if (radioButton4.Checked == true)
                {
                    MessageBox.Show("doğru cevap");
                    puan += 20;
                    label14.Text = Convert.ToString(puan);
                }
                else
                {
                    MessageBox.Show("Yanlış Cevap");
                    puan -= 5;
                    label14.Text = Convert.ToString(puan);
                }
            }
            button1.Enabled = true;
            button2.Enabled = false;
        }

        int[] Dizib = new int[5];

        private void button1_Click(object sender, EventArgs e)
        {
            sorusayisi += 1;
            button1.Text = "Devam Et";
            button2.Enabled = true;
            button1.Enabled = false;
            label12.Text = Convert.ToString(sorusayisi);
            x = Rasgele.Next(1, 4);
            for (k = 1; k <= 4; k++)
            {
                SoruUret();
                Yazdir(k);

            }

            


            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }
        public void SoruUret()
        {
            while (sayac == 0)
            {
                if (k >= 2)
                {
                    k--;
                    a = Rasgele.Next(2, 10);
                    Dizia[k] = a;
                    b = Rasgele.Next(0, 3);
                    Dizib[k] = b;

                    if (Dizia[k] == Dizia[k - 1] || Dizib[k] == Dizib[k - 1])
                    {
                        k++;
                    }
                    else
                    {
                        k++;
                        sayac = 1;
                    }


                }
                else
                {
                    k--;
                    a = Rasgele.Next(2, 10);
                    Dizia[k] = a;
                    b = Rasgele.Next(0, 3);
                    Dizib[k] = b;
                    sayac = 1;
                    k++;
                }
               


            }
            sayac = 0;
        }
        public void Yazdir(int i)
        {
            if (b == 0)
            {
                if (i == 1)
                {
                    radioButton1.Text = "" + a + "x";
                    if (x == 1)
                    {
                        
                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 1;
                    }

                }

                if (i == 2)
                {
                    radioButton2.Text = "" + a + "x";
                    if (x == 2)
                    {

                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 2;
                    }

                }
                if (i == 3)
                {
                    radioButton3.Text = "" + a + "x";
                    if (x == 3)
                    {

                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 3;
                    }

                }
                if (i == 4)
                {
                    radioButton4.Text = "" + a + "x";
                    if (x == 4)
                    {

                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 4;
                    }

                }
            }
            else
            {
                if (i == 1)
                {
                    radioButton1.Text = "" + a + "x+" + b + "";
                    if (x == 1)
                    {

                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 1;
                    }

                }

                if (i == 2)
                {
                    radioButton2.Text = "" + a + "x+" + b + "";
                    if (x == 2)
                    {

                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 2;
                    }

                }

                if (i == 3)
                {
                    radioButton3.Text = "" + a + "x+" + b + "";
                    if (x == 3)
                    {

                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 3;
                    }

                }
                if (i == 4)
                {
                    radioButton4.Text = "" + a + "x+" + b + "";
                    if (x == 4)
                    {

                        int sayi = a * 1 + b;
                        int sayi2 = a * 2 + b;
                        int sayi3 = a * 3 + b;
                        int sayi4 = a * 4 + b;
                        label6.Text = sayi.ToString();
                        label7.Text = sayi2.ToString();
                        label8.Text = sayi3.ToString();
                        label10.Text = sayi4.ToString();
                        y = 4;
                    }

                }
            }
        }
    }
}
