using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar1
{
    public class WaterTanks
    {
        int waterTankLevel;
        public WaterTanks(int WaterTankLevel)
        {
            waterTankLevel = WaterTankLevel;
        }

        public int CheckWaterLevel()
        {
            if (waterTankLevel > 0)
            {
                return waterTankLevel;
            }
            else
            {
                return 0;
            }
        }
    }
}
