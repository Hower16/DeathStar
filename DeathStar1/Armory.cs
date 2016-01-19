namespace DeathStar1
{
    public class Armory
    {
        int numberOfWeapons;
        int ammo;
        
        public Armory(int NumberOfWeapons, int Ammo)
        {
            numberOfWeapons = NumberOfWeapons;
            ammo = Ammo;
        }

        public void TakeWeapons()
        {
            numberOfWeapons--;
        }
        public void TakeAmmo()
        {
            ammo--;
        }
    }
}