using Oppgave4;

namespace EksamenQ4;
using CsvHelper.Configuration.Attributes;
public class Book : IFormatable
{
    private int _pageCount;
    [Index(0)]
    public string ISBN { get; init; }
    [Index(1)]
    public string Title { get; set; }
    [Index(2)]
    public string Author { get; set; }
    [Index(3)]
    public int PageNumber
    {
        get
        {
            return _pageCount;
        }
    }

    public Book(string isbn, string title, string author, int pageCount)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        _pageCount = pageCount;
    }

    public string ToCSV()
    {
        return $"{ISBN},{Title},{Author},{PageNumber}";
    }

    public string ToJSON()
    {
        return $"{{\"ISBN\":\"{ISBN}\",\"Title\":\"{Title}\",\"Author\":\"{Author}\",\"PageNumber\":{PageNumber}}}";
    }
    
    public string GetCSVHeader()
    {
        return "ISBN,Title,Author,Page Number";
    }
}
