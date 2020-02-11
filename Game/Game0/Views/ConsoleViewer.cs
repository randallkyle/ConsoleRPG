using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0.Views
{
    abstract class ConsoleViewer
    {
        //Print a string out to console
        public static void View(string arg)
        {
            Console.WriteLine(arg);        
        }

        // iterate over a list and print to console
        public static void View(List<String> list)
        {
            foreach(string a in list)
            {
                Console.WriteLine(a);
            }
        }
    }
}
