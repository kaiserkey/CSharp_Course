using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personas
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Persona p = new Persona("Juan", 20, "Masculino");
            p.Presentarse();
            p.Dormir();
        }
    }
}