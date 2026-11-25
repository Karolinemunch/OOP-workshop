class Movies : Materials
{
    public string Director { get; set; } = "";
    public string Gerne { get; set; } = "";
    public int Release_year { get; set; }
    public string Language { get; set; } = "";
    public string Duration { get; set; } = "";

    public Movies( string director, string gerne, int release_year, string language, string duration)
    {
        this.Language = language;
        this.Director = director;
        this.Gerne = gerne;
        this.Release_year = release_year;
        this.Duration = duration;
    }
}
