using System;

class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door(null);

        Console.WriteLine(frontDoor.ToString());

        frontDoor.Interact();
    }
}
