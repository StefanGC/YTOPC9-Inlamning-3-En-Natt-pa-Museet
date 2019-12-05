public class Connection
{
    private Room room1;
    private Room room2;

    //Contructor
    public Connection (Room room1,Room room2) {
        this.room1 = room1;
        this.room2 = room2;
    }

    //Get and Set methods
    public Room Room1 {
        get { return room1; }
        set { room1 = value; }
    }
    
    public Room Room2 {
        get { return room2; }
        set { room2 = value; }
    } 
}