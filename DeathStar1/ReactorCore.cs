namespace DeathStar1
{
    public class ReactorCore
    {
        internal int Temperature;
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
        public int ControlRodLevel()
        {
            if (controlRodLevel > 0)
            {
                return controlRodLevel;
            }
            else
            {
                return 0;
            }
        }
        public int WaterReactorRodLevel()
        {
            if (waterReactorLevel > 0)
            {
                return waterReactorLevel;
            }
            else
            {
                return 0;
            }
        }
    }
}