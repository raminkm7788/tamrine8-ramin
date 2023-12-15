public class cowparameter<T>
{

    public HealthParameter<T> Timetostand { get; set; }
    public HealthParameter<T> Timetodeal { get; set; }
    public HealthParameter<T> Timetorelax { get; set; }
    public HealthParameter<T> Numberof_meal { get; set; }
    public HealthParameter<T> Numberofmilk_production { get; set; }
    public DateTime Date { get; set; }
}