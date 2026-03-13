class Pig : Animal
{
    public Pig(string name) : base(name)
    {
        
    }
    override public void MakeNoise()
    {
        Animal myAnimal = new Animal("Gary");
        myAnimal.MakeNoise();
        Pig myPig = new Pig($"{_name} Bacon");
        myPig.MakeNoise();
    }
    
}