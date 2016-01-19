namespace DeathStar1
{
    public class SuperLaser
    {
        int laserPowerLevel;
        int laserDamage;
        public SuperLaser(int LaserPowerLevel, int LaserDamage)
        {
            laserPowerLevel = LaserPowerLevel;
            laserDamage = LaserDamage;
        }
        public void FireLaser()
        {
            laserPowerLevel--;
            laserDamage++;
        }
    }
}