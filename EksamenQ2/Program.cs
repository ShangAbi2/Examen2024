namespace EksamenQ2;

class Program
{
    static void Main(string[] args)
    {
        // oppretter et objekt av bok-klassen:
        Bok minBok = new Bok("12345", "Pølse i vaffel", "Eivin Helstrøm", 300);
        
        // Skriver ut bokdetaljer:
        Console.WriteLine("bok informasjon før endring");
        Console.WriteLine(minBok.GetInfo());
        
        // Øker sidetallet:
        minBok.IncreasePageCount(10);
        
        // bokdetaljer etter økt sidetall:
        Console.WriteLine("bok detaljer etter økt sidetall");
        Console.WriteLine(minBok.GetInfo());
        
        // reduserer sidetallene:
        minBok.DecreasePageCount(20);
        
        // skriver bokinfo etter redusert sidetall:
        Console.WriteLine("Bokdetaljer etter redusert sideantall:");
        Console.WriteLine(minBok.GetInfo());
    }
}