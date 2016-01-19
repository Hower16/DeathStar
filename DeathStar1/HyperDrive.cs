namespace DeathStar1
{
    public class HyperDrive 
    {
        string destination;
        int fuelCellLevel;
        int gravityLevel;

        public HyperDrive(string Destination, int FuelCellLevel, int GravityLevel)
        {
            destination = Destination;
            fuelCellLevel = FuelCellLevel;
            gravityLevel = GravityLevel;
        }
    }
}