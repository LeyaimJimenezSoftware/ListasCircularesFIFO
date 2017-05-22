using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesFIFO
{
    class CircularesFifo
    {
        static Random numeroRandom = new Random();
       Procesos primerProceso;
        Procesos ultimo;
        Procesos Nuevo;

        Procesos temporal;

        string atendidos = "";
        int contEspera = 0;

        public CircularesFifo()
        {
            primerProceso = null;
            ultimo = null;
        }
        

        public string Atendidos()
        {
            return atendidos;
        }

        public Procesos peek()
        {
          
            return primerProceso;
        }

        public void Enqueue(Procesos nuevo)
        {

            if (primerProceso == null)
            {
                primerProceso = nuevo;
                nuevo.siguiente = primerProceso;
            }
            else
            {
                Procesos temporal = primerProceso;
                

                while (temporal.siguiente != primerProceso)
                {
                    temporal = temporal.siguiente;

                }

                temporal.siguiente = nuevo;
                nuevo.siguiente = primerProceso;

            }
        }


        //if (primerProceso == null)
        //{
        //    primerProceso = nuevo;
        //    ultimo = nuevo;
        //}
        //else
        //{
        //    ultimo.siguiente = nuevo;
        //    nuevo.anterior = ultimo;
        //    ultimo = nuevo;

        //}
       public Procesos PrimeroFantasma()
        {
            Procesos Pfantasma = primerProceso;
            return Pfantasma;
        }

        public Procesos restar()
        {

            if (primerProceso.siguiente == primerProceso)
            {
                temporal = primerProceso;

            }
            else
            {
                temporal = temporal.siguiente;
                if(temporal.proceso != 0)
                {
                    temporal.proceso--;
                }
                
            }
  
            return temporal;
      
        }

        public Procesos Denqueue(Procesos nuevo)
        {

            Procesos temporal = primerProceso;
            if (primerProceso.siguiente == primerProceso)
            {
                primerProceso = null;
            }
            else
            {
                primerProceso = primerProceso.siguiente;
            }
            return temporal;
        }

        //public int enEspera()
        //{
        //    return contEspera;
        //}

       public int contadorEspera()
        {
            string str = " ";

            Procesos t = primerProceso;

            while (t.siguiente != primerProceso)
            {
                contEspera++;
                str += t.ToString();
                t = t.siguiente;

            }
            return contEspera; ;
        }


    }
}

