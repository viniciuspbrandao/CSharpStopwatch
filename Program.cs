using System;

class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()

    {
        Console.Clear();
        Console.WriteLine("Preencha conforme as orientações abaixo:");
        Console.WriteLine("S = Segundos => 10s");
        Console.WriteLine("M = Minutos => 10m");
        Console.WriteLine("0s = Sair da Aplicação");
        Console.WriteLine("Quanto tempo gostaria de contar?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);
    }
    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(1000);

        Start(time);
    }
    static void Start(int time)
    {
        // int time = 10;
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("-------------------");
        Console.WriteLine("Stopwatch finished.");
        Console.WriteLine("-------------------");
        Thread.Sleep(2000);
        Menu();
    }

}