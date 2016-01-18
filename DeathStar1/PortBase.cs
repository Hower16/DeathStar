namespace DeathStar1
{
    public class ExhaustPort
    {
        private readonly int Diameter;
        private readonly int Length;
        private readonly int NumberOfFans;

        public ExhaustPort()
        {

        }
        public ExhaustPort(int diameter, int length, int numberOfFans)
        {
            this.Diameter = diameter;
            this.Length = length;
            this.NumberOfFans = numberOfFans;

        }
        public bool isOpen;
        
        public virtual int ExpendExhaust(ReactorCore core)
        {
            return 0;
        }
    }
}