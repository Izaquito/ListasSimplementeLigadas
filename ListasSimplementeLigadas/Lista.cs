using System.Text;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.Siguiente = nodoNuevo;
        }

        public string ObtenerDatos()
        {
            Nodo nodoActual = _nodoInicial;
            StringBuilder datos = new StringBuilder();

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos.AppendLine(nodoActual.Dato);
            }

            return datos.ToString();
        }
    }
}
