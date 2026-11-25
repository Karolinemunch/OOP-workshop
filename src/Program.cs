public class Program
{
    public static void Main()
    {
        E_Book bog = new E_Book("Hobbiten", "The Hobbit", "Tysk", "Tolkien", 310, 1937);

        Console.WriteLine(bog.Name + " titel: " + bog.Titel + " language: " + bog.Language + " author: " + bog.Author + " number_of_pages: " + bog.Number_of_pages + " year_of_publication_and_ISBN: " + bog.Year_of_publication_and_ISBN);
        bog.Name = "Ringenes herre";
        Console.WriteLine(bog.Name + " titel: " + bog.Titel + " language: " + bog.Language + " author: " + bog.Author + " number_of_pages: " + bog.Number_of_pages + " year_of_publication_and_ISBN: " + bog.Year_of_publication_and_ISBN);
    }
}