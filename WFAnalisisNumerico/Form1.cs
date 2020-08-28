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
    public partial class Form1 : Form
    {
        public Form1()
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
            if (!ChequearTextBoxs(sender, e))
            {
                 MessageBox.Show("Campos Vacios");
            }
            else
            {
                Resultado res = Ejercicio1.Biseccion(txt_Funcion.Text, int.Parse(txt_Iter.Text), //deje biseccion porque no tengo un txt_derivada todavia
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


    }
}
