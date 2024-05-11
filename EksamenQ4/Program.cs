using System.Text;
namespace EksamenQ4;

class Program
{
    static void Main(string[] args)
    {
        // Oppretter 10 Book-objekter med ulike attributter
        List<IFormatable> books = new List<IFormatable>
        {
            new Bok("9781423103349", "The Lightning Thief", "Rick Riordan", 377),
            new Bok("9781423101475", "The Sea of Monsters", "Rick Riordan", 279),
            new Bok("9781423101482", "The Titan's Curse", "Rick Riordan", 312),
            new Bok("9781423101499", "The Battle of the Labyrinth", "Rick Riordan", 361),
            new Bok("9781423101468", "The Last Olympian", "Rick Riordan", 381),
            new Bok("9780544003415", "The Fellowship of the Ring", "J.R.R. Tolkien", 432),
            new Bok("9780544003521", "The Two Towers", "J.R.R. Tolkien", 352),
            new Bok("9780544003415", "The Return of the King", "J.R.R. Tolkien", 432),
            new Bok("9780451205766", "The Godfather", "Mario Puzo", 448),
            new Bok("9780451167712", "The Sicilian", "Mario Puzo", 416)
        };

        // Eksporter til CSV-fil
        ExportToCSV(books, "books.csv");
    }

    static bool ExportToCSV(List<IFormatable> data, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                foreach (IFormatable item in data)
                {
                    writer.WriteLine(item.ToCSV());
                }
            }
            Console.WriteLine($"Dataene ble eksportert til {fileName}.");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under eksport til CSV-fil: {ex.Message}");
            return false;
        }
    }
}