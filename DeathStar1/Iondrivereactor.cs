namespace DeathStar1
{
    public class Iondrivereactor: Reactor
    {
        public int IonDriveRate = 4;
        public int ChargeIonDrive()
        {
            return GeneratePower() * IonDriveRate;
        }
    }
}