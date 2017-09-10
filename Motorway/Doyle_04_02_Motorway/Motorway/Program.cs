using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doyle_04_02_Motorway
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorway1 = new Motorway("Motorway1", "Highway", 'S', "Asphalt", 3, false, "Maintenance Company");
            Console.WriteLine(motorway1+"\n");

            var motorway2 = new Motorway("Motorway2", true);
            Console.WriteLine(motorway2 + "\n");

            var motorway3 = new Motorway("Motorway3");
            Console.WriteLine(motorway3 + "\n");

            var motorway4 = new Motorway("Motorway4", 2);
            Console.WriteLine(motorway4 + "\n");

            Console.ReadLine();

        }
    }
}
