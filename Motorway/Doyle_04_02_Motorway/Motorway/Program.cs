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
            
        }
    }
}
