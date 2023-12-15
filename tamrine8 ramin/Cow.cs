public class COW : Animal
{

    static COW()
    {
        Maxlife = 9125;
    }
    public static int Maxlife { get; }
    public override string ToString()
    {
        return $"C{(Ismale ? 'M' : 'F')}{Birthday.Year}{Birthday.Month}{Birthday.Day} num{number}  Timetodie={TimeToDie()} killpriority={KillPriority()}";


    }
    public override int life()
    {
        int age = (int)(DateTime.Now - Birthday).TotalDays;
        return Maxlife - age;
    }
    public override double Avrgstressfactor(environment environments)
    {
        double stressfactorkol;
        stressfactorkol = environments.temp.stressFactor() + environments.TDS.stressFactor()
       + environments.density.stressFactor() + environments.Db.stressFactor()
       + environments.AQI.stressFactor() + environments.ox.stressFactor();
        return Math.Round(stressfactorkol / 6, 2);


    }
    public override double TimeToDie()
    {
        double remainlife = 0;
        remainlife = Maxlife - life();
        return remainlife;
    }
    public override double KillPriority()
    {

        double x = Maxlife - life();

        double X = Maxlife - life();
        if (x <= 1000)
            return 1;
        else if (x <= 3000 && x > 1000)
            return 0.75;
        else if (x <= 6000 && x > 3000)
            return 0.5;
        else if (x <= 8000 && x > 6000)
            return 0.25;
        else if (x <= 9125 && x > 8000)
            return 0;
        return 0;

    }


}