class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        
    }
    override public void MakeNoise()
    {
        Animal myAnimal = new Animal("Gary");
        myAnimal.MakeNoise();
        Dog myPig = new Dog($"{_name} Bacon");
        myPig.MakeNoise();
    }
    
}