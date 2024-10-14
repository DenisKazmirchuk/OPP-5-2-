class Program
{
    static void Main(string[] args)
    {
        IZarplata robitnykZarplata = new Robitnyk("Іван", 5, 100);
        IRole robitnykRole = new Robitnyk("Іван", 5, 100);

        IZarplata inzhenerZarplata = new Inzhener("Олександр", 10, 3000);
        IRole inzhenerRole = new Inzhener("Олександр", 10, 3000);

        Console.WriteLine($"{robitnykRole.Role()} заробляє {robitnykZarplata.Zarplata()}");
        Console.WriteLine($"{inzhenerRole.Role()} заробляє {inzhenerZarplata.Zarplata()}");
    }
}
