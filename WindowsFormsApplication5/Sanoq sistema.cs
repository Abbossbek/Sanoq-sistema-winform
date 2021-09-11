using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        textBox2.Focus();
                    else
                        button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox2))
                        textBox3.Focus();
                    else
                        button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                        button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Convert.ToInt32(textBox1.Text), m1, i = 0;
                int[] mas = new int[256];
                m1 = m;
                while (m > 0)
                {
                    i++;
                    m = m / 10;
                }
                int n = i;
                while (m1 > 0)
                {
                    mas[i] = m1 % 10;
                    i--;
                    m1 = m1 / 10;
                }
                int max = mas[1];
                for (int j = 1; j <= n; j++)
                {
                    if (max < mas[j])
                        max = mas[j];
                }
                int ss = Convert.ToInt32(textBox2.Text); ;
                bool sanoqsis = true;
                if (ss <= max)
                {
                    sanoqsis = false;
                }
                else
                    max = ss - 1;
                int s = 0, l = Convert.ToInt32(textBox3.Text);

                for (int k = 0, j = n; k < n && j > 0; k++, j--)
                {
                    s += Convert.ToInt32(mas[j]) * (int)(Math.Pow(ss, k));
                }

                int q, s1 = s;
                char[] mas1 = new char[256];
                i = 0;
                string son = "";
                if (l == 0 || l == 1)
                {
                    sanoqsis = false;
                }
                else
                {
                    while (s > 0)
                    {
                        i++;
                        s = s / l;
                    }
                    n = i;
                    while (s1 > 0)
                    {
                        q = s1 % l;
                        switch (q)
                        {
                            case 10: mas1[i] = 'A';
                                break;
                            case 11: mas1[i] = 'B';
                                break;
                            case 12: mas1[i] = 'C';
                                break;
                            case 13: mas1[i] = 'D';
                                break;
                            case 14: mas1[i] = 'E';
                                break;
                            case 15: mas1[i] = 'F';
                                break;
                            default: mas1[i] = (char)(q + 48);
                                break;
                        }
                        i--;
                        s1 = s1 / l;
                    }
                    for (int j = 1; j <= n; j++)
                        son = son + (mas1[j]);
                }
                if (sanoqsis == false)
                {
                    label4.Text="Sanoq sistemasi noto'g'ri kiritildi!\nQayta urinib ko'ring!";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    label4.Text = son;
                }
            }
            catch
            {
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
