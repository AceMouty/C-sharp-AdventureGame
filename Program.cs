using System;
using System.Collections.Generic;

namespace AdvGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Room> rooms = new Dictionary<string, Room>();
            rooms.Add("outside", new Room("Outside Cave Entrance", "North of you the cave mount beckons"));
            rooms.Add("foyer", new Room("Foyer", "Dim light filters in from the south. Dusty passages run north and east."));
            rooms.Add("Grand Overlook", new Room("Grand Overlook", @"A steep cliff appears before you, falling
into the darkness. Ahead to the north, a light flickers in
the distance, but there is no way across the chasm."));
            rooms.Add("narrow", new Room("Narrow", "The narrow passage bends here from west to north. The smell of gold permeates the air."));
            rooms.Add("treasure", new Room("Treasure Chamber", @"You've found the long-lost treasure
chamber! Sadly, it has already been completely emptied by
earlier adventurers. The only exit is to the south."));

            foreach(string room in rooms.Keys)
            {
                Console.WriteLine(rooms[room].GetDesc());
                Console.WriteLine();
            }
        }
    }
}
