using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloUnidimensional
{
    public partial class Form1 : Form
    {
        // Declarar el arreglo
        int[] arreglo = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            // Generar valores aleatorios para el arreglo
            Random rnd = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(1, 101);
            }

            MessageBox.Show("El arreglo se ha generado correctamente.", "Generar arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            // Mostrar los valores del arreglo en el ListBox
            lstValores.Items.Clear();
            for (int i = 0; i < arreglo.Length; i++)
            {
                lstValores.Items.Add("Elemento " + i + ": " + arreglo[i]);
            }

            // Mostrar la cantidad de elementos del arreglo
            lblCantidad.Text = "Cantidad de elementos: " + arreglo.Length;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            // Buscar un valor en el arreglo
            int valorBuscado = int.Parse(txtValor.Text);
            int indiceEncontrado = -1;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valorBuscado)
                {
                    indiceEncontrado = i;
                    break;
                }
            }

            if (indiceEncontrado != -1)
            {
                MessageBox.Show("El valor " + valorBuscado + " se encuentra en el índice " + indiceEncontrado + ".", "Buscar valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El valor " + valorBuscado + " no se encuentra en el arreglo.", "Buscar valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            // Ordenar el arreglo de forma ascendente
            Array.Sort(arreglo);

            MessageBox.Show("El arreglo se ha ordenado correctamente.", "Ordenar arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

