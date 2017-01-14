using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElevarNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalacularButton_Click(object sender, EventArgs e)
        {
            double digiteNumero, digitePotencia, resultadoElevar;

            digiteNumero = Convert.ToDouble(DigiteNumerotextBox.Text);
            digitePotencia = Convert.ToDouble(DigitePotenciatextBox.Text);

            //--
            resultadoElevar = Math.Pow(digiteNumero, digitePotencia);
            ResultadotextBox.Text = string.Format("{0:f2}", resultadoElevar);
        }
    }
}
