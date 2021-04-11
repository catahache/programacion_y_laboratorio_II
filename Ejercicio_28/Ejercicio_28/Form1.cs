using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Utilizar Diccionarios (Dictionary<string, int>) para realizar un contador de palabras, recorriendo el texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador. Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra. Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.

namespace Ejercicio_28
{
    public partial class frmContador : Form
    {
        Dictionary<string, int> diccionario; // key palabra, value cant
        public frmContador()
        {
            InitializeComponent();
            this.diccionario = new Dictionary<string, int>(); // inicializo diccionario
        }

        public static void ContarPalabras(string text, Dictionary<string, int> diccionario)
        {
            string[] separators = new string[] { ",", ".", "!", "\'", " ", "\'s" };

            // Cargar diccionario:
            foreach (string word in text.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                if (diccionario.ContainsKey(word))
                {
                    int cantidad = diccionario[word]; // guardo value
                    cantidad = cantidad + 1;
                    diccionario[word] = cantidad; // incremento cant
                }
                else
                {
                    diccionario.Add(word, 1); // word es key
                }
            }

            // Sort:
            List<KeyValuePair<string, int>> dList = diccionario.ToList(); // convierto en lista
            dList.Sort(delegate (KeyValuePair<string, int> pair1, KeyValuePair<string, int> pair2)
            {
                return pair1.Value - pair2.Value;
            }); // sort

            dList.Reverse();

            diccionario = dList.ToDictionary<KeyValuePair<string, int>, string, int>(pair => pair.Key, pair => pair.Value);

            // Mostrar:
            StringBuilder sb = new StringBuilder();
            int top = 0;
            foreach (KeyValuePair<string, int> palabra in diccionario)
            {
                if(top < 3)
                {
                    sb.AppendLine($"{palabra.Key} - {palabra.Value}");
                }
                else
                {
                    break;
                }
                top++;
               
            }
            MessageBox.Show($"{sb}");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            ContarPalabras(richTxtB.Text, diccionario);
        }
    }
}
