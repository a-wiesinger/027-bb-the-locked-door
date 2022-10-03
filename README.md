# Level 24 - Boss Battle - "The Locked Door"
Following along with the C# Player's Guide by RB Whitaker
## Criteria:
1. Define a door class that tracks its current state (open, closed, locked, unlocked)
2. Transitions between states should be performed with methods
3. Constructor should require the creation of a starting passcode
4. Create a method which allows for changing the passcode if the current one is first given
5. Main method should ask the user for a passcode and THEN generate the door
6. User can attempt to change the door state
7. User can attempt to change the door passcode

## Door Info:
- Open door can be closed
- Closed (not locked) door can be opened
- Closed door can be locked
- Locked door can be unlocked WITH the current passcode
- Door must be given an initial passcode when instanced
- Should be able to change the passcode. This is successful if first the initial passcode is given