public class Images : Materials
{
    public string Resolution { get; set; }
    public string FileFormat { get; set; }
    public int FileSize { get; set; }
    public int DateTaken { get; set; }

    public void Image (string title, string resolution, int fileSize, int dateTaken)
    {
        this.Title = title;
        this.Resolution = resolution;
        this.FileSize = fileSize;
        this.DateTaken = dateTaken;
    }
}
