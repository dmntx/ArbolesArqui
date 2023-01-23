using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            // 5x + 2y
            Nodo raiz = arbol.Insertar("+", null);
            arbol.InsertarIzq ("*", raiz);
            arbol.InsertarIzq("5", raiz.Izquierda);
            arbol.InsertarDer("x", raiz.Izquierda);
            arbol.InsertarDer("*", raiz);
            arbol.InsertarIzq("2", raiz.Derecha);
            arbol.InsertarDer("y", raiz.Derecha);
            arbol.Recorrido(raiz);
            Console.WriteLine("\nEcuacion: ");
            arbol.RecorridoOrdenado(raiz);
        }
        static public void Ecuacion()
        {
            Console.WriteLine("");
        }
    }
}
