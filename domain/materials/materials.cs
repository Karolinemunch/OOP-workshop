public abstract class Materials 
{ 
    private string Title {public get;public set; }
    private double Rating {public get;public set; }
    private bool IsBorrowed {public get;public set; }

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