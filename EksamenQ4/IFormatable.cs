namespace Oppgave4;
// Del A
public interface IFormatable
{
    public string ToCSV();
    public string ToJSON();
    public string GetCSVHeader();
}