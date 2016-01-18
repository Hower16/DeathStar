using System;

namespace DeathStar1
{
    public class ReactorCore : IChangeTemperature
    {
        public int Temperature;
        int fuelRods;
        int fueldRodLevel;
        int controlRods;
        int controlRodLevel;
        int waterReactorLevel;

        public ReactorCore(int FuelRods, int FuelRodLevel, int ControlRods, int ControlRodLevel, int WaterReactorLevel)
        {
            fuelRods = FuelRods;
            fueldRodLevel = FuelRodLevel;
            controlRods = ControlRods;
            controlRodLevel = ControlRodLevel;
            waterReactorLevel = WaterReactorLevel;
        }

        public int CheckFuelRodLevel()
        {
            if (fueldRodLevel > 0)
            {
                return fueldRodLevel;
            }
            else
            {
                return 0;
            }
        }

        public int CoolDown()
        {
            Temperature--;
            return -1;
        }

        public int HeatUp()
        {
            Temperature++;
            return 1;
        }
    }
}