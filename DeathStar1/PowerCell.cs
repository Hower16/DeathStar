namespace DeathStar1
{
    public class PowerCell
    {
        int powerLevel;
        public PowerCell(int PowerLevel)
        {
            powerLevel = PowerLevel;
        }
        public void LosePower()
        {
            powerLevel--;
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