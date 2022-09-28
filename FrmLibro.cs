using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryAriettiBiblioteca
{
    

    public partial class FrmLibro : Form
    {
        //Vector 
        string[] VecLibro = new string[21];

        //Indice para recorrer el vector 
        int indiceRecorrido = 0;
        


        public FrmLibro()
        {
            InitializeComponent();
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            StreamReader srLibro = new StreamReader("./LIBRO.txt");

            int IndiceVector = 0;

            while (!srLibro.EndOfStream)
            {
                //pasar datos a un Vector

                VecLibro[IndiceVector] = srLibro.ReadLine();

                IndiceVector++;
            }

            srLibro.Close();
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            //si el indice es menor a los espacios del vector y si es diferente de null (vacio)
            if (indiceRecorrido < VecLibro.Length && VecLibro[indiceRecorrido] != null)
            {
                // se muestran los items del vector en la listbox 
                lstMostrarLibro.Items.Add(VecLibro[indiceRecorrido]);
                // contador para q muestre todos los items 
                indiceRecorrido++;
                
            }
            else
            {
                indiceRecorrido--;
                MessageBox.Show("Llego a la ultima posicion");
                
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            indiceRecorrido--;

            if (indiceRecorrido > -1 && VecLibro[indiceRecorrido] != null)
            {
                lstMostrarLibro.Items.Add(VecLibro[indiceRecorrido]);
                
            }
            else
            {


                MessageBox.Show("Llego al primer registro");

                indiceRecorrido++;

                
            }


        }
    }
}
