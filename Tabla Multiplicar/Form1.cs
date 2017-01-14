using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tabla_Multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CarcularBotton_Click(object sender, EventArgs e)
        {
            int contador, Tabla, Numero;
            Tabla = Convert.ToInt32(NumeroTablaTextBox.Text);
            for (contador = 0; contador <= 12; contador++)
            {
                if (Tabla == contador)

                    contador = Tabla + 1;
                Numero = Tabla * contador;
                TablaListBox.Items.Add

                    (Tabla + "*" + contador + "=" + Numero);
            }
        }
    }
}
