using System;
using System.Collections.Generic;
using System.Text;

namespace Arboles
{
    class Nodo
    {
        private string dato; //Datos del nodo
        private Nodo izq;
        private Nodo der;

        public string Dato { get => dato; set=> dato = value; }
        public Nodo Izquierda { get =>izq; set=> izq = value; }

        public Nodo Derecha { get => der; set => der = value; }
        public Nodo()
        {
            dato = "0";
            izq = null;
            der = null;
            }
    }
}
