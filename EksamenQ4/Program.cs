using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using Oppgave4;


namespace EksamenQ4;

//Del D

class Program
{
    static void Main(string[] args)
    {
        List<IFormatable> bokListe = new List<IFormatable>
        {
            new Book("9781423103349", "The Lightning Thief", "Rick Riordan", 377),
            new Book("9781423101475", "The Sea of Monsters", "Rick Riordan", 279),
            new Book("9781423101482", "The Titan's Curse", "Rick Riordan", 312),
            new Book("9781423101499", "The Battle of the Labyrinth", "Rick Riordan", 361),
            new Book("9781423101468", "The Last Olympian", "Rick Riordan", 381),
            new Book("9780544003415", "The Fellowship of the Ring", "J.R.R. Tolkien", 432),
            new Book("9780544003521", "The Two Towers", "J.R.R. Tolkien", 352),
            new Book("9780544003415", "The Return of the King", "J.R.R. Tolkien", 432),
            new Book("9780451205766", "The Godfather", "Mario Puzo", 448),
            new Book("9780451167712", "The Sicilian", "Mario Puzo", 416)
        };

        foreach (IFormatable bok in bokListe)
        {
            Console.WriteLine(bok.ToJSON());
        }
Console.WriteLine();

        
        bool succeed = ExportToCsv(bokListe, "bokliste.csv");
        if (succeed)
        {
            Console.WriteLine("En CSV fil laget");
        }
        else
        {
            Console.WriteLine("Feil oppstod ved overføring av data til filen.");
        }

    }

    // Del C:
    // skriver til csv-fil:
    static bool ExportToCsv(List<IFormatable> formatable, string fileName)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                Console.WriteLine($"Skriver objektetene i csv format til fil: {fileName}");

                // lager en csv header:
                sw.WriteLine(formatable[0].GetCSVHeader());

                foreach (IFormatable format in formatable)
                {
                    sw.WriteLine(format.ToCSV());
                }

                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"feil: {ex.Message}");
            return false;
        }
    }

}