namespace BibliotekaMultimediowV2.Types;

public class Movie : Media
{
    public override string Rodzaj => "Film";

    public override decimal Price => 15.0m;
}