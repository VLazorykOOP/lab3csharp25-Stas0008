public class Factory : Company
{
    private string type;

    public Factory(string name, string type) : base(name)
    {
        this.type = type;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Type of factory: " + type);
    }
}
