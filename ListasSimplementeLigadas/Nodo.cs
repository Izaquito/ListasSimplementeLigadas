using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplementeLigadas
{
    internal class Nodo
    {
        public string Dato { get; set; }
        public Nodo? Siguiente { get; set; }
        public Nodo(string dato = "", Nodo? siguiente = null)
        {
            Dato = dato;
            Siguiente = siguiente;
        }
    }
}
