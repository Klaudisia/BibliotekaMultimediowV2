namespace BibliotekaMultimediowV2.Types;

public class Ebook : Media //dziedziczenie
{
   public override string Rodzaj => "Ebook"; //polimorfizm

   public override decimal Price => 5.0m;
}