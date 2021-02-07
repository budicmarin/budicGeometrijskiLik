using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicGeometrijskiLik
{
    class GeometrijskiLik
    {
        public int BrojStranica;
        public double[] Stranice = new double[10];
        public void UcitajStranice()
        {
           
            Console.WriteLine("Upiši veličinu strica");
            for(int i = 0; i < BrojStranica; i++)
            {
                Stranice[i]= Convert.ToInt32(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double opseg=0;
            for (int i=0;i<BrojStranica;i++)
            {
                opseg = opseg + Stranice[i];
            }
            return opseg;
        }
    }
}
