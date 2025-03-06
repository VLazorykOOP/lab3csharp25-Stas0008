public class OilCompany : Company
{
    private double production;

    public OilCompany(string name, double production) : base(name)
    {
        this.production = production;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Production: " + production + " barrels per hour.");
    }
}
