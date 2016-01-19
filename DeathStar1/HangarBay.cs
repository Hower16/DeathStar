namespace DeathStar1
{
    public class HangarBay
    {
        int numberOfRepairStation;
        int numberOfFuelStation;
        int numberOfShips;
        bool hangerDoorOpen;
        bool repairStationActive;
        bool fuelStationActive;

        public HangarBay(int NumberOfRepairStation, int NumberOfFuelStation, int NumberOfShips, bool HangerDoorOpen, bool RepairStationActive, bool FuelStationActive)
        {
            numberOfRepairStation = NumberOfRepairStation;
            numberOfFuelStation = NumberOfFuelStation;
            numberOfShips = NumberOfShips;
            hangerDoorOpen = HangerDoorOpen;
            repairStationActive = RepairStationActive;
            fuelStationActive = FuelStationActive;
        }
        public int CheckHangerOccupency()
        {
            if (numberOfShips > 0)
            {
                return numberOfShips;
            }
            else
            {
                return 0;
            }
        }
        public bool IsDoorOpen()
        {
            if (hangerDoorOpen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsRepairStationOccupied()
        {
            if (repairStationActive == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFuelStationOccupied()
        {
            if (fuelStationActive == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}