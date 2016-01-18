namespace DeathStar1
{
    public class Refinery
    {
        public bool isOperating;
        public int RefineFuel(int RawMaterials,int FuelRequested)
        {
            isOperating = true;
            int fuel = 0;
            while(isOperating)
            {
                RawMaterials -= 2;
                fuel++;
                if(fuel==FuelRequested || RawMaterials ==0)
                {
                    isOperating = false;
                }
            }
            return fuel;
        }
        public void Exhaust()
        {
        }

    }
}