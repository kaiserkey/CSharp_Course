namespace _6.CicloWhile
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ciclo while

            int i = 0;
            while (i < 10)
            {
                System.Console.WriteLine("Contador del While: "+i);
                i++;
            }


            do
            {
                System.Console.WriteLine("Contador del Do-While: "+i);
                i++;
            } while (i < 10);


        }
    }
}
