public class Cost
{

    public string vahed { get; set; }
    public double meghdarrozane { get; set; }

    public double gheymat { get; set; }
    
    public override string ToString()
    {
        return $"vahed={vahed} meghdarrozane={meghdarrozane}  gheymat={gheymat}";
    }


}