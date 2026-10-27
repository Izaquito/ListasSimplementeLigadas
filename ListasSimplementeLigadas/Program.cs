namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.Agregar("Elemento 1");
            lista.Agregar("Elemento 2");
            lista.Agregar("Elemento 3");
            Console.WriteLine("Datos en la lista:");
            Console.WriteLine(lista.ObtenerDatos());
            string datoABuscar = "Elemento 2";
            Nodo? nodoEncontrado = lista.Buscar(datoABuscar);
            if (nodoEncontrado != null)
            {
                Console.WriteLine($"Nodo encontrado: {nodoEncontrado.Dato}");
            }
            else
            {
                Console.WriteLine($"Nodo con dato '{datoABuscar}' no encontrado.");
            }

            string datoAEliminar = "Elemento 2";
            lista.Eliminar(datoAEliminar);
            Console.WriteLine("Datos en la lista después de eliminar:");
            Console.WriteLine(lista.ObtenerDatos());
        }
    }
}
