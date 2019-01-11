using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Control
{
    enum typeOfIrrigation
    {
        drip, // Капельное
        subsurface, // Внутрипочвенное
        rain, // Дождь 
    }

    

    
   
    

    class IrrigatedField
    {
        private int undergroundSensors; // Внутрепочвенные сенсоры влажности 

        private Irrigation irrigation;

        private double waterFlow; // Общий расход воды
        private double waterIsLeft; //Сколько воды осталось

        public void SetUndergroundSensors(int _undergroundSensors)
        {
            undergroundSensors = _undergroundSensors;
        }
        public int GetUndergroundSensors()
        {
            return undergroundSensors;
        }

        public void SetWaterFlow(double _waterFlow)
        {
            waterFlow = _waterFlow;
        }
        public double GetWaterFlow()
        {
            return waterFlow;
        }

        public void SetWaterIsLeft(double _water)
        {
            waterIsLeft = _water;
        }
        public double GetWaterIsLeft()
        {
            return waterIsLeft;
        }

        public IrrigatedField(typeOfIrrigation _irrigation, double _square, double _waterToM2)
        {
            if(_irrigation == typeOfIrrigation.drip)
            {
                irrigation = new DripIrrigation(_square, _waterToM2);
            }
            else if (_irrigation == typeOfIrrigation.rain)
            {
                irrigation = new RainIrrigation(_square, _waterToM2);
            }
            else if (_irrigation == typeOfIrrigation.subsurface)
            {
                irrigation = new SubsurfaceIrrigation(_square, _waterToM2);
            }

        }
       
        public Irrigation GetIrrigation()
        {
            return irrigation;
        }
    }
}
