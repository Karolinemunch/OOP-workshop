public class Program
{
    public static void Main()
    {
        // E_Book bog = new E_Book("Tysk", "Tolkien", 310, 1937);

        // Console.WriteLine(" language: " + bog.Language + " author: " + bog.Author + " number_of_pages: " + bog.Number_of_pages + " year_of_publication_and_ISBN: " + bog.Year_of_publication_and_ISBN);

        Images picture1 = new Images("Nude", "4032 × 3024", ".JPG", "4.2 MB", 25112026);
        Console.WriteLine("Title: " + picture1.Title + ", Resolution: " + picture1.Resolution + ", FileFormat: " + picture1.FileFormat + ", FileSize: " + picture1.FileSize + ", DateTaken: " + picture1.DateTaken);

        Podcasts pod1 = new Podcasts("Daily discussions of alien life", "Fred & Jeppe", "Karo & David", 1, "Danglish");
        Console.WriteLine("Title: " + pod1.Title + ", Hosts: " + pod1.Hosts + ", Guests: " + pod1.Guests + ", Episode: " + pod1.EpisodeNumber + ", Language: " + pod1.Language);
            
    }
}
