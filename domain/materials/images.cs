public class Images : Materials
{
    public string Resolution { get; set; }
    public string FileFormat { get; set; }
    public string FileSize { get; set; }
    public int DateTaken { get; set; }

    public Images(string title, string resolution, string fileFormat, string fileSize, int dateTaken)
    {
        this.Title = title;
        this.Resolution = resolution;
        this.FileFormat = fileFormat;
        this.FileSize = fileSize;
        this.DateTaken = dateTaken;
    }
}
