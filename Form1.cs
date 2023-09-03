using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        private List<int> Dinamica = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_COMENZAR_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero 1"));
            int num2 = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero 2"));
            int min, max;

            if( num1 < num2)
            {
                min = num1;
                max = num2;
            }
            else
            {
                min = num2;
                max = num1;
            }

            for (int i = min; i <= max; i++)
            {
                int bandera = 0;
                for (int x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        bandera++;
                    }
                }
                if (bandera < 1)
                {
                    Dinamica.Add(i);
                }
            }

            BOX.Text = string.Join(" ", Dinamica);


        }
    }
}
