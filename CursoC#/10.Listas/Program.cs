using System;
namespace _10.Listas
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* listas */
            List<int> numeros = new List<int>();
            Random random = new Random();
            
            /* agregar elementos */
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(random.Next(10, 100));
            }

            foreach (var item in numeros)
            {
                Console.WriteLine("Item -> {0}", item);
            }

            /* eliminar elementos */
            //numeros.Remove(10); // elimina el elemento 10 de la lista
            //numeros.RemoveAt(0); // elimina el primer elemento de la lista
            //numeros.RemoveRange(0, 3); // elimina los elementos desde la posicion 0 hasta la posicion 3
            
            /* buscar elementos */
            //int posicion = numeros.IndexOf(10); // busca el elemento 10 y devuelve su posicion
            //int posicion = numeros.LastIndexOf(10); // busca el elemento 10 y devuelve su ultima posicion
            //bool existe = numeros.Contains(10); // busca el elemento 10 y devuelve true si existe o false si no existe

            /* ordenar elementos */
            //numeros.Sort(); // ordena los elementos de la lista de menor a mayor
            //numeros.Reverse(); // ordena los elementos de la lista de mayor a menor
            
            /* convertir a array */
            //int[] array = numeros.ToArray();

            /* convertir a lista */
            //List<int> lista = array.ToList();

            /* limpiar lista */
            //numeros.Clear();

            /* recorrer lista */
            //for (int i = 0; i < numeros.Count; i++)
            //{
            //    Console.WriteLine("Item -> {0}", numeros[i]);
            //}

            
        }
    }
}
