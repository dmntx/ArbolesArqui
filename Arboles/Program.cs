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
            string cadena = "1+17*2";
            string salida;
            Notacion prueba = new Notacion();
            int resultado = prueba.EvaluarExpresionPostFija(cadena, out salida);
            Console.WriteLine(salida);
            Nodo raiz = arbol.Insertar("+", null);
            arbol.Insertar("2", raiz);
            arbol.Insertar("x", raiz);
            arbol.Insertar("5", raiz);
            arbol.Insertar("-", raiz);
            arbol.Insertar("4", raiz);
            arbol.Recorrido(raiz);
        }
        static public void Ecuacion()
        {
            Console.WriteLine("");
        }
    }
}
