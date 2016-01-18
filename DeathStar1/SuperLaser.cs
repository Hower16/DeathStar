namespace DeathStar1
{
    public class SuperLaser
    {
        int laserPowerLevel;

        public SuperLaser(int LaserPowerLevel)
        {
            laserPowerLevel = LaserPowerLevel;
        }
        public int FireLaser()
        {
            if (laserPowerLevel > 0)
            {
                return laserPowerLevel;
            }
            else
            {
                return 0;
            }
            
        }
    }
}