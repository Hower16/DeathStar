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
        int uraniumAmount;
        int boronAmount;

        public ReactorCore(int FuelRods, int FuelRodLevel, int ControlRods, int ControlRodLevel, int WaterReactorLevel, int UraniumAmount, int BoronAmount)
        {
            fuelRods = FuelRods;
            fueldRodLevel = FuelRodLevel;
            controlRods = ControlRods;
            controlRodLevel = ControlRodLevel;
            waterReactorLevel = WaterReactorLevel;
            uraniumAmount = UraniumAmount;
            boronAmount = BoronAmount;
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
        public void UseUranium()
        {
            uraniumAmount--;
            fueldRodLevel++;
        }
        public void UseBoron()
        {
            boronAmount--;
            controlRodLevel++;
        }
    }
}