public class InsuranceCompany : Company
{
    private string type;

    public InsuranceCompany(string name, string type) : base(name)
    {
        this.type = type;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Type of insurance: " + type);
    }
}
