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
 * Integrantes: Juan David Calderon Jaramillo, Camilo Orozco Isaza
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
        public bool isclicked = false;
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
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "0";
                lblMathExpression.Text = B;
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
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "1";
                lblMathExpression.Text = B;
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "2";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "2";
                lblMathExpression.Text = B;
            }
        }

        public void btnTres_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "3";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "3";
                lblMathExpression.Text = B;
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "4";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "4";
                lblMathExpression.Text = B;
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "5";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "5";
                lblMathExpression.Text = B;
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "6";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "6";
                lblMathExpression.Text = B;
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "7";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "7";
                lblMathExpression.Text = B;
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "8";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "8";
                lblMathExpression.Text = B;
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                A = A + "9";
                lblMathExpression.Text = A;
            }
            else
            {
                B = B + "9";
                lblMathExpression.Text = B;
            }
        }

        private void UpdateMathExpression(string text)
        {
            if (estado)
            {
                lblMathExpression.Text = A + text;
            }
            else
            {
                lblMathExpression.Text = A +" " + signo  + " " + B;
            }
        }

        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(B))
            {
                Operaciones(ref signo, ref A, ref B);
                lblMathExpression.Text += $" {signo} {B} = {resultado}"; // Agregamos la operación y el resultado a la expresión actual

                // Actualizamos el primer operando con el resultado y limpiamos el segundo operando y el signo
                A = resultado.ToString();
                B = "";
                signo = "";

                estado = false; // Cambiamos al segundo operando (B)
            }
            else
            {
                // Si no hay un segundo operando, mostramos solo el primer operando en la expresión
                lblMathExpression.Text = A;
            }
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(A))
            {
                if (!string.IsNullOrEmpty(B)) 
                {
                    Operaciones(ref signo, ref A, ref B);
                    lblMathExpression.Text = resultado.ToString();
                }
                else
                {
                    lblMathExpression.Text = A;
                }

                
                B = "";
                signo = "+";

                estado = false; 
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(A))
            {
                if (!string.IsNullOrEmpty(B))
                {
                    Operaciones(ref signo, ref A, ref B);
                    lblMathExpression.Text = resultado.ToString();
                }
                else
                {
                    lblMathExpression.Text = A;
                }

                
                B = "";
                signo = "-";

                estado = false; 
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(A))
            {
                if (!string.IsNullOrEmpty(B)) 
                {
                    Operaciones(ref signo, ref A, ref B);
                    lblMathExpression.Text = resultado.ToString();
                }
                else
                {
                    lblMathExpression.Text = A;
                }

      
                B = "";
                signo = "*";

                estado = false; 
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(A))
            {
                if (!string.IsNullOrEmpty(B)) 
                {
                    Operaciones(ref signo, ref A, ref B);
                    lblMathExpression.Text = resultado.ToString();
                }
                else
                {
                    lblMathExpression.Text = A;
                }

                
                B = "";
                signo = "÷";

                estado = false; 
            }
        }
        public void btnClearText_Click(object sender, EventArgs e)
        {

            A = "";
            B = "";
            signo = "";
            estado = true;
            lblMathExpression.Text = "0";
            isclicked = true;
            txtDisplay.Text = "0";
        }

        public void txtDisplay_TextChanged(object sender, EventArgs e)
        {
       
            if (isclicked == true)
            {
                txtDisplay.Text = "0";
                isclicked = false;
            }
            else
            {
                txtDisplay.Text = $"{resultado}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                if (!string.IsNullOrEmpty(A))
                {
                    A = A.Substring(0, A.Length - 1);
                    lblMathExpression.Text = A;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(B))
                {
                    B = B.Substring(0, B.Length - 1);
                    lblMathExpression.Text = $"{A} {signo} {B}";
                }
                else
                {
                    estado = true;
                    lblMathExpression.Text = A;
                }
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(A) && !string.IsNullOrEmpty(B))
            {
                double porcentaje = (Convert.ToDouble(B) * 100) / Convert.ToDouble(A);
                lblMathExpression.Text += $" {porcentaje}%"; // Agregamos el porcentaje a la expresión actual

                // Limpiamos los operadores y cambiamos al segundo operando (B)
                A = "";
                B = "";
                signo = "";
                estado = false;
            }
        }

        private void lblMathExpression_Click(object sender, EventArgs e)
        {


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
