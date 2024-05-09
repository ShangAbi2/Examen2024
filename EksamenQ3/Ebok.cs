namespace EksamenQ3;

public class Ebok : Bok
{
    public double FileSize { get; set; }

    public Ebok(string isbn, string title, string author, int pageCount, double fileSize)
        : base(isbn, title, author, pageCount)
    {
        FileSize = fileSize;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"Filstørrelse = {FileSize} MB";
    }
}