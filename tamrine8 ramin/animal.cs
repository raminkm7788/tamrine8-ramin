public abstract class Animal
{

    public Animal()
    {
        totalnumber++;
        number = totalnumber;
    }
    public double weight { get; set; }
    public bool Ismale { get; set; }
    public string name { get; set; }
    public DateTime Birthday { get; set; }
    public static int totalnumber { get; protected set; } = 0;
    public abstract int life();
    public List<Cost> costs { get; set; }
    public List<products> Products { get; set; }
    public abstract double TimeToDie();
    public abstract double KillPriority();
    public int number { get; protected set; }
    public List<environment> environments { get; set; }
    public abstract double Avrgstressfactor(environment environments);
   

}
public class products
{
    public string vahed { get; set; }
    public string Name { get; set; }
    public double gheymat { get; set; }
    public double meghdar_rozane { get; set; }

}