using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.Unidad_1;
using Calculus;

namespace WFAnalisisNumerico 
{
    public partial class AnalisisNumerico : Form
    {
        public AnalisisNumerico()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private bool ChequearTextBoxs(object sender, EventArgs e)
        {
            bool txtbien = true;
            if ((txt_Iter.Text.Trim() == string.Empty) || (txt_Tole.Text.Trim() == string.Empty) ||
                (txt_LI.Text.Trim() == string.Empty) || (txt_Funcion.Text.Trim() == string.Empty))
            {
                if ((txt_Iter.Text.Trim() == string.Empty))
                    txt_Iter.BackColor = Color.Red;
                if ((txt_Tole.Text.Trim() == string.Empty))
                    txt_Tole.BackColor = Color.Red;
                if ((txt_LI.Text.Trim() == string.Empty))
                    txt_LI.BackColor = Color.Red;
                if ((txt_LD.Text.Trim() == string.Empty))
                    txt_LD.BackColor = Color.Red;
                if ((txt_Funcion.Text.Trim() == string.Empty))
                    txt_Funcion.BackColor = Color.Red;
                txtbien = false;
            }
            return txtbien;
        }

        // Btn1: Método de bisección
        private void btn1_ObtenerClick_Click(object sender, EventArgs e)
        {
            if (!ChequearTextBoxs(sender, e))
            {
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                Resultado res = Ejercicio1.Biseccion(txt_Funcion.Text, int.Parse(txt_Iter.Text),
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));
                if (!res.Ok)
                {
                    MessageBox.Show(res.Mensaje);
                }
                else
                {
                    lbl_Iter_1.Text = res.Iteraciones.ToString();
                    lbl_Tole_1.Text = res.Tolerancia.ToString();
                    lbl_Solucion_1.Text = res.Resolucion.ToString();
                }
            }
        }
        // btn3: metodo de Regla Falsa
        private void btn2_Obtener_Click(object sender, EventArgs e)
        {
            if (!ChequearTextBoxs(sender, e))
            {
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                Resultado res = Ejercicio1.ReglaFalsa(txt_Funcion.Text, int.Parse(txt_Iter.Text),
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));
                if (!res.Ok)
                {
                    MessageBox.Show(res.Mensaje);
                }
                else
                {
                    lbl_Ite_2.Text = res.Iteraciones.ToString();
                    lbl_Tole_2.Text = res.Tolerancia.ToString();
                    lbl_Solu_2.Text = res.Resolucion.ToString();
                }
            }
        }

        // btn3: metodo de Newton-Raphson
        private void btn3_Obtener_Click(object sender, EventArgs e)
        {
                Resultado res = Ejercicio1.Newton(txt_Funcion.Text, int.Parse(txt_Iter.Text),
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text));

                 if (!res.Ok)
                 {
                     MessageBox.Show(res.Mensaje);
                 }
                 else
                 {
                     lbl_Ite_3.Text = res.Iteraciones.ToString();
                     lbl_Tole_3.Text = res.Tolerancia.ToString();
                     lbl_Solu_3.Text = res.Resolucion.ToString();
                 }
            //}
        }

        //Metodo de la Secante
        private void btnObtener_4_Click(object sender, EventArgs e)
        {
            if (!ChequearTextBoxs(sender, e))
            {
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                Resultado res = Ejercicio1.Secante(txt_Funcion.Text, int.Parse(txt_Iter.Text), 
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));

                if (!res.Ok)
                {
                    MessageBox.Show(res.Mensaje);
                }
                else
                {
                    lbl_Iter_4.Text = res.Iteraciones.ToString();
                    lbl_Tole_4.Text = res.Tolerancia.ToString();
                    lbl_Solucion_4.Text = res.Resolucion.ToString();
                }
            }

        }

        private void Txt_Iter_Practico2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Iter_Practico2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Cmb_Metodos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e) //para ingresar solo numeros
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 47 && chr != 44 && chr != 45)
            {
                e.Handled = true;
            }
        }


        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("No se ha ingresado un numero de ecuaciones.");
            }
            else
            {
                int matriz = int.Parse(textBox1.Text);
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                if (matriz >= 2 && matriz <= 5)
                {
                    for (int j = 1; j <= matriz + 1; j++)
                    {
                        pointY = 40;
                        for (int i = 1; i <= matriz; i++)
                        {
                            string nombretxt = "txt" + i + j;
                            string nombrelabel = "lbl" + i + j;
                            TextBox a = new TextBox
                            {
                                AutoSize = false,
                                Size = new Size(50, 22),
                                Name = nombretxt,
                                Location = new Point(pointX, pointY)
                            };
                            panel2.Controls.Add(a);
                            Label lbl = new Label
                            {
                                Name = nombrelabel,
                                AutoSize = false,
                                Size = new Size(30, 22)
                            };
                            switch (j)
                            {
                                case 1:
                                    lbl.Text = "x  +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    break;
                                case 2:
                                    lbl.Text = "y  +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (matriz == 2)
                                    {
                                        lbl.Text = "y  =";
                                    }
                                    break;
                                case 3:
                                    lbl.Text = "z  +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (matriz == 3)
                                    {
                                        lbl.Text = "z  =";
                                    }
                                    if (matriz == 2)
                                    {
                                        lbl.Visible = false;
                                    }
                                    break;
                                case 4:
                                    lbl.Text = "u   +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (matriz == 4)
                                    {
                                        lbl.Text = "u  =";
                                    }
                                    if (matriz == 3)
                                    {
                                        lbl.Visible = false;
                                    }
                                    break;
                                case 5:
                                    lbl.Text = "v  =";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (matriz == 4)
                                    {
                                        lbl.Visible = false;
                                    }
                                    break;
                            }
                            panel2.Controls.Add(lbl);
                            panel2.Show();
                            pointY += 30;
                            a.KeyPress += new KeyPressEventHandler(TextBox1_KeyPress);
                        }
                        pointX += 90;
                    }
                    btn_Resolver.Visible = true;
                }
            }
        }


        private void Btn_Resolver_Click(object sender, EventArgs e)
        {

        }

        // SEGUNDO PRACTICO ----------------------------------------------------------------

    }
}
