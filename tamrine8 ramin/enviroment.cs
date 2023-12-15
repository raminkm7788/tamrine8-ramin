public class environment
{

    public HealthParameter<int> TDS { get; set; }
    public HealthParameter<int> temp { get; set; }
    public HealthParameter<double> density { get; set; }
    public HealthParameter<double> Db { get; set; }
    public HealthParameter<int> AQI { get; set; }
    public HealthParameter<double> ox { get; set; }
    public DateTime date { get; set; }
}