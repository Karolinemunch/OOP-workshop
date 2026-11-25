namespace Domain;
class Videogames : Materials
{
    private string Publisher { get; set; } = "";
    private string Genre { get; set; } = "";
    private int ReleaseYear { get; set; }
    private string SupportedPlatforms { get; set; } = "";

    public Videogames(string Publisher, string Genre, int ReleaseYear, string SupportedPlatforms, string Title, double Rating, bool IsBorrowed) : base (Title, Rating, IsBorrowed)
    {
        this.Publisher = Publisher;
        this.Genre = Genre;
        this.ReleaseYear = ReleaseYear;
        this.SupportedPlatforms = SupportedPlatforms;
    }
}