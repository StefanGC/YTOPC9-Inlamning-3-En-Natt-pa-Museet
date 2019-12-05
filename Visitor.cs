public class Visitor
{
    private int id = 1; 
    private string name;
    private Room roomIAmIn; 
    private Artwork artworkInFronOfMe;

    //Contructor
    public Visitor (string name) {
        id = id++;
        this.name = name;
        roomIAmIn = new Room("Entreen");
        artworkInFronOfMe = new Artwork ("No title", "No description", "No copyright");
    }
    public Visitor (string name, Room roomIAmIn) {
        id = id++;
        this.name = name;
        this.roomIAmIn = roomIAmIn;
    }

    //Get and Set methods
    public int Id {
        get { return id; }
        set { id = value; }
    }

    public string Name {
        get { return name; }
        set { name = value; }
    }    
    
    public Room RoomIAmIn {
        get { return roomIAmIn; }
        set { roomIAmIn = value; }
    }

    public Artwork ArtworkInFronOfMe {
        get { return artworkInFronOfMe; }
        set { artworkInFronOfMe = value; }
    }
}