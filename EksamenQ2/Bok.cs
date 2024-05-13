using System.Runtime.InteropServices.JavaScript;

namespace EksamenQ2;

public class Bok
{
    private int _pageCount;
    
    public string ISBN { get; init; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageNumber
    {
        get
        {
            return _pageCount;
        }
    }

    public Bok(string isbn, string title, string author, int pageCount)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        _pageCount = pageCount;
    }
    
    // legger til antal sider om antall sider er mer enn 0. 
    public void IncreasePageCount(int numberOfPages)
    {
        if (numberOfPages > 0)
        {
            _pageCount += numberOfPages;
        }
        else
        {
            Console.WriteLine(" Error: Antall sider er negativt");    
        }
    }
    // trekker fra antall sider.
    public void DecreasePageCount(int numberOfPages)
    {
        if (numberOfPages > 0 && numberOfPages <= _pageCount)
        {
            _pageCount -= numberOfPages;
        }
        else
        {
            Console.WriteLine("Error: Antall sider må være positivt og mindre enn antal sider.");
        }
    }

    public string GetInfo()
    {
        return $"Title {Title}, Forfatter {Author}, ISBN {ISBN}, Antall sider: {PageNumber}.";
    }
}