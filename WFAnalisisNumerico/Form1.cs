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


        // Btn1: Método de bisección
        private void btn1_ObtenerClick_Click(object sender, EventArgs e)
        {
            if ((txt_Iter.Text.Trim() == string.Empty) || (txt_Tole.Text.Trim() == string.Empty) ||
                (txt_LI.Text.Trim() == string.Empty) || (txt_LD.Text.Trim() == string.Empty) || (txt_Funcion.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Existen Campos Vacios");
            }
            else
            {
                Result res = Ejercicio1.Biseccion(txt_Funcion.Text, int.Parse(txt_Iter.Text),
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));
                if (!res.Ok)
                {
                    MessageBox.Show(res.Mensaje);
                }
                else
                {
                    lbl_Iter_1.Text = res.Iter.ToString();
                    lbl_Tole_1.Text = res.Tole.ToString();
                    lbl_Solucion_1.Text = res.Resolucion.ToString();
                }
            }
        }
    }
}
