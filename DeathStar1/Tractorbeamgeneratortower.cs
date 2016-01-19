namespace DeathStar1
{
    public class Tractorbeamgeneratortower
    {
        public int TractorBeamLevel;

        public Tractorbeamgeneratortower()
        {
            TractorBeamLevel = 0;
        }
        public void GenerateTractorBeam()
        {
            TractorBeamLevel++;
        }
        public void CreateForce(int power, int direction)
        {

        }
    }
}