public class HealthParameter<T>
{

    public string Name { get; set; }
    public T standard { get; set; }
    public double zarib { get; set; }
    public T current { get; set; }
 
    public double stressFactor()
    {
        double rezult = (Convert.ToDouble(current) / Convert.ToDouble(standard)) * zarib;
        return Math.Round(rezult, 2);
    }
    public override string ToString()
    {
        return $"Name of parametr={standard}  current={current}  standard={standard}";
    }
}