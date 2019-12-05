using System;
using System.Threading;

public class Menu
{

    //Function to display the main menu
    public int showMenu (Room room) {
        System.Console.WriteLine("Välj ett alternativ:");
        System.Console.WriteLine( "  [0] Avsluta programmet.");
        System.Console.WriteLine($"  [1] Se på de konstverk som finns i {room.Name}.");
        System.Console.WriteLine($"  [2] Flytta från {room.Name} till ett annat rum.");
        System.Console.Write("  \nDitt val är: ");  
    
        return checkOption();
    }

    //Function to display all the artwork in the roomm
    public int showArtwork (Room room) {
        if (room.Artworks.Count == 0) {
            System.Console.WriteLine($"Det finn inga konstverk tillgängliga i {room.Name}, vad vill du göra?"); 
            System.Console.WriteLine("  [0] Gå tillbaka till föregående meny.");
        } else {
            System.Console.WriteLine($"Dessa är konstverk tillgängliga i {room.Name}, vad vill du göra?");
            System.Console.WriteLine("  [0] Gå tillbaka till föregående meny.");

            for (int index = 0; index < room.Artworks.Count; index++)
                System.Console.WriteLine($"  [{index+1}] Titta på konstverket med titel ({room.Artworks[index].Title})");
        }
        System.Console.Write("\nDitt val är: ");

        return checkOption();
    }

    //Function to simulate how the visitor contemplates the artwork
    public int contemplateArtwork (Room room, Artwork artwork) {
        System.Console.WriteLine($"Du gillade konstverket med title ({artwork.Title}), vad vill du göra?");
        System.Console.WriteLine("  [0] Gå tillbaka till huvudmeny.");

        for (int index = 0; index < room.Artworks.Count; index++)
                System.Console.WriteLine($"  [{index+1}] Titta på konstverket med titel ({room.Artworks[index].Title})");

        System.Console.Write("\nDitt val är: ");

        return checkOption();
    }

    //function to show the rooms accessible from the room
    public int showNearbyRooms (Room room) {
        System.Console.WriteLine($"Du befinner dig i {room.Name}. Vilket rum vill du gå till?");
        System.Console.WriteLine("  [0] Gå tillbaka till huvudmeny.");

        for (int index = 0; index < room.Connections.Count; index++)
            System.Console.WriteLine($"  [{index+1}] Go till {room.Connections[index].Room2.Name}");

        System.Console.Write("\nDitt val är: ");

        return checkOption();
    }

    //Auxiliary function to verify that the option is a number
    public int checkOption () {
        string input = Console.ReadKey().KeyChar.ToString();
        int option = -1;
        while (!int.TryParse(input, out option)) {
            System.Console.Write("  \nFel val, ange ett nytt val: ");                    
            input = Console.ReadKey().KeyChar.ToString();
        }
        option = int.Parse(input); 
        System.Console.Clear();

        return option;
    }
    
    //Function to show an animation every x milliseconds
    public void Animate (char c, int milliseconds, int times) {
        for (int i = 0; i < times; i++) {
            System.Console.Write(c);
            Thread.Sleep(milliseconds);
        } 
    }
}