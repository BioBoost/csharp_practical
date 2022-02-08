using System;

namespace KingsOfNothing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kings of Noodles - Player bashing 101");

            Player player = new Player();
            Console.WriteLine("\nCurrent player health: " + player.GetHealth());

            player.Damage(24);
            Console.WriteLine("\nBeating the player with 24 damage.");
            Console.WriteLine("Current player health: " + player.GetHealth());

            player.Heal(20);
            Console.WriteLine("\nHealing the player with 20 health.");
            Console.WriteLine("Current player health: " + player.GetHealth());

            player.Heal(20);
            Console.WriteLine("\nHealing the player again with 20 health.");
            Console.WriteLine("Current player health: " + player.GetHealth());

            player.Damage(100);
            Console.WriteLine("\nBeating the player to death.");
            Console.WriteLine("Current player health: " + player.GetHealth());
            Console.WriteLine("Is player alive? " + player.IsAlive());

            Console.WriteLine("\nMoving the player with (12, 10).");
            player.Move(12, 10);
            Console.WriteLine(" > Player x-coordinate: " + player.GetX());
            Console.WriteLine(" > Player y-coordinate: " + player.GetY());

            Console.WriteLine("\nMoving the player with (5, 8).");
            player.Move(5, 8);
            Console.WriteLine(" > Player x-coordinate: " + player.GetX());
            Console.WriteLine(" > Player y-coordinate: " + player.GetY());
        }
    }
}
