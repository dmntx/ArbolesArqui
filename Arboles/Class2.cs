﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arboles
{
    class Arbol
    {
        private Nodo raiz; //nodo raiz para inicializar el arbol
        private Nodo trabajo; //
        private int i = 0;
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
            if(dat != NodoN.Dato) //aquí voy a corregir para el tipo de operacion que se necesite xd
            {
                NodoN.Izquierda = Insertar(dat, NodoN.Izquierda);
            }
            if(dat == NodoN.Dato) { //aqui igual, pero es incersion para los hijos del nodo
                NodoN.Derecha = Insertar(dat, NodoN.Derecha);
            }
            return NodoN; //retornamos el nodoN si es que llegó a ser un hijo
        }
        public void Transversa(Nodo NodoN) //Es solo para verificar los hijos del arbol
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
