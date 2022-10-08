namespace _027_bb_the_locked_door.Models;

public class Door
{
    // Properties
    public bool Open { get; set; } = false;
    public bool Closed { get; set; } = false;
    public bool UnLocked { get; set; } = false;
    public bool Locked { get; set; } = false;
    public string Passcode { get; set; }
    
    // Constructors
    public Door()
    {
        Passcode = InitialPasscode(); // Set starting password
        Closed = true; // Set door state
    }

    // Door Methods
    private string InitialPasscode()
    {
        Console.WriteLine("*** Door Creator 3000 ***");
        Console.WriteLine("Please enter a 4 digit numerical passcode for your door");

        string? passcode = Console.ReadLine();

        // The happy path check
        bool blankResponse = String.IsNullOrEmpty(passcode);
        if (!blankResponse)
        {
            if (passcode.Length == 4)
            {
                if (int.TryParse(passcode, out int result))
                {
                    Passcode = result.ToString();
                    return result.ToString();
                }
            }
        }

        return "Wrong.";
    }

    public void OpenDoor()
    {
        if (Closed)
        {
            Open = true;
            Closed = false;
            Console.WriteLine("Wow. That's a real nice nice open door there.");
        }
        else
        {
            Console.WriteLine("Sorry, the door isn't closed so you can't open it.");
        }
    }

    public void CloseDoor()
    {
        if (Open)
        {
            Closed = true;
        }
    }

    public void LockDoor()
    {
        
    }

    public void UnlockDoor()
    {
        
    }
}