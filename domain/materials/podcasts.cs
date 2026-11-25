public class Podcasts : Materials
{
    public int ReleaseYear { get; set; }
    public string Hosts { get; set; }
    public string Guests { get; set; }
    public int EpisodeNumber { get; set; }
    public string Language { get; set; }

    public Podcasts(string title, string hosts, string guests, int episodeNumber, string language)
    {
        this.Title = title;
        this.Hosts = hosts;
        this.Guests = guests;
        this.EpisodeNumber = episodeNumber;
        this.Language = language;
    }
}
