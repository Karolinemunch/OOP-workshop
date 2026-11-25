class Song
{
    public string Composter { get; set; } = "";
    public string Singer { get; set; } = "";
    public string Gerne { get; set; } = "";
    public string Filetype { get; set; } = "";
    public string Duration { get; set; } = "";
    public string Language { get; set; } = "";

    public Song(string composter, string singer, string gerne, string filetype, string duration, string language)
    {
        this.Composter = composter;
        this.Singer = singer;
        this.Gerne = gerne;
        this.Filetype = filetype;
        this.Duration = duration;
        this.Language = language;
    }
}
