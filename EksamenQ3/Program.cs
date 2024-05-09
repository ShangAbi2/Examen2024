namespace EksamenQ3;

class Program
{
    static void Main(string[] args)
    {
        List<Bok> library = new List<Bok>();

        // Oppretter 5 objekter av Book-klassen (Percy Jackson-bøker)
        library.Add(new Bok("9781423103349", "The Lightning Thief", "Rick Riordan", 377));
        library.Add(new Bok("9781423101475", "The Sea of Monsters", "Rick Riordan", 279));
        library.Add(new Bok("9781423101482", "The Titan's Curse", "Rick Riordan", 312));
        library.Add(new Bok("9781423101499", "The Battle of the Labyrinth", "Rick Riordan", 361));
        library.Add(new Bok("9781423101468", "The Last Olympian", "Rick Riordan", 381));

        // Oppretter 5 objekter av EBook-klassen (Harry Potter-bøker)
        List<Ebok> ebooks = new List<Ebok>();
        ebooks.Add(new Ebok("9781781100219", "Harry Potter and the Philosopher's Stone", "J.K. Rowling", 223, 0.6));
        ebooks.Add(new Ebok("9781781100226", "Harry Potter and the Chamber of Secrets", "J.K. Rowling", 251, 0.7));
        ebooks.Add(new Ebok("9781781100233", "Harry Potter and the Prisoner of Azkaban", "J.K. Rowling", 317, 0.8));
        ebooks.Add(new Ebok("9781781100240", "Harry Potter and the Goblet of Fire", "J.K. Rowling", 636, 1.2));
        ebooks.Add(new Ebok("9781781100257", "Harry Potter and the Order of the Phoenix", "J.K. Rowling", 766, 1.4));

        // Legger til E-bok-objekter i den felles listen
        foreach (Ebok ebook in ebooks)
        {
            library.Add(ebook);
        }

        // Itererer gjennom listen og kaller GetInfo() for hvert objekt
        foreach (Bok item in library)
        {
            Console.WriteLine(item.GetInfo());
        }

        // Beregner den totale filstørrelsen
        Console.WriteLine($"\nTotal filstørrelse for alle e-bøker: {CalculateTotalFileSize(ebooks)} MB");
    }

    static double CalculateTotalFileSize(List<Ebok> ebooks)
    {
        double totalFileSize = 0;
        foreach (Ebok ebook in ebooks)
        {
            totalFileSize += ebook.FileSize;
        }
        return totalFileSize;
    }
}