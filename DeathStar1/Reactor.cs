namespace DeathStar1
{
    public class Reactor
    {
        public int PowerRate { get; private set; }

        Reactor(int PowerRate)
        {
            this.PowerRate = PowerRate;
        }

        
        public int GeneratePower()
        {
            return PowerRate;
        }
    }
}