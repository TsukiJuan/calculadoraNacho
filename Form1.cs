using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Nacho opera
 * Integrantes: Juan David Calderon Jaramillo
 */

namespace calculadoraNacho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public Boolean estado = true;
        public double a, b, resultado;
        public string signo, A, B;
        //Cuando se escribe la operación a realizar. Ejemplo: 12 - 23, al dar clic en el boton menos, se le asignará a la variable
        // signo el valor: -. Y cuando se termine de ingresar la operación y se de clic en el boton "=", se invocara la función 
        //"Operaciones" y le llevara el signo correspondiente, para asi saber que operación realizar.
        public void Operaciones(ref string signo, ref string A, ref string B)
        {
            a = Convert.ToDouble(A);
            b = Convert.ToDouble(B);
            switch (signo)
            {
                case "+":
                    Suma(ref a, ref b);
                    break;
                case "-":
                    Resta(ref a, ref b);
                    break;
                case "*":
                    Multiplicación(ref a, ref b);
                    break;
                case "÷":
                    División(ref a, ref b);
                    break;

                default:
                    MessageBox.Show("Debes ingresar una operación completa . . .");
                    break;
            }
        }
        public void Resultado(ref double resultado)
        {
            txtDisplay.Text = resultado.ToString();
        }
        private void btnCero_Click(object sender, EventArgs e)
        {
            if(estado) 
            {
                A = A + "0";
            }
            else
            {
                B = B + "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = A;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "1";
            }
            else
            {
                B = B + "1";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "2";
            }
            else
            {
                B = B + "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "3";
            }
            else
            {
                B = B + "3";
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "4";
            }
            else
            {
                B = B + "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "5";
            }
            else
            {
                B = B + "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "6";
            }
            else
            {
                B = B + "6";
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "7";
            }
            else
            {
                B = B + "7";
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "8";
            }
            else
            {
                B = B + "8";
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "9";
            }
            else
            {
                B = B + "9";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            signo = "÷";
            estado = false;
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            signo = "*";
            estado = false;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            signo = "-";
            estado = false;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            signo = "+";
            estado = false;
        }

        private void txtShowOperation_TextChanged(object sender, EventArgs e)
        {
        }


        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            txtDisplay.Text = $"{resultado}";
        }
       

        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            Operaciones(ref signo, ref A, ref B);
            lblMathExpression.Text = $"{A} {signo} {B}";
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Suma(ref double a, ref double b)
        {
            resultado = a + b;
            Resultado(ref resultado);
        }
        public void Resta(ref double a, ref double b)
        {
            resultado = a - b;
            Resultado(ref resultado);
        }
        public void Multiplicación(ref double a, ref double b)
        {
            resultado = a * b;
            Resultado(ref resultado);
        }
        public void División(ref double a, ref double b)
        {
            resultado = a / b;
            Resultado(ref resultado);
        }
    }
}
