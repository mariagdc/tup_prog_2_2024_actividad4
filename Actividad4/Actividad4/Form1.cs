using Actividad4.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            ArrayList figuras = new ArrayList(5);
            //IFigura[] figuras = new IFigura[5];

            //figuras[0] = new Rectángulo(3,4);
            //figuras[1] = new Cuadrado(3.5);
            //figuras[2] = new Circulo(2);
            //figuras[3] = new Cuadrado(1.5);
            //figuras[4] = new Circulo(9.1);

            figuras.Add(new Rectángulo(3, 4));
            figuras.Add(new Cuadrado(3.5));
            figuras.Add(new Circulo(2));
            figuras.Add(new Cuadrado(1.5));
            figuras.Add(new Circulo(9.1));

            //foreach (int i in figuras) 
            //{
            //    figuras.Add(figuras[i]);
            //}

            foreach (IFigura i in figuras)
            {
                //textBox1.Text += $"{i.calcularPerimetro}";
            }


            //foreach (IFigura fig in figuras )
            //{
            //    double result = fig.calcularArea();

            //    textBox1.Text = $"{result}"; //fig.ToString
            //}
            figuras.Sort();
            textBox1.Text += $"\r\n Lista Ordenada\r\n";
            foreach (IFigura i in figuras)
            {
                //textBox1.Text += $"{i.Lado}{i.calcularArea}";
            }

            int idx = figuras.BinarySearch(new Cuadrado(1.5));
            if (idx >= 0)
            { 
             Cuadrado c = figuras[idx] as Cuadrado;
                textBox1.Text += $"{c.Lado}";
            }


        }
    }
}
