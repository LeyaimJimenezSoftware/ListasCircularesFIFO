using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesFIFO
{
    class Procesos
    {
        private int _proceso;
        private Procesos _siguiente;
        private Procesos _anterior;

        public Procesos(int proceso)
        {
            this.proceso = proceso;
        }
        public int proceso
        {
            get
            {
                return _proceso;
            }
            set
            {
                _proceso = value;
            }

        }
        public Procesos siguiente
        {

            get
            {
                return _siguiente;
            }
            set
            {
                _siguiente = value;
            }

        }
        public Procesos anterior
        {

            get
            {
                return _anterior;
            }
            set
            {
                _anterior = value;
            }

        }

        public override string ToString()
        {
            return "Proceso:" + _proceso.ToString() + " " + "\r\n" + "\r\n";
        }

    }
}

