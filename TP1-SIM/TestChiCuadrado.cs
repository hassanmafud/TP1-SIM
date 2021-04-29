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
        bool band_Ok = false;
        public TestChiCuadrado()
        {
            InitializeComponent();
        }

        private void validarIngreso()
        {
            if(mstxtMuestra.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Tamaño de la Muestra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!rb5.Checked && !rb10.Checked && !rb15.Checked && !rb20.Checked)
            {
                MessageBox.Show("Debe Seleccionar un Intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            if (band_Ok == false)
            {
                band_Ok = true;
            }

        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            validarIngreso();
            if (band_Ok)
            {
                double[] elem = generarAleatorios(mstxtMuestra.Text);
                double media = metodoMedia(elem);
                double varianza = metodoVarianza(elem);
            }
            

           

        }
        private int cantidadIntervalos()
        {
            int num; 

            if (rb5.Checked)
            {
                num = 5;
            }
            else if (rb10.Checked)
            {
                num = 10;
            }
            else if (rb15.Checked)
            {
                num = 15;
            }
            else { 
                num = 20;
            }
            
            return num;
        }
        public void generarIntervalos()
        {
            int num = cantidadIntervalos();
            

        }
        
        private double[]  generarAleatorios(string muestra)
        {
            int n = int.Parse(muestra);
            Random rnd = new Random();
            double[] numeros = new double[n];
            Console.WriteLine("Generando "+ n + " numeros aleatorios");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Math.Round(rnd.NextDouble(), 4);
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
            media = Math.Round(suma / elem.Length,4); 

            Console.WriteLine("La Media es:"+ media);
            return media;
            
        }
        private double metodoVarianza(double[] elem)
        {
            double varianza;
            double suma = 0;
            double media = metodoMedia(elem);

            for (int i = 0; i < elem.Length; i++)
            {
                suma += Math.Pow(elem[i] - media ,2) ;
            }

            varianza = Math.Round(suma / elem.Length,4);
            Console.WriteLine("La Varianza es:" + varianza);
            return varianza;
        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
