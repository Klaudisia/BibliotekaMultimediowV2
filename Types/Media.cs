namespace BibliotekaMultimediowV2.Types;

public abstract class Media
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public abstract string Rodzaj { get; }
    public abstract decimal Price { get; }
}