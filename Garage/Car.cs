﻿
using System;
namespace MyGarage
{
    [Serializable]
    public class Car : Vehicle
    {
       
        
        public int CylinderCount { get; private set;  }
        public int EngineSize { get; private set;  }

        public Car(string regNum, string color, int wheelCount, int cylinderCount, int engineSize)
            : base(regNum, color, wheelCount)
        {
            CylinderCount = cylinderCount;
            EngineSize = engineSize;
        }

        public Car(Vehicle v, int cylinderCount, int engineSize)
            : base(v.RegNum, v.Color, v.WheelCount)
        {
            CylinderCount = cylinderCount;
            EngineSize = engineSize;
        }

        public Car()
        {
            
        }

        public override string ToString()
        {
            return string.Format("Bil: {0}, Cylinderantal: {1}, Motorstorlek: {2}",
                base.ToString(), CylinderCount, EngineSize);
        }

        public override bool TextSearch(string keyword)
        {
            return base.TextSearch(keyword) ||
                CylinderCount.ToString() == keyword ||
                EngineSize.ToString() == keyword;
        }
    }
}
