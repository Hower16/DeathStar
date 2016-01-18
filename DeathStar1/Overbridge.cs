namespace DeathStar1
{
    public class Overbridge
    {
        int numberOfStairwells;
        int numberOfDutyPosts;
        bool holoDisplayPad;

        public Overbridge(int NumberOfStairwells, int NumberOfDutyPosts, bool HoloDisplayPad)
        {
            numberOfStairwells = NumberOfStairwells;
            numberOfDutyPosts = NumberOfDutyPosts;
            holoDisplayPad = HoloDisplayPad;
        }

        public bool IsDisplayPadImage()
        {
            if (holoDisplayPad == true)
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