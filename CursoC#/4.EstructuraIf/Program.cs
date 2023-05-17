namespace _4.EstructuraIf
{
    class Program
    {
        public static void Main(string[] args)
        {
            //estructura de control if-else
            Console.WriteLine("Ingrese el valor de a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("a es mayor que b");
            }else if(a < b)
            {
                Console.WriteLine("a es menor que b");
            }else
            {
                Console.WriteLine("a es igual a b");
            }
        }
    }
}
