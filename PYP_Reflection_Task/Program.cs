using PYP_Reflection_Task.Models;
using System.Reflection;
using System.Text.Json;

Guitar guitar = new Guitar
{
    Color = "White",
    Name = "Guitar2",
    Price = 23,
    Model = "GG",
    Fingerboard = 6,
    Size = "M"
};
Guitar guitar2 = new Guitar
{
    Color = "Black2",
    Name = "Guitar2",
    Price = 23,
    Model = "GG",
    Fingerboard = 6,
    Size = "M"
};
Piano piano = new Piano
{
    Name = "My Piano",
    Color = "Yellow",
    Keys = 82,
    Model = "Classic",
    Price = 81,
    Sounds = 12,
    Weight = 39
};
Piano piano2 = new Piano
{
    Name = "My Piano 2",
    Color = "Black",
    Keys = 41,
    Model = "Classic",
    Price = 82,
    Sounds = 6,
    Weight = 39
};
Violin violin = new Violin
{
    Color = "Black",
    Model = "Super",
    Price = 127,
    IsFuts = true,
    IsKanifol = true,
    Name = "SS"
};
Flute flute = new Flute
{
    Color = "Yellow",
    ControlerPaper = 21.1,
    Direction = "CC",
    ECC = 32.1,
    Model = "SC",
    Name = "FluteS",
    Price = 54
};

List<Instrument> lists = new();
lists.Add(violin);
lists.Add(guitar2);
lists.Add(piano);
lists.Add(piano2);
lists.Add(guitar);
lists.Add(flute);


PrintAllInstruments();
void PrintAllInstruments()
{
    foreach (var list in lists)
    {

        Console.WriteLine($"{list.GetType().BaseType?.Name} : {list.GetType().Name}");
        Console.WriteLine("Properties: ");
        foreach (var property in list.GetType().GetProperties())
        {
            Console.WriteLine($"\t {property.Name} \t {property.GetValue(list)}");
        }
        Console.WriteLine("Methods: ");
        foreach (var method in list.GetType().GetMethods
            (BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName))
        {
            Console.WriteLine($"\t {method.Name} \t {method.ReturnType}");
        }
        Console.WriteLine("");
    }
}