using System;
using System.Collections.Generic;

namespace AdvGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load up room instances for the game
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

            // link the rooms together
            /*
                * room['outside'].n_to = room['foyer']
                * room['foyer'].s_to = room['outside']
                * room['foyer'].n_to = room['overlook']
                * room['foyer'].e_to = room['narrow']
                * room['overlook'].s_to = room['foyer']
                * room['narrow'].w_to = room['foyer']
                * room['narrow'].n_to = room['treasure']
                room['treasure'].s_to = room['narrow']
            */
            rooms["outside"].SetN_To(rooms["foyer"]);
            rooms["foyer"].SetS_To(rooms["outside"]);
            rooms["foyer"].SetN_To(rooms["overlook"]);
            rooms["foyer"].SetE_To(rooms["narrow"]);
            rooms["overlook"].SetS_To(rooms["foyer"]);
            rooms["narrow"].SetW_To(rooms["foyer"]);
            rooms["narrow"].SetN_To(rooms["treasure"]);
            rooms["treasure"].SetS_To(rooms["narrow"]);
        }
    }
}
