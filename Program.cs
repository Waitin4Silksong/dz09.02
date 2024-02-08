Console.OutputEncoding = System.Text.Encoding.UTF8;
Cat cat = new Cat("Tyson", 3, 248691, 4.2, "Cream and dark-brown", "Short", false, false, 12);
cat.info();
Console.WriteLine("");
cat.vaccination();
cat.sterilization();
cat.vaccination();
cat.sterilization();
Console.WriteLine("");
cat.info();
abstract class Animal
{
    public string name { get; set; }
    public int age { get; set; }
    public int idAnimal { get; set; }
    public double weight { get; set; }
    public int idClient { get; set; }
}
class Cat : Animal
{
    public string color { get; set; }
    public string fur { get; set; }
    public bool vacc { get; set; }
    public bool ster { get; set; }

    public Cat(string name, int age, int idAnimal, double weight, string color, string fur, bool vacc, bool ster, int idClient)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
        this.idAnimal = idAnimal;
        this.color = color;
        this.fur = fur;
        this.vacc = vacc;
        this.ster = ster;
        this.idClient = idClient;
    }

    public void info()
    {
        Console.WriteLine($"Animal name: {name}");
        Console.WriteLine($"ID: {idAnimal}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Weight: {weight}");
        Console.WriteLine($"Fur color: {color}");
        Console.WriteLine($"Fur length: {fur}");
        Console.WriteLine($"Vaccinated: {(vacc ? "Yes" : "No")}");
        Console.WriteLine($"Sterilized: {(ster ? "Yes" : "No")}");
        Console.WriteLine($"Client ID: {idClient}");
    }
    public void vaccination()
    {
        vacc = true;
        Console.WriteLine($"{name} has been vaccinated successfuly");
    }
    public void sterilization()
    {
        if (ster == true) { Console.WriteLine($"{name} is already sterilized"); }
        if (ster == false) { ster = true; Console.WriteLine($"{name} has been sterilized successfuly"); }
    }
}
