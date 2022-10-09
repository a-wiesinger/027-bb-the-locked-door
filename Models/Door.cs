namespace _027_bb_the_locked_door.Models;

public class Door
{
    // Properties
    public bool Open { get; set; }
    public bool Closed { get; set; }
    public bool Unlocked { get; set; }
    public bool Locked { get; set; }
    public string Passcode { get; set; }
    
    // Constructors
    public Door()
    {
        Passcode = InitialPasscode(); // Set starting password
        Closed = true;
        Locked = true;

    }

    // Door Methods
    private string InitialPasscode()
    {
        bool isValidPasscode = false;
        while (!isValidPasscode)
        {
            Console.WriteLine("*** Door Creator 3000 ***");
            Console.WriteLine("Please enter a 4 digit numerical passcode for your door");

            string? passcode = Console.ReadLine();

            // The happy path check
            bool blankResponse = String.IsNullOrEmpty(passcode);
            if (!blankResponse)
            {
                if (passcode!.Length == 4)
                {
                    if (int.TryParse(passcode, out int result))
                    {
                        isValidPasscode = true;
                        Passcode = result.ToString();
                        return result.ToString();
                    }
                }
            }
            else
            {
                isValidPasscode = false;
            }
        }
        
        return "Wrong.";
    }

    private void CreateNewPasscode()
    {
        Console.WriteLine("Please enter a 4 digit numerical passcode:");
        string? passcode = Console.ReadLine();
        
        bool blankResponse = String.IsNullOrEmpty(passcode);
        if (!blankResponse)
        {
            if (passcode!.Length == 4)
            {
                if (int.TryParse(passcode, out int result))
                {
                    Passcode = result.ToString();
                }
            }
        }
    }
    
    public string ChangePasscode()
    {
        Console.Write("Please enter the current passcode: ");
        string? currentPasswordAttempt = Console.ReadLine();

        if (currentPasswordAttempt == Passcode)
        {
            Console.Write("Great, what would you like the new passcode to be? ");
            CreateNewPasscode();
        }
        return "";
    }

    public void OpenDoor()
    {
        if (Closed && Unlocked)
        {
            Open = true;
            Closed = false;
            Console.WriteLine("Wow. That's a real nice nice open door there.");
        }
        else
        {
            Console.WriteLine("ERROR: Sorry, you can't open the door right now. It has to be closed and unlocked");
        }
    }

    public void CloseDoor()
    {
        if (Open)
        {
            Closed = true;
            Open = false;
            Console.WriteLine("By your command. The door is now closed.");
        }
        else
        {
            Console.WriteLine("ERROR: Can't close a door if it isn't open, Jack.");
        }
    }

    public void LockDoor()
    {
        if (Closed && Unlocked)
        {
            Locked = true;
            Console.WriteLine("Congratulations on your newly locked door.");
        }
        else
        {
            Console.WriteLine("ERROR: The door much be closed and unlocked to lock it.");
        }
    }

    public void UnlockDoor()
    {
        Console.Write("Enter the current passcode: ");
        string? enteredPassword = Console.ReadLine();

        if (enteredPassword == Passcode)
        {
            if (Locked && Closed)
            {
                Unlocked = true;
                Console.WriteLine("Nice! The door is unlocked.");
            }
        }
        else
        {
            Console.WriteLine("ERROR: Sorry, can't do that.");
        }
    }
}