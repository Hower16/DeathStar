namespace DeathStar1
{
    public class Thermalexhaustport :ExhaustPort
    {
        public override int ExpendExhaust(ReactorCore core)
        {
            core.Temperature = 0;
            return base.ExpendExhaust(core);
        }

    }
}