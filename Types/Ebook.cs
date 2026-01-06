namespace BibliotekaMultimediowV2.Types;

public class Ebook : Media
{
   public override string Rodzaj => "Ebook";

   public override decimal Price => 5.0m;
}