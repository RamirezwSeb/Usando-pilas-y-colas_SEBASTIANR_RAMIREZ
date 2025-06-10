using Microsoft.VisualBasic;

namespace Usando_pilas_y_colas_SEBASTIANR_RAMIREZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<int> pila = new Stack<int>();
        Queue<int> cola = new Queue<int>();
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            pila.Clear();
            cola.Clear();
            lstPila.Items.Clear();
            lstCola.Items.Clear();

            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese valor #{i + 1}:", "Entrada de datos");
                    if (int.TryParse(input, out int valor))
                    {
                        pila.Push(valor);
                        cola.Enqueue(valor);
                    }
                }

                MostrarPila();
                MostrarCola();
            }
        }

        private void MostrarPila()
        {
            lstPila.Items.Clear();
            foreach (int num in pila)
                lstPila.Items.Add(num);
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            foreach (int num in cola)
                lstCola.Items.Add(num);
        }

        private void btnEliminarValor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEliminarValor.Text, out int valorEliminar))
            {
                Stack<int> nuevaPila = new Stack<int>();
                bool encontradoPila = false;

                while (pila.Count > 0)
                {
                    int actual = pila.Pop();
                    if (actual == valorEliminar && !encontradoPila)
                    {
                        encontradoPila = true;
                        continue;
                    }
                    nuevaPila.Push(actual);
                }

                pila.Clear();
                while (nuevaPila.Count > 0)
                    pila.Push(nuevaPila.Pop());

                if (!encontradoPila)
                    MessageBox.Show("Valor no encontrado en la pila.");
                MostrarPila();

                Queue<int> nuevaCola = new Queue<int>();
                bool encontradoCola = false;

                while (cola.Count > 0)
                {
                    int actual = cola.Dequeue();
                    if (actual == valorEliminar && !encontradoCola)
                    {
                        encontradoCola = true;
                        continue;
                    }
                    nuevaCola.Enqueue(actual);
                }

                cola = nuevaCola;

                if (!encontradoCola)
                    MessageBox.Show("Valor no encontrado en la cola.");
                MostrarCola();
            }
        }

   
      

        }
    }
