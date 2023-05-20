namespace _11.Diccionarios
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* diccionarios */
            Dictionary<string, string> personas = new Dictionary<string, string>();

            /* agregar elementos */
            personas.Add("1", "Juan");
            personas.Add("2", "Pedro");
            personas.Add("3", "Maria");
            personas.Add("4", "Jose");

            /* recorrer elementos */
            foreach (var item in personas)
            {
                Console.WriteLine("Key -> {0} Value -> {1}", item.Key, item.Value);
            }

            /* eliminar elementos */
            //personas.Remove("1"); // elimina el elemento con la key 1
            //personas.RemoveRange(0, 3); // elimina los elementos desde la posicion 0 hasta la posicion 3

            /* buscar elementos */
            //string nombre = personas["1"]; // busca el elemento con la key 1 y devuelve su valor
            //string nombre = personas.ElementAt(0).Value; // busca el elemento en la posicion 0 y devuelve su valor
            //bool existe = personas.ContainsKey("1"); // busca el elemento con la key 1 y devuelve true si existe o false si no existe
            //bool existe = personas.ContainsValue("Juan"); // busca el elemento con el valor Juan y devuelve true si existe o false si no existe

            /* convertir a array */
            //string[] array = personas.ToArray();

            /* convertir a lista */
            //List<string> lista = array.ToList();

            
        }
    }
}
