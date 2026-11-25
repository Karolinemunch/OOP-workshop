public class E_Book
{
    public string Language { get; set; }
    public string Author { get; set; }
    public int Number_of_pages { get; set; }
    public int Year_of_publication_and_ISBN { get; set; }

    public E_Book(string language, string author, int number_of_pages, int year_of_publication_and_ISBN)
    {
        this.Language = language;
        this.Author = author;
        this.Number_of_pages = number_of_pages;
        this.Year_of_publication_and_ISBN = year_of_publication_and_ISBN;
    }
}
