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
using Logica.Unidad_2;
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
                                Size = new Size(70, 22),
                                Name = nombretxt,
                                Location = new Point(pointX, pointY)
                            };

                            if (j == matriz + 1)
                            {
                                a.BackColor = Color.LightSkyBlue;
                            }

                            panel2.Controls.Add(a);
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

        public void MostrarEnPantalla(Resultado_TP2 result)
        {
            string[] s = new string[5] { "x1 = ", "x2 = ", "x3 = ", "x4 = ", "x5 = " };
            lbl_texto.Visible = false;
            if (result.Mensaje != "")
                lbl_texto.Text = result.Mensaje;
            else
            {
                lbl_texto.Text = "El método encontró las soluciones";
            }

            lbl_texto.Font = new Font(lbl_texto.Font.Name, 10);
            panel2.Controls.Add(lbl_texto);
            int pointX = 25;
            int pointY = 225;
            for (int i = 0; i < result.Resoluciones.Length; i++)
            {
                Label lbl = new Label
                {
                    Name = "lbl_Resultado_" + i,
                    AutoSize = false,
                    Size = new Size(120, 17)
                };
                lbl.Font = new Font(lbl.Font.Name, 10);
                lbl.Location = new Point(pointX, pointY);
                lbl.Text = s[i] + Math.Round(result.Resoluciones[i], 6);
                lbl.ForeColor = Color.DarkGreen;
                panel2.Controls.Add(lbl);
                panel2.Show();
                pointX += 120;
            }
            if (result.Iteraciones != 0)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_Iteraciones";
                lbl.AutoSize = false;
                lbl.Size = new Size(200, 17);
                lbl.Font = new Font(lbl.Font.Name, 10);
                lbl.Location = new Point(25, 250);
                lbl.Text = "Cantidad de Iteraciones: " + result.Iteraciones;
                lbl.ForeColor = Color.Green;
                panel2.Controls.Add(lbl);
                panel2.Show();
            }
        }   

        private void Btn_Resolver_Click(object sender, EventArgs e)
        {

        }

        private void btn_Resolver_Click_1(object sender, EventArgs e)
        {
            int dim = int.Parse(textBox1.Text);
            bool camposvacios = false;
            for (int i=1; i<=dim + 1; i++)
            {
                for (int j = 1; j <= dim; j++)
                {
                    string nom = "txt" + j + i;
                    Control[] m = panel2.Controls.Find(nom, true);
                    if (m[0].Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Hay campos vacíos!");
                        camposvacios = true;
                    }
                }
            }
            if (!camposvacios)
            {
                string[] aux;
                double[,] matriz = new double[dim, dim + 1];
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim + 1; j++)
                    {
                        string nom = "txt";
                        int x = j + 1;
                        int y = i + 1;
                        nom = nom + y + x;
                        Control[] m = panel2.Controls.Find(nom, true);
                        if (m[0].Text.Contains("/"))
                        {
                            aux = m[0].Text.Split(new char[] { '/' }, 2);
                            matriz[i, j] = double.Parse(aux[0]) / double.Parse(aux[1]);
                        }
                        else
                        {
                            matriz[i, j] = double.Parse(m[0].Text);
                        }
                    }
                }
                Resultado_TP2 result = new Resultado_TP2(false, "", 0, 0);
                if (cmb_Metodos.SelectedIndex == 0)
                {
                    result = Practico2.GaussJordan(matriz, dim);
                }
                else
                {
                    double tole = 0.0001; //cambiar la tolerancia acá si se necesita para el eje 5
                    int ite = 100; // 2 para el ejercicio 5
                    result = Practico2.GaussSeidel(matriz, dim, ite, tole);
                }

                if (result.Ok)
                    MostrarEnPantalla(result);
                else
                {
                    MessageBox.Show(result.Mensaje);
                }

            }
        }



        // SEGUNDO PRACTICO ----------------------------------------------------------------

    }
}
