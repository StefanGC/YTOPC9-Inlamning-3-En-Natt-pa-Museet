public class Artwork
{
    private string title; 
    private string description;
    private string copyrightMakers;

    //Contructor
    public Artwork (string title, string description, string copyrightMakers) {
        this.title = title;
        this.description = description;
        this.copyrightMakers = copyrightMakers;
    }
    
    //Get and Set methods
    public string Title {
        get { return title; }
        set { title = value; }
    }

    public string Description {
        get { return description; }
        set { description = value; }
    }

    public string CopyrightMakers {
        get { return copyrightMakers; }
        set { copyrightMakers = value; }
    }
}
 