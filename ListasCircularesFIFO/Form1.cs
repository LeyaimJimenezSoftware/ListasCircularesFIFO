using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCircularesFIFO
{
    public partial class Form1 : Form
    {
        int cont = 0;
        static Random numeroRandom = new Random();
       
        string espera;
        CircularesFifo Fifo = new CircularesFifo();
        Procesos nuevo;
        string atendidos = "";
        int contAtendido = 0;
        int contVacio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSimular_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 200; i++)
            {
                int random = numeroRandom.Next(1, 100);
                if (random <= 25)
                {
                    int randomN = numeroRandom.Next(4, 15);
                    nuevo = new Procesos(randomN);
                    Fifo.Enqueue(nuevo);
                }
                    if (Fifo.peek() != null)
                    {
                        Fifo.restar();

                        if (Fifo.peek().proceso == 0)
                        {
                        Fifo.Denqueue(Fifo.peek());
                          contAtendido++;
                        }
                    }

                    else
                    {
                        contVacio++;
                    }

                



            }
            textBoxAtendidos.Text ="Total de procesos atendidos: "+ contAtendido + "\n Ciclos Vacios: " + contVacio + "\n Total de procesos en espera:" + Fifo.contadorEspera();
            //textBoxEspera.Text = Fifo.ToString();
            //label1.Text = "Total de procesos atendidos: " + contAtendido + " Ciclos Vacios: " + contVacio + " Total de procesos en espera" + Fifo.enEspera();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
