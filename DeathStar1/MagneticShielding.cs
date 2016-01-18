namespace DeathStar1
{
    public class MagneticShielding
    {
        public int energy = 100;

        public int Protect(int energylevel, int IncomingDMG)
        {
            int finalDMG = IncomingDMG - energylevel;
            return finalDMG;
        }


    }
}