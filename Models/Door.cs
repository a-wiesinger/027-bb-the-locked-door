namespace _027_bb_the_locked_door.Models;

public class Door
{
    // Properties
    public bool Open { get; set; }
    public bool Closed { get; set; }
    public bool UnLocked { get; set; }
    public bool Locked { get; set; }
    public string Passcode { get; set; }
    
    // Constructors
    public Door(string passcode)
    {
        Passcode = passcode;
    }

    // Door Methods
    public static string InitialPasscode()
    {
        Console.WriteLine("*** Door Creator 3000 ***");
        Console.WriteLine("Please enter a 4 digit numerical passcode for your door");

        // TODO - Data validation checks not working as expected
        string? passcode = Console.ReadLine();
        if (passcode == null) InitialPasscode();
        if (passcode.Length != 4) InitialPasscode();

        bool numberCheck = int.TryParse(passcode, out int result);
        if (numberCheck)
        {
            return Convert.ToString(result);
        }
        else
        {
            InitialPasscode();
        }

        return passcode;
    }
}