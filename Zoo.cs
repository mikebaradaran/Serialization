namespace ConsoleApp11;

public class Animal
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Animal(int iD, string name)
    {
        ID = iD;
        Name = name;
    }
        
}
public class Zoo
{
    public int yearStarted { get; set; }
    public string zooName { get; set; }

    private List<string> animalNames = new List<string>() { "Zebra", "Lion", "Buffalo" };

    public List<Animal> animals { get; set; }

    public Zoo()
    {
        animals = new List<Animal>();
        int id = 100;
        foreach (var name in animalNames)
        {
            animals.Add(new Animal(id++, name));
        }
        zooName = "QA Zoo";
        yearStarted = 1985;
    }
}
