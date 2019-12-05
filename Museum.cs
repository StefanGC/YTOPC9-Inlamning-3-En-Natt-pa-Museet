using System.Collections.Generic;

public class Museum 
{
    private int numOfRoom;
    private List<Room> rooms;

    //Contructor 
    public Museum () {
        numOfRoom = 0;
        rooms = new List<Room>();
    }
    public Museum (List<Room> rooms) {
        this.numOfRoom = rooms.Count;
        this.rooms = rooms;
    }

    //Get and Set methods
    public int NumOfRoom {
        get { return numOfRoom; }
        set { numOfRoom = value; }
    }

    public List<Room> Rooms {
        get { return rooms; }
        set { rooms = value; }
    }
}