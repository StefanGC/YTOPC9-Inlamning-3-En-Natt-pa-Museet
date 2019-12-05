using System;
using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Menu menu = new Menu();
            Room room1 = new Room("Entreen");
            Room room2 = new Room("Korridoren");
            Museum museum = new Museum(new List<Room> () {room1, room2});
            Visitor visitor = new Visitor("Stefan", museum.Rooms[0]);

            //Act
            var expected = room1;
            var result = visitor.RoomIAmIn;
            
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            Menu menu = new Menu();
            Museum museum = createMuseum();
            Visitor visitor = new Visitor("Stefan", museum.Rooms[3]);

            //Act
            var expected = "Title 6";
            var result = museum.Rooms[3].Artworks[0].Title;
            
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            Menu menu = new Menu();
            Museum museum = createMuseum();
            Visitor visitor = new Visitor("Stefan", museum.Rooms[3]);

            //Act
            var expected = "Svarta rummet";
            var result = museum.Rooms[1].Name;
            
            //Assert
            Assert.Equal(expected, result);
        }


        public static Museum createMuseum() {
            //Create all the artwork
            Artwork art1 = new Artwork ("Title 1", "Description 1", "Copyright");
            Artwork art2 = new Artwork ("Title 2", "Description 2", "Copyright");
            Artwork art3 = new Artwork ("Title 3", "Description 3", "Copyright");
            Artwork art4 = new Artwork ("Title 4", "Description 4", "Copyright");
            Artwork art5 = new Artwork ("Title 5", "Description 5", "Copyright");
            Artwork art6 = new Artwork ("Title 6", "Description 6", "Copyright");
            Artwork art7 = new Artwork ("Title 7", "Description 7", "Copyright");
            Artwork art8 = new Artwork ("Title 8", "Description 8", "Copyright");
            Artwork art9 = new Artwork ("Title 9", "Description 9", "Copyright");
            Artwork art10 = new Artwork ("Title 10", "Description 10", "Copyright");
            Artwork art11 = new Artwork ("Title 11", "Description 11", "Copyright");
            
            //Create all the room
            Room room1 = new Room("Vita rummet");
            Room room2 = new Room("Svarta rummet");
            Room room3 = new Room("Lila rummet");
            Room room4 = new Room("Blåa rummet");            
            Room room5 = new Room("Röda rummet");
            Room room6 = new Room("Gröna rummet");
            Room room7 = new Room("Korridoren");
            Room room8 = new Room("Entreen");

            //Add the artwork to the room
            room1.Artworks.Add(art1);   //The white room: one (1) artwork
            room3.Artworks.Add(art2);   //The purple room: four (4) artwork
            room3.Artworks.Add(art3);   //The purple room: four (4) artwork
            room3.Artworks.Add(art4);   //The purple room: four (4) artwork
            room3.Artworks.Add(art5);   //The purple room: four (4) artwork
            room4.Artworks.Add(art6);   //The blue room: one (1) artwork
            room5.Artworks.Add(art7);   //The red room: three (3) artwork
            room5.Artworks.Add(art8);   //The red room: three (3) artwork
            room5.Artworks.Add(art9);   //The red room: three (3) artwork
            room6.Artworks.Add(art10);  //The green room: two (2) artwork
            room6.Artworks.Add(art11);  //The green room: two (2) artwork

            //Create all the connections
            createConnection (room1, room4);
            createConnection (room2, room4);
            createConnection (room3, room4);
            createConnection (room3, room5);
            createConnection (room4, room6);
            createConnection (room5, room6);
            createConnection (room6, room7);
            createConnection (room7, room8);
           
            //Add the room to the museum
            List<Room> rooms = new List<Room>();
            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);
            rooms.Add(room5);
            rooms.Add(room6);
            rooms.Add(room7);
            rooms.Add(room8);

            return new Museum (rooms);  //We return the fully created museum
        }

        //Auxiliary function to create the connections between two rooms
        public static void createConnection (Room room1, Room room2) {
            room1.Connections.Add(new Connection (room1, room2));
            room2.Connections.Add(new Connection (room2, room1));
        }
    }
    
}
