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
            rooms.Add("overlook", new Room("Grand Overlook", @"A steep cliff appears before you, falling
into the darkness. Ahead to the north, a light flickers in
the distance, but there is no way across the chasm."));
            rooms.Add("narrow", new Room("Narrow", "The narrow passage bends here from west to north. The smell of gold permeates the air."));
            rooms.Add("treasure", new Room("Treasure Chamber", @"You've found the long-lost treasure
chamber! Sadly, it has already been completely emptied by
earlier adventurers. The only exit is to the south."));

            // link the rooms together
            rooms["outside"].N_To = rooms["foyer"];
            rooms["foyer"].S_To = rooms["outside"];
            rooms["foyer"].N_To = rooms["overlook"];
            rooms["foyer"].E_To = rooms["narrow"];
            rooms["overlook"].S_To = rooms["foyer"];
            rooms["narrow"].W_To = rooms["foyer"];
            rooms["narrow"].N_To = rooms["treasure"];
            rooms["treasure"].S_To = rooms["narrow"];

            // Read in a player name
            Console.WriteLine("What is your name?");
            var playerName = Console.ReadLine();
            
            // Create player instance
            var player = new Player(playerName, rooms["outside"]);

            // A table for looking up directions a player can move in the game
            char[] directions = new char[] {'n', 's', 'e', 'w'};

            // Start game loop
            while(true)
            {
                Console.WriteLine(player.GetRoomDesc());
                PlayerOptions();
                Console.WriteLine("What direction do you want to go?");
                
                var commandBuffer = Console.ReadLine().ToLower();
                char command;
                
                // Check if the command passed atleast has a lenght of 1, if not continually prompt the user
                while(commandBuffer.Length != 1)
                {
                    Console.WriteLine("What direction do you want to go?");
                    commandBuffer = Console.ReadLine().ToLower();
                }

                // assign command to first char stored in command buffer
                command = commandBuffer[0];

                // See if the provided command is a valid direction to move OR if the user chose to quit
                if(Array.IndexOf(directions, command) != -1)
                {   
                    // If direction provided is valid then attempt to move
                    player.Travel(command);
                    Console.Clear();
                } 
                // Kill game loop if the user enters q
                else if(command == 'q')
                {
                    break;
                }
                // Let the user know they have passed a in valid command
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry I dont understand that command");
                    System.Console.WriteLine();
                }
            }

            Environment.Exit(1);

        }

        static void PlayerOptions()
        {
            Console.WriteLine(@"
================================ options ===================================
q: quit
n/s/e/w: Move north, south, east or west to the next room
============================================================================
            ");
        }
    }
}
