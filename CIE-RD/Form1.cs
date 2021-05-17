using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIE_RD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string CIE = txtCIE.Text;
            bool Resultado = ValidarCedula(CIE);
            if (Resultado == true)
            {
                lblResultado.Text = "VALIDA!";
                lblResultado.ForeColor = Color.Blue;
            }
            else
            {
                lblResultado.Text = "NO VALIDA!";
                lblResultado.ForeColor = Color.Red;
            }
                
        }
        public bool ValidarCedula(string cedula)
        {
            int digito = 0;
            int digitoVerificador = 0;
            bool resultado = false;
            int[] multiplicadores = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int producto = 0;
            int suma = 0;

            if (cedula.Contains("-"))
                cedula = cedula.Replace("-", "");

            _ = int.TryParse(cedula.Substring(cedula.Length - 1), out digitoVerificador);

            for (int i = 0; i < (cedula.Length - 1); i++)
            {
                _ = int.TryParse(cedula[i].ToString(), out digito);
                producto = digito * multiplicadores[i];

                if (producto >= 10)
                    producto = (producto / 10) + (producto % 10);

                suma += producto;
            }

            if ((suma + digitoVerificador) % 10 == 0)
                resultado = true;

            return resultado;
        }
    }
}
