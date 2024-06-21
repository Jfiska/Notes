namespace Notes.Persistence.EntityTypeConfiguration;

public class DbInitializer
{
    public static void Initialaze(NotesDbContext context)
    {
        context.Database.EnsureCreated();
    }
}
