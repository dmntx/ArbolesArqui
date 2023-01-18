using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            Nodo raiz = arbol.Insertar("5", null);
            arbol.Insertar("2", raiz);
            arbol.Insertar("e", raiz);
            arbol.Insertar("g", raiz);
            arbol.Insertar("3", raiz);
            arbol.Transversa(raiz);
        }
    }
}
