using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    class Irrigation
    {
        protected double square; // Площадь
        protected double waterToM2; // Воды на м2
        protected bool isNeedWater; // Нужна ли вода
        protected typeOfIrrigation type;
        public Irrigation()
        {

        }
        public double GetSquare()
        {
            return square;
        }
        public double GetWaterToM2()
        {
            return waterToM2;
        }
        public bool GetIsNeedWater()
        {
            return isNeedWater;
        }
        public void SetSquare(double _square)
        {
            square = _square;
        }
        public void SetWaterToM2(double _waterToM2)
        {
            waterToM2 = _waterToM2;
        }

    }
}
