namespace DeathStar1
{
    public class HangarBay
    {
        int numberOfDoors;
        int numberOfShips;
        bool hangerDoorOpen;

        public HangarBay(int NumberOfDoors, int NumberOfShips, bool HangerDoorOpen)
        {
            numberOfDoors = NumberOfDoors;
            numberOfShips = NumberOfShips;
            hangerDoorOpen = HangerDoorOpen;
        }
        public int CheckOccupency()
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
        public bool IsDoorOpen(bool hangerDoorOpen)
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
    }
}