using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            IrrigatedField irrigationField = new IrrigatedField(typeOfIrrigation.drip, 2, 5);
            Console.WriteLine(irrigationField.GetIrrigation().GetWaterToM2());
        }
    }
}
