using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_SIM
{
    public partial class TestChiCuadrado : Form
    {
        public TestChiCuadrado()
        {
            InitializeComponent();
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            
            double [] elem = generarAleatorios(mstxtMuestra.Text);

            double media = metodoMedia(elem);
            Console.WriteLine(media);

        }


        private double[]  generarAleatorios(string muestra)
        {
            int n = int.Parse(muestra);
            Random rnd = new Random();
            double[] numeros = new double[n];
            Console.WriteLine("Generando"+n+ " numeros aleatorios");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.NextDouble();
                Console.WriteLine(numeros[i]);
                

            }

            return numeros;
        }
        private double metodoMedia(double[] elem)
        {
            double media;
            double suma = 0;
            
            for (int i = 0; i < elem.Length ; i++)
            {
                suma += elem[i];
            }
            media = suma / elem.Length;

            return media;
            
        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
