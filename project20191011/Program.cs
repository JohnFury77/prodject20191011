using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project20191011
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamWriter("kimenet.txt");
            sr.WriteLine("sor1");
            sr.WriteLine("sor2");
            sr.WriteLine("sor3");
        }
    }
}
