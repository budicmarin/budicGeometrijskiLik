using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicGeometrijskiLik
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            trokut.UcitajStranice();
            double opsegTrokut = trokut.Opseg();
            Cetverokut cetverokut=new Cetverokut();
            cetverokut.UcitajStranice();
            double opsegCetverokut = cetverokut.Opseg();
            onsole.WriteLine("Opseg trokuta je: " + opsegTrokut);
            Console.WriteLine("Opseg četverokuta je: "+opsegCetverokut);
        }
    }
}
