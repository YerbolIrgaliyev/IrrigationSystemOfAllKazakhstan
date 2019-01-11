using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    class RainIrrigation : Irrigation
    {
        public RainIrrigation(double _square, double _waterToM2)
        {
            square = _square;
            waterToM2 = _waterToM2;
            type = typeOfIrrigation.rain;
        }
    }
}
