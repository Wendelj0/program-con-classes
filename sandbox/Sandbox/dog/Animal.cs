class Animal
{
    protected string _name;

    public Animal(string name)
    {
        _name = name;

    }
    virtual public void MakeNoise()
    {
        Console.WriteLine($"{_name} The animal makes a noise.");
    }
}