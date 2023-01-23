using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Arboles
{
    class Program
    {
        //static string[] ecuacion = new string[20];
        static int aux;
        static int[] nums = new int[20];
        static List<string> list = new List<string>();
        static bool numero;
        static int resmas;
        static int resmen;
        static int respor;
        static string postfija = "";
        static int resdiv;
        static void Main(string[] args)
        {
            Notacion notacion = new Notacion();
            Arbol arbol = new Arbol();
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
            Console.WriteLine("\n");
            
            Ecuacion(arbol.ec, 5, 5);

        }
        static public void Ecuacion(string [] ecuacion, int x, int y)
        {
            string ec2="";
            int j = 0;
            for(int i = 0; i < ecuacion.Length; i++)
            {
                if (ecuacion[i] == "x")
                {
                    ecuacion[i] = Convert.ToString(x);
                }else if(ecuacion[i] == "y")
                {
                    ecuacion[i] = Convert.ToString(y);
                }
                ec2 += ecuacion[i];
            }
            Notacion notacion = new Notacion();
            int resultado = notacion.EvaluarExpresionPostFija(ec2 , out postfija);
            Console.WriteLine(resultado);
            
        }

    }
}
