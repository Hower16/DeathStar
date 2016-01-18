using System;

namespace DeathStar1
{
    public class HeatExchanger: IChangeTemperature
    {
        public int Temperature;

        public void Absorbheat(IChangeTemperature part)
        {
            part.CoolDown();
            this.HeatUp();
        }
        public void Emitheat(IChangeTemperature part)
        {
            part.HeatUp();
            this.CoolDown();
        }


        public int CoolDown()
        {
            Temperature--;
            return -1;
        }

        public int HeatUp()
        {
            Temperature++;
            return 1;
        }
    }
}