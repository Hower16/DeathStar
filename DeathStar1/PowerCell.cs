﻿namespace DeathStar1
{
    public class PowerCell
    {
        int powerLevel;
        public PowerCell(int PowerLevel)
        {
            powerLevel = PowerLevel;
        }
        public int CheckPowerLevel()
        {
            
            if (powerLevel > 0)
            {
                return powerLevel;
            }
            else
            {
                return 0;
            }
        }
    }
}