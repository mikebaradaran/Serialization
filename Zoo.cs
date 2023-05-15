using System.Text;

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
    public int zooID = 111; // will not be part of serialization process

    public List<Animal> animals { get; set; }

    public Zoo()
    {
        string[] animalNames = { "Zebra", "Lion", "Buffalo" };
        animals = new List<Animal>();
        
        int id = 100;
        foreach (var name in animalNames)
        {
            animals.Add(new Animal(id++, name));
        }
        zooName = "QA Zoo";
        yearStarted = 1985;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"Name:{zooName} start:{yearStarted}\n");
        foreach (var item in animals)
        {
            stringBuilder.Append($"{item.ID}\t{item.Name}\n");
        }
        return stringBuilder.ToString();
    }
}
