using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animals
{
    public class Ave : Animal, Volador
    {
        public void Volar(){
            Console.WriteLine("El ave despega y vuela v")
        }
    }
}