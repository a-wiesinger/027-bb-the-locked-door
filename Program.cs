// The Locked Door
// :: State Switching ::
// :: Boss Battle 4/5 ::

using _027_bb_the_locked_door.Models;

// Setup
Console.Title = "The Locked Door";
Console.Clear();

// User setup of initial door

// Create door with user passcode
Door door = new Door();
Console.WriteLine("***********************************");
Console.WriteLine("Nice work. Your new door is closed.");
Console.WriteLine($"Initial passcode set to: {door.Passcode}");

// Change door state
Console.Write("Please feel free to change the door's state -> ");
string? userInput = Console.ReadLine();

// Calls to change state
switch (userInput)
{
    case "open":
        door.OpenDoor();
        break;
    case "close":
        door.CloseDoor();
        break;
    case "lock":
        door.LockDoor();
        break;
    case "unlock":
        door.UnlockDoor();
        break;
    default:
        Console.WriteLine("Try again.");
        break;
}