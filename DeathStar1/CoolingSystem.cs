namespace DeathStar1
{
    public class CoolingSystem
    {
        int OverAllTemperature;
        public void Cool(IChangeTemperature part)
        {
            OverAllTemperature += part.CoolDown();
        }
        
    }
}