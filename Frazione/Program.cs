using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frazione frazione = new Frazione(4, 9);
            Console.WriteLine(frazione.ToString());
            string a = Console.ReadLine();
            Frazione frazione2 = Frazione.Parse(a); 
            Console.WriteLine(frazione2.ToString());
            
            Console.ReadLine();
        }
    }
}
