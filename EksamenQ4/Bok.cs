namespace EksamenQ4;

public class Bok : IFormatable
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

    public string ToCSV()
    {
        return $"{ISBN},{Title},{Author},{PageNumber}";
    }

    public string ToJSON()
    {
        return $"{{\"ISBN\":\"{ISBN}\",\"Title\":\"{Title}\",\"Author\":\"{Author}\",\"PageNumber\":{PageNumber}}}";
    }
}