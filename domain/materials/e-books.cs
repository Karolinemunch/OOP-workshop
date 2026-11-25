public class E_Book : Materials
{
    public string Language { get; set; }
    public string Author { get; set; }
    public int Number_Of_Pages { get; set; }
    public int Year_Of_Publication_And_ISBN { get; set; }

    public E_Book(string language, string author, int number_of_pages, int year_of_publication_and_ISBN)
    {
        this.Language = language;
        this.Author = author;
        this.Number_Of_Pages = number_of_pages;
        this.Year_Of_Publication_And_ISBN = year_of_publication_and_ISBN;
    }
}
