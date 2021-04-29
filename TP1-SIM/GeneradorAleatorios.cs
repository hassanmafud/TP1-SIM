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
    public partial class GeneradorAleatorios : Form
    {
        private bool bandOk = false;
        private bool proximo = false;
        public GeneradorAleatorios()
        {
            InitializeComponent();
        }
        // Verificamos que lo ingresado en el txt sea un numero
        private int validarVariables(string variable)
        {
            if (int.TryParse(variable, out int resultado)) {

                //verificamos que el numero es positivo
                if (resultado > 0)
                {
                    return resultado;
                }
            }

            return -1;
        }
     

        private void controlarVariables()
        {


            if (validarVariables(txtRaiz.Text) == -1)
            {
                MessageBox.Show("Error la Raiz \"X0\" debe ser entero y mayor a cero");
                return;
            }
            else if (cbMixto.Checked)
            {
                if (validarVariables(txtC.Text) == -1)
                {
                    MessageBox.Show("Error la constante \"c\" debe ser entero y mayor a cero");
                    return;

                }
            }


            if (txtK.Text == "" && txtA.Text == "")
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES A O K OBLIGATORIAMENTE");
                return;

            }
            else if (txtK.Text == "")
            {
                if (validarVariables(txtA.Text) == -1)
                {
                    MessageBox.Show("Error la constante \"a\" debe ser entero y mayor a cero");
                    return;
                }
            }
            else if (txtA.Text == "")
            {
                if (validarVariables(txtK.Text) == -1)
                {
                    MessageBox.Show("Error el numero \"k\" debe ser entero y mayor a cero");
                    return;
                }

            }

            if (txtM.Text == "" && txtG.Text == "")
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES M O G OBLIGATORIAMENTE");
                return;

            }
            else if (txtM.Text == "")
            {
                if (validarVariables(txtG.Text) == -1)
                {
                    MessageBox.Show("Error el numero \"g\" debe ser entero y mayor a cero");
                    return;
                }

            }
            else if (txtG.Text == "")
            {
                if (validarVariables(txtM.Text) == -1)
                {
                    MessageBox.Show("Error el modulo \"m\" debe ser entero y mayor a cero");
                    return;
                }


            }
            //Cuando Todos los valores de las variables de entrada sean correctos pongo la bandera en True
            if (bandOk == false)
            {
                bandOk = true;

            }
        }

        private List<int> generarMixto()
        {
            if (cbMixto.Checked && txtC.Text != "")
            {
                int x = int.Parse(txtRaiz.Text);
                int c = int.Parse(txtC.Text);

                int a = 0;
                int m = 0;
                int k = 0;
                int g = 0;


                if ((txtK.Text == "" && txtA.Text == "") || (txtM.Text == "" && txtG.Text == ""))
                {
                    controlarVariables();
                    return null;
                }
                else
                {
                    if (txtK.Text != "" && txtA.Text != "")
                    {
                        a = int.Parse(txtA.Text);
                        k = int.Parse(txtK.Text);
                    }
                    else if (txtK.Text == "")
                    {
                        a = int.Parse(txtA.Text);

                    }
                    else if (txtA.Text == "")
                    {
                        k = int.Parse(txtK.Text);
                        a = 1 + 4 * k;
                    }


                    if (txtM.Text != "" && txtG.Text != "")
                    {
                        g = int.Parse(txtG.Text);
                        m = int.Parse(txtM.Text);
                    }
                    else if (txtG.Text == "")
                    {
                        m = int.Parse(txtM.Text);
                    }

                    else if (txtM.Text == "")
                    {
                        g = int.Parse(txtG.Text);
                        m = (int)Math.Pow(2, g);
                    }



                    List<int> elementos = new List<int>();
                    elementos.Add(x);
                    elementos.Add(a);
                    elementos.Add(c);
                    elementos.Add(m);
                    elementos.Add(k);
                    elementos.Add(g);

                    return elementos;
                }
            }
            else
            {
                return null;
            }

        }
        private List<int> generarMultiplicativo()
        {

            int x = int.Parse(txtRaiz.Text);

            int c = 0;
            int a = 0;
            int m = 0;
            int k = 0;
            int g = 0;


            if ((txtK.Text == "" && txtA.Text == "") || (txtM.Text == "" && txtG.Text == ""))
            {
                controlarVariables();
                return null;
            }
            else
            {
                if (txtK.Text != "" && txtA.Text != "")
                {
                    a = int.Parse(txtA.Text);
                    k = int.Parse(txtK.Text);
                }
                else if (txtK.Text == "")
                {
                    a = int.Parse(txtA.Text);

                }
                else if (txtA.Text == "")
                {
                    k = int.Parse(txtK.Text);
                    a = 3 + 8 * k;
                }


                if (txtM.Text != "" && txtG.Text != "")
                {
                    g = int.Parse(txtG.Text);
                    m = int.Parse(txtM.Text);
                }
                else if (txtG.Text == "")
                {
                    m = int.Parse(txtM.Text);
                }

                else if (txtM.Text == "")
                {
                    g = int.Parse(txtG.Text);
                    m = (int)Math.Pow(2, g);
                }



                List<int> elementos = new List<int>();
                elementos.Add(x);
                elementos.Add(a);
                elementos.Add(c);
                elementos.Add(m);
                elementos.Add(k);
                elementos.Add(g);

                return elementos;
            }

        }

        private void validarMetodo()
        {
            if (bandOk == true)
            {
                //Verifico que el metodo seleccionado se solo el Mixto
                if (cbMixto.Checked && !cbMultiplicativo.Checked)
                {
                    var elementos = generarMixto();
                    if (elementos != null)
                    {
                        cargarTabla(elementos);
                    }

                    return;
                }
                //Verifico que el metodo seleccionado se solo el Multiplicativo
                else if (!cbMixto.Checked && cbMultiplicativo.Checked)
                {
                    int x = int.Parse(txtRaiz.Text);
                    if (x % 2 == 0)
                    {
                        MessageBox.Show("La raiz debe ser un numero Impar");
                        return;
                    }
                    else{
                        var elementos = generarMultiplicativo();
                        if (elementos != null)
                        {
                            cargarTabla(elementos);
                        }

                        
                    }
                  
                }
                else
                {
                    MessageBox.Show("ERROR SE DEBE SELECCIONAR UN SOLO METODO !!! ");
                    return;

                }

            }
        }
        //Este metodo genera los 20 numeros 
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            controlarVariables();
            validarMetodo();

        }
        
       
        private void cargarTabla(List<int> elements )
        {
            int x = elements[0];
            int a = elements[1];
            int c = elements[2];
            int m = elements[3];
            int k = elements[4];
            int g = elements[5];

            double axc;
            double resto = 0;
            double rnd;
            int vueltas = 20;
           

            if(proximo == true)
            {
                vueltas = dgvTabla.Rows.Count;
                dgvTabla.Rows.Clear();
                proximo = false;
            }

            for (int i = 1; i <= vueltas; i++)
            {
                if(i==1)
                {
                    
                    axc = a * x + c;
                    resto = axc % m;
                    rnd = resto / m;
                    //rnd = resto / (m-1);
                }
                else
                {
                    axc = a * resto + c;
                    resto = axc % m;
                    rnd = resto / m;
                    //rnd = resto / (m-1);
                }


                dgvTabla.Rows.Add(i,rnd);
                
            }
            



        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRaiz.Clear();
            txtA.Clear();
            txtC.Clear();
            txtG.Clear();
            txtK.Clear();
            txtM.Clear();
            dgvTabla.Rows.Clear();
           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            proximo = true;
            validarMetodo();
            
        }
    }
}
