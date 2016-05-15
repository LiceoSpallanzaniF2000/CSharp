using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgettoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ifButton_Click(object sender, EventArgs e)
        {
            string nome = "Pippo";
            int anni = 28;

            /* 
             * a > b,
             * a < b,
             * a >= b,
             * a <= b,
             * a == b,
             * a != b <-- DIVERSO
             */

            /*
             * && <-- and
             * || <-- or
             */

            if (nome == "Giovanni" && anni == 28)
            {
                Console.WriteLine("Ciao sei Giovanni");
            }
            else if (anni == 28)
            {
                Console.WriteLine("L'età è giusta ma non sei Giovanni");
            }
            else
            {
                Console.WriteLine("Non sei Giovanni");
            }
        }
    }
}
