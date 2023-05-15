using System.Text.Json;

namespace ConsoleApp11;

internal class Program
{
    static void Main(string[] args)
    {
        Save();
        Load();
    }

    static void Load() {
        string strData = File.ReadAllText("data.json");

        var zoo = JsonSerializer.Deserialize<Zoo>(strData);
        
        Console.WriteLine( "\n" + zoo.zooName + "\t" + zoo.yearStarted);
        
        foreach (var item in zoo.animals) {
            Console.WriteLine(item.ID + "\t" + item.Name);
        }
    }

    static void Save() {
        Zoo zoo = new Zoo();
        //var options = new JsonSerializerOptions
        //{
        //    WriteIndented = true
        //};
        var strData = JsonSerializer.Serialize(zoo); //, options);
        Console.WriteLine(strData);
        File.WriteAllText("data.json", strData);
    }
}
