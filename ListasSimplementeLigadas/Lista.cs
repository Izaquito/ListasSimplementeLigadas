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

        public Nodo? Buscar(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                if (nodoActual.Dato == dato)
                {
                    return nodoActual;
                }
            }
            return null;
        }

        private Nodo? BuscarAnterior(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                if (nodoActual.Siguiente.Dato == dato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Siguiente;
            }
            return null;
        }

        public void Eliminar(string dato)
        {
            Nodo? nodoEliminar = Buscar(dato);
            if (nodoEliminar != null)
            {
                Nodo? nodoAnterior = BuscarAnterior(dato);
                if (nodoAnterior != null)
                {
                    nodoAnterior.Siguiente = nodoEliminar.Siguiente;
                    nodoEliminar.Siguiente = null;
                }
            }
        }
    }
}
