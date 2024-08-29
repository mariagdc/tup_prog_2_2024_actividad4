﻿using Actividad4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Figura[] figuras = new Figura[5];

            figuras[0] = new Rectángulo(3,4);
            figuras[1] = new Cuadrado(3.5);
            figuras[2] = new Circulo(2);
            figuras[3] = new Cuadrado(1.5);
            figuras[4] = new Circulo(9.1);

            foreach (Figura fig in figuras )
            {
                double result = fig.calcularArea();

                listBox1.Text = $"{result}"; //fig.ToString
            }

        }
    }
}
