using Logica.Unidad_1;
using Logica.Unidad_2;
using Logica.Unidad_4;
using System;
using System.Drawing;
using System.Windows.Forms;

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
                Label lbl = new Label
                {
                    Name = "lbl_Iteraciones",
                    AutoSize = false,
                    Size = new Size(200, 17)
                };
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
            for (int i = 1; i <= dim + 1; i++)
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

        // unidad 4

        private void Btn_obtener_tp4_Click(object sender, EventArgs e)
        {

        }


        private void cmb_metodos_tp4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_metodos_unidad4.Text == "Trapecio Simple" || cmb_metodos_unidad4.Text == "Simpson 1/3 Simple" || cmb_metodos_unidad4.Text == "Simpson 3/8 Simple")
            {
                lbl_n_tp4.Visible = false;
                txt_n_tp4.Visible = false;
            }
            else
            {
                lbl_n_tp4.Visible = true;
                txt_n_tp4.Visible = true;
                txt_n_tp4.BackColor = Color.White;
            }
        }

        private void Txt_a_tp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44 && chr != 45)
            {
                e.Handled = true;
                //MessageBox.Show("Solo Numeros");
            }
        }
        private void Txt_b_tp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44 && chr != 45)
            {
                e.Handled = true;
                //MessageBox.Show("Solo Numeros");
            }
        }
        private void Txt_n_tp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_funcion_TP4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 44)
            {
                e.Handled = true;
            }
        }

        public void MostrarResultadoTP4(Resultado_TP4 result)
        {
            lbl_mensaje_tp4.Visible = true;
            lbl_mensaje_tp4.Text = result.Mensaje;
            lbl_mensaje_tp4.Font = new Font(lbl_mensaje_tp4.Font.Name, 10);
            panel_tp4.Controls.Add(lbl_mensaje_tp4);
            lbl_rdo_tp4.AutoSize = false;
            lbl_rdo_tp4.Size = new Size(120, 17);
            lbl_rdo_tp4.Font = new Font(lbl_rdo_tp4.Font.Name, 10);
            //lbl_rdo_tp4.Location = new Point(pointX, pointY);
            lbl_rdo_tp4.Text = Math.Round(result.Resolucion, 5).ToString() + " V.A";//Math.Abs(Math.Round(rdos.Solucion, 5)).ToString() + " V.A";
            lbl_rdo_tp4.ForeColor = Color.Red;
            lbl_rdo_tp4.Visible = true;
            panel_tp4.Controls.Add(lbl_rdo_tp4);
            panel_tp4.Update();
            panel_tp4.Refresh();
            panel_tp4.Show();
        }

        const int max_grado = 5; //para chequear que no sea mayor a 5
        private void btn_obtener_tp4_Click_1(object sender, EventArgs e)
        {
            if (txt_funcion_TP4.Text.Trim() == string.Empty || txt_a_tp4.Text.Trim() == string.Empty || txt_b_tp4.Text.Trim() == string.Empty || ((cmb_metodos_unidad4.Text == "Trapecio Múltiple" || cmb_metodos_unidad4.Text == "Simpson 1/3 Múltiple") && txt_n_tp4.Text.Trim() == string.Empty))
            {
                if (txt_funcion_TP4.Text.Trim() == string.Empty)
                    txt_funcion_TP4.BackColor = Color.Red;
                if (txt_a_tp4.Text.Trim() == string.Empty)
                    txt_a_tp4.BackColor = Color.Red;
                if (txt_b_tp4.Text.Trim() == string.Empty)
                    txt_b_tp4.BackColor = Color.Red;
                if (txt_n_tp4.Text.Trim() == string.Empty)
                    txt_n_tp4.BackColor = Color.Red;
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            else
            {
                string funcion = txt_funcion_TP4.Text;
                double a = double.Parse(txt_a_tp4.Text);
                double b = double.Parse(txt_b_tp4.Text);
                int n = 0;
                if (txt_n_tp4.Text.Trim() != string.Empty)
                { n = int.Parse(txt_n_tp4.Text); }

                Resultado_TP4 nuevo = new Resultado_TP4(true, "");
                switch (cmb_metodos_unidad4.SelectedIndex)
                {
                    case 0:
                        nuevo = Unidad4.CalcularTrapecioSimple(funcion, a, b);
                        break;
                    case 1:
                        nuevo = Unidad4.CalcularTrapecioMultiple(a, b, funcion, n);
                        break;
                    case 2:
                        nuevo = Unidad4.CalcularSimpsonUnTercioSimple(funcion, a, b);
                        break;
                    case 3:
                        if (n % 2 != 0) //si es impar
                        {
                            double h = (b - a) / n;
                            double Xnmenos3 = b - (3 * h);
                            nuevo = Unidad4.CalcularSimpsonUnTercioMultiple(funcion, a, Xnmenos3, n - 3); //debemos hacer primero simpso1/3 multiple, y en los ultimos 3 simpson 3/8
                            Resultado_TP4 nuevo2 = Unidad4.CalcularSimpsonTresOctavos(funcion, Xnmenos3, b);
                            nuevo.Resolucion += nuevo2.Resolucion;
                        }
                        else //si es par calculamos simpson un tercio normalmente.
                        { nuevo = Unidad4.CalcularSimpsonUnTercioMultiple(funcion, a, b, n); }
                        break;
                    case 4:
                        nuevo = Unidad4.CalcularSimpsonTresOctavos(funcion, a, b);
                        break;
                }
                MostrarResultadoTP4(nuevo);
            }
        }

        public void MostrarResultadosMinimosCuadrados(Resultado_TP2 rdos)
        {
            string[] v = new string[6] { "a0 = ", "a1 = ", "a2 = ", "a3 = ", "a4 = ", "a5 = " };
            lbl_textoMC.Visible = true;
            lbl_textoMC.Text = rdos.Mensaje;
            lbl_textoMC.Font = new Font(lbl_textoMC.Font.Name, 10);
            panel3.Controls.Add(lbl_textoMC);
            int pointX = 25;
            int pointY = 55;
            if (rdos.Ok != false)
            {
                for (int i = 0; i < rdos.Resoluciones.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Name = "lbl_Resultado_" + i;
                    lbl.AutoSize = false;
                    lbl.Size = new System.Drawing.Size(85, 17);
                    lbl.Font = new Font(lbl.Font.Name, 8);
                    lbl.Location = new Point(pointX, pointY);
                    lbl.Text = v[i] + Math.Round(rdos.Resoluciones[i], 5);
                    lbl.ForeColor = Color.Red;
                    panel3.Controls.Add(lbl);
                    panel3.Show();
                    pointX += 100;
                }
                lbl_coeficiente.Text = "Coeficiente de correlación = " + rdos.Coeficiente;
                lbl_coeficiente.Visible = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = panel3.Controls.Count - 1; i >= 0; i--)
            {
                if ((panel3.Controls[i] is Label label) && (label.Name != "lbl_textoMC"))
                {
                    panel3.Controls.RemoveAt(i);
                    label.Dispose();
                }
            }

            lbl_coeficiente.Visible = false;
            panel3.Update();
            panel3.Refresh();

            double[] vectorX = new double[15];
            double[] vectorY = new double[15];

            //Vector de valores x
            int contador = -1;
            foreach (DataGridViewRow row in dgvXeY.Rows)
            {
                contador += 1;
                string codigo = Convert.ToString(row.Cells["X"].Value);
                if (codigo != "")
                { vectorX[contador] = double.Parse(codigo); }
            }
            int grad = contador - 1;
            //Vector de valores y
            contador = -1;
            foreach (DataGridViewRow row in dgvXeY.Rows)
            {
                contador += 1;
                string codigo = Convert.ToString(row.Cells["Y"].Value);
                if (codigo != "")
                { vectorY[contador] = double.Parse(codigo); }
            }

            grad = int.Parse(txt_Grado.Text);
            Resultado_TP2 res = new Resultado_TP2(true, "Ajuste no aceptable para polinomios de grado mayor a " + (max_grado), 0, 50);
            if (grad == 0)
            {
                res = Logica.Unidad_3.Unidad3.RegresionLineal(vectorX, vectorY, contador, grad + 1, max_grado);
                res.Mensaje = "Los valores son:";
            }
            else
            {
                while (grad < max_grado + 1 & (res.Coeficiente < double.Parse(txt_TP3_Tolerancia.Text)) & res.Ok == true)
                {
                    res = Logica.Unidad_3.Unidad3.RegresionLineal(vectorX, vectorY, contador, grad + 1, max_grado);  //(vectorX, vectorY, contador, grad + 1, max_grado);
                    if (res.Coeficiente >= double.Parse(txt_TP3_Tolerancia.Text))
                    { res.Mensaje = "Los valores son:"; }
                    else { grad += 1; }
                }
                if (grad == max_grado + 1)
                { res.Ok = false; }
            }

            MostrarResultadosMinimosCuadrados(res);
        }

        private void Txt_TP3_Tolerancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44) // Cambiar por el 44 por 46 para que sea un .
            {
                e.Handled = true;
            }
        }

        private void Txt_Grado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Grado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
