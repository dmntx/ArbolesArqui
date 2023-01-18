using System;
using System.Collections.Generic;
using System.Text;

namespace Arboles
{
    class Arbol
    {
        private Nodo raiz;
        private Nodo trabajo;
        private int i = 0;
        public Arbol()
        {
            raiz = null;
        }
        internal Nodo Raiz { get => raiz; set => raiz = value; }

        public Nodo Insertar(string dat, Nodo NodoN)
        {
            Nodo temp = null;
            if(NodoN == null)
            {
                temp = new Nodo();
                temp.Dato = dat;
                return temp;
            }
            if(dat != NodoN.Dato)
            {
                NodoN.Izquierda = Insertar(dat, NodoN.Izquierda);
            }
            if(dat == NodoN.Dato) {
                NodoN.Derecha = Insertar(dat, NodoN.Derecha);
            }
            return NodoN;
        }
        public void Transversa(Nodo NodoN)
        {
            if(NodoN == null)
            {
                return;
            }
            for(int n= 0; n < i; n++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine(NodoN.Dato);

            if(NodoN.Izquierda != null)
            {
                i++;
                Console.Write("I ");
                Transversa(NodoN.Izquierda);
                i--;
            }
        }
    }
}
