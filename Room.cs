using System.Collections.Generic;

public class Room 
{
    private string name;
    private List<Artwork> artworks;
    private List<Connection> connections;

    //Contructor
    public Room (string name) {
        this.name = name;
        artworks = new List<Artwork>();
        connections = new List<Connection>();
    }
    public Room (string name,  List<Artwork> artworks, List<Connection> connections) {
        this.name = name;
        this.artworks = artworks;
        this.connections = connections;
    }

    //Get and Set methods
    public string Name {
        get { return name; } 
        set { name = value; }
    }

    public List<Artwork> Artworks {
        get { return artworks; }
        set { artworks = value; }
    }

    public List<Connection> Connections {
        get { return connections; }
        set { connections = value; }
    }
}