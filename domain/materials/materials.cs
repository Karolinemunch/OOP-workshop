public abstract class Materials 
{ 
    public string Title { get; set; }
    public double Rating { get; set; }
    public bool IsBorrowed { get; set; }

    public Materials (string Title, double Rating, bool IsBorrowed)
    {
        this.Title = Title;
        this.Rating = Rating;
        this.IsBorrowed = IsBorrowed;
    }

    public void Download()
    {
        if (this.Materials.IsBorrowed)
        {
            //logic to download
        }
    }

    public void ShowInfo()
    {
        //Console.WriteLine(this.Materials); //skal lave to-string for at det fungerer
    }
}