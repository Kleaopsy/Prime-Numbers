using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asal_Sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListView Asallar;
        bool FormAçıklık,AsalMı = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FormAçıklık == true)
                {
                    Asallar.Clear();
                }

                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && Convert.ToInt32(textBox1.Text) != Convert.ToInt32(textBox2.Text))
                {
                    if (FormAçıklık == false)
                    {
                        this.Height += 120;
                        FormAçıklık = true;

                        Asallar = new ListView();
                        Asallar.Location = new Point(5,45);
                        Asallar.Size = new Size(227, 115);
                        Controls.Add(Asallar);
                    }

                    Asallar.Clear();
                    if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
                    {
                        for (int f1 = Convert.ToInt32(textBox2.Text); f1 <= Convert.ToInt32(textBox1.Text); f1++)
                        {
                            for (int f2 = 2; f2 < f1; f2++)
                            {
                                if (f1%f2 == 0)
                                {
                                    AsalMı = false;
                                }
                            }
                            if (AsalMı == true)
                            {
                                if (f1 != 0 && f1 != 1 && f1 != -1)
                                {
                                    Asallar.Items.Add(f1.ToString());
                                }
                            }
                            else
                            {
                                AsalMı = true;
                            }
                        }
                    }
                    else if (Convert.ToInt32(textBox2.Text) > Convert.ToInt32(textBox1.Text))
                    {
                        for (int f1 = Convert.ToInt32(textBox1.Text); f1 <= Convert.ToInt32(textBox2.Text); f1++)
                        {
                            for (int f2 = 2; f2 < f1; f2++)
                            {
                                if (f1 % f2 == 0)
                                {
                                    AsalMı = false;
                                }
                            }
                            if (AsalMı == true)
                            {
                                if (f1 != 0 && f1 != 1 && f1 != -1)
                                {
                                    Asallar.Items.Add(f1.ToString());
                                }
                            }
                            else
                            {
                                AsalMı = true;
                            }
                        }
                    }
                }
                else
                {
                    if (FormAçıklık == true)
                    {
                        this.Height -= 120;
                        FormAçıklık = false;

                        Controls.Remove(Asallar);
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
