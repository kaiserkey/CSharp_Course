namespace _8.Arreglos
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Arreglos */
            int[] arreglo = new int[5];

            for(int i = 0; i<arreglo.Length; i++){
                arreglo[i] = i*2;
            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("El arreglo en el indice {0} tiene el elemento {1}", i, arreglo[i]);
            }

            /* foreach */
            foreach (int i in arreglo)
            {
                Console.WriteLine("El elemento es {0}", i);
            }
        }
    }
}
