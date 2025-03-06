public abstract class Company {
    private String name;

    public Company(String name) {
        this.name = name;
    }
    public virtual void Show() {
        Console.WriteLine("Company name: " + name);
    }
}