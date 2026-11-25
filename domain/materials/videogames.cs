namespace Domain;
class Videogames : Material
{
    private string Publisher {public get;public set; } = "";
    private string Genre {public get;public set; } = "";
    private int ReleaseYear {public get;public set; }
    private string SupportedPlatforms {public get;public set; } = "";

    public Videogames(string Publisher, string Genre, int ReleaseYear, string SupportedPlatforms, string Title, double Rating, bool IsBorrowed)
    {
        this.Publisher = Publisher;
        this.Genre = Genre;
        this.ReleaseYear = ReleaseYear;
        this.SupportedPlatforms = SupportedPlatforms;
    }
}