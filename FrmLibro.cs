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
using System.Text.RegularExpressions;

namespace PryAriettiBiblioteca
{
    public partial class FrmLibro : Form
    {
        //Vector 

        VecLibros[] vecBiblioteca = new VecLibros[21];

        public int varIndice = 0;

        //Indice para recorrer el vector 
        int varIndiceRecorrido = 0;

        public struct VecLibros
        {
            public string varCodigoLibro;
            public string varNombre;
            public string varCodigoEditorial;
            public string varCodigoAutor;
            public string varCodigoDistribuidor;
        }


        public FrmLibro()
        {
            InitializeComponent();
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            StreamReader objLectorLibros = new StreamReader("./LIBRO.txt");
            while (!objLectorLibros.EndOfStream)
            {
                string varLibro = objLectorLibros.ReadLine();
                string[] vecLibros = varLibro.Split(',');

                for (int pos = 0; pos < vecLibros.Length; pos++)
                {
                    //En la posicion del vector lo que hace es sacar los espacios en blanco y dejar solo el texto
                    //Regex.Replace esa funcion hace que elimine los espacios en blanco
                    vecLibros[pos] = Regex.Replace(vecLibros[pos], @"\t", "");
                }


                vecBiblioteca[varIndice].varCodigoLibro = vecLibros[0];
                vecBiblioteca[varIndice].varNombre = vecLibros[1];
                vecBiblioteca[varIndice].varCodigoEditorial = vecLibros[2];
                vecBiblioteca[varIndice].varCodigoAutor = vecLibros[3];
                vecBiblioteca[varIndice].varCodigoDistribuidor = vecLibros[4];

                NombreEditorial(varIndice);
                NombreDistribuidora(varIndice);
                varIndice++;
            }
            objLectorLibros.Close();
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (varIndiceRecorrido < vecBiblioteca.Length)
            {
                txtCodigo.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombre.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtCodigoAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                txtCodigoDistribuidor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoDistribuidor;
                varIndiceRecorrido++;
            }
            if (varIndiceRecorrido == vecBiblioteca.Length)
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            varIndiceRecorrido--;
            if (varIndiceRecorrido >= 0)
            {
                txtCodigo.Text = vecBiblioteca[varIndiceRecorrido].varCodigoLibro;
                txtNombre.Text = vecBiblioteca[varIndiceRecorrido].varNombre;
                txtCodigoEditorial.Text = vecBiblioteca[varIndiceRecorrido].varCodigoEditorial;
                txtCodigoAutor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoAutor;
                txtCodigoDistribuidor.Text = vecBiblioteca[varIndiceRecorrido].varCodigoDistribuidor;
                if (varIndiceRecorrido == 0)
                {
                    cmdAtras.Enabled = false;
                }

            }
            else
            {
                cmdAtras.Enabled = false;
            }

        }

        private void NombreEditorial(int index)
        {
            StreamReader srLeerEditorial = new StreamReader("./EDITORIAL.txt");
            while (!srLeerEditorial.EndOfStream)
            {
                string[] vecEditorial = srLeerEditorial.ReadLine().Split(',');
                for (int pos = 0; pos < vecEditorial.Length; pos++)
                {
                    vecEditorial[pos] = Regex.Replace(vecEditorial[pos], @"\t", "");
                }
                if (vecEditorial[0] == vecBiblioteca[index].varCodigoEditorial)
                {
                    vecBiblioteca[index].varCodigoEditorial = vecEditorial[1];
                }
            }
            srLeerEditorial.Close();
        }

        private void NombreDistribuidora(int index)
        {
            StreamReader srLeerDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");
            while (!srLeerDistribuidora.EndOfStream)
            {
                string[] vecDistribuidora = srLeerDistribuidora.ReadLine().Split(',');
                for (int pos = 0; pos < vecDistribuidora.Length; pos++)
                {
                    vecDistribuidora[pos] = Regex.Replace(vecDistribuidora[pos], @"\t", "");
                }
                if (vecDistribuidora[0] == vecBiblioteca[index].varCodigoDistribuidor)
                {
                    vecBiblioteca[index].varCodigoDistribuidor = vecDistribuidora[1];
                }
            }
            srLeerDistribuidora.Close();
        }
    }
}
