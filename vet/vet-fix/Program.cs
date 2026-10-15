using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("How many rooms will be rented ? ");
        int rentedRooms = int.Parse(Console.ReadLine());

        Students[] rooms = new Students[9];

        for (int i = 0; i < rentedRooms; i++)
        {
            Console.WriteLine($"Rent #{i + 1}");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Room: ");
            int room = int.Parse(Console.ReadLine());

            rooms[room] = new Students { Name = name, Email = email, Room = room };

            Console.WriteLine();
        }

        Console.WriteLine("Busy rooms:");

        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] != null)
            {
                Console.WriteLine($"{rooms[i].Room}: {rooms[i].Name}, {rooms[i].Email}");
            }
        }
    }
}