namespace DeathStar1
{
    public class Hypermatterreactor : Reactor
    {
        public int HyperMatterRate = 2;
        public int GenerateHyperMatter()
        {
            return GeneratePower()*HyperMatterRate;
        }
    }
}