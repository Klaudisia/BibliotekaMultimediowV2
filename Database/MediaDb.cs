using BibliotekaMultimediowV2.Types;
using Microsoft.EntityFrameworkCore;

namespace BibliotekaMultimediowV2.Database;

public class MediaDb : DbContext
{
    public MediaDb(DbContextOptions<MediaDb> options) : base(options)
    {
    }
    
    public DbSet<Ebook> Ebooks { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Audiobook> Audiobooks { get; set; }
}