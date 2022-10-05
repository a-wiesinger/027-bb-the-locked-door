// The Locked Door
// :: State Switching ::
// :: Boss Battle 4/5 ::

using _027_bb_the_locked_door.Models;

// Setup
Console.Title = "The Locked Door";
Console.Clear();

// User setup of initial door

// Create door with user passcode
Door door = new Door(Door.InitialPasscode());
Console.WriteLine(door.Passcode);
