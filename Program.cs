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
        Console.WriteLine(zoo);
    }

    static void Save() {
        Zoo zoo = new Zoo();
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        var strData = JsonSerializer.Serialize(zoo, options); //, options);
        Console.WriteLine(strData);
        File.WriteAllText("data.json", strData);
    }
}
