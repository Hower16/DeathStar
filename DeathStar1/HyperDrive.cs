namespace DeathStar1
{
    public class HyperDrive 
    {
        string destination;
        int fuelCellLevel;
        int gravityLevel;
        bool hyperDriveExecution;

        public HyperDrive(string Destination, int FuelCellLevel, int GravityLevel, bool HyperDriveExecution)
        {
            destination = Destination;
            fuelCellLevel = FuelCellLevel;
            gravityLevel = GravityLevel;
            hyperDriveExecution = HyperDriveExecution;
        }
        public bool IsHyperDriveExecuted()
        {
            if (hyperDriveExecution == true)
            {
                return hyperDriveExecution;
            }
            else
            {
                return false;
            }
        }
        public void UseHyperDrive()
        {
            if (gravityLevel > 0)
            {
                fuelCellLevel--;
            }
        }
    }
}