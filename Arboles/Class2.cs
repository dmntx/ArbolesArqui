using System;
using System.Collections.Generic;
using System.Text;

namespace Arboles
{
    class Arbol
    {
        private Nodo raiz; //nodo raiz para inicializar el arbol
        private Nodo trabajo; //
        private int i = 0;
        private int j = 0;
        public string[] ec = new string[20];
        public string ec2;
        public Arbol()
        {
            raiz = null;
        }
        internal Nodo Raiz { get => raiz; set => raiz = value; }

        public Nodo Insertar(string dat, Nodo NodoN)
        {
            Nodo temp = null; //nodo auxiliar
            if(NodoN == null) //Si el nodo que le pasamos aún no se inicializa
            {
                temp = new Nodo(); //inicializamos el nodo temporal
                temp.Dato = dat; //le asignamos el dato que queremos agregar al nodo temporal
                return temp; //retornamos el nodo temporal
            }
            else
            {
                return NodoN;
            }
        }

        public Nodo InsertarIzq(string dat, Nodo NodoN)
        {
            Nodo temp = null; 
            if(NodoN.Izquierda == null)
            {
                temp = new Nodo();
                temp.Dato = dat;
                NodoN.Izquierda = temp;
            }
            else {
                NodoN.Izquierda = InsertarIzq(dat, NodoN.Izquierda);
            }
            return temp ;
        }
        public Nodo InsertarDer(string dat, Nodo NodoN)
        {
            Nodo temp = null;
            if (NodoN.Derecha == null)
            {
                temp = new Nodo();
                temp.Dato = dat;
                NodoN.Derecha = temp;
            }
            else
            {
                NodoN.Derecha = InsertarDer(dat, NodoN.Derecha);
            }
            return temp;
        }
        public void Recorrido(Nodo NodoN) //Es solo para verificar los hijos del arbol
        {
            if(NodoN == null)
            {
                return;
            }
            for(int n= 0; n < i; n++)
            {
                Console.Write("   ");
            }
            Console.Write(NodoN.Dato);

            if(NodoN.Izquierda != null)
            {
                i++;
                Console.Write("\n   Hijo izquierda\n  ");
                Recorrido(NodoN.Izquierda);
                i--;
            }

            if(NodoN.Derecha != null)
            {
                i++;
                Console.Write("\n   Hijo Derecha\n   ");
                Recorrido(NodoN.Derecha);
                i--;
            }
        }
        
        public void RecorridoOrdenado(Nodo NodoN)
        {
            if (NodoN == null)
            {
                return ;
            }
            if (NodoN.Izquierda != null)
            {
                i++;
                RecorridoOrdenado(NodoN.Izquierda);
                i--;
            }
            Console.Write("{0}", NodoN.Dato);
            ec[j] = NodoN.Dato;
            j++;
            ec2 += NodoN.Dato;
            if (NodoN.Derecha != null)
            {
                i++;
                RecorridoOrdenado(NodoN.Derecha);
                i--;
            }
        }
    }
}
