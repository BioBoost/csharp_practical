using System;
using System.Collections.Generic;
using System.Text;

namespace KingsOfNothing
{
    public class Player
    {
        public void Move(int deltaX, int deltaY)
        {
            // TODO - Change the player location with the delta-values
        }

        public void Damage(int damage)
        {
            // TODO - Lower the players health with the amount of 'damage'.
            // Make sure not to go lower than '0'
        }

        public bool IsAlive()
        {
            // TODO - Return true of the player is still alive

            return false;
        }

        public void Heal(int amount)
        {
            // TODO - Heal the player by amount. Do not go above 100.
            // Also a player can only be healed if its alive
        }

        // Getters / Setters
        public int GetX() { return locationX; }
        public void SetX(int x) { this.locationX = x; }

        public int GetY() { return locationY; }
        public void SetY(int y) { this.locationY = y; }

        public int GetHealth() { return health; }
        public void SetHealth(int health) { this.health = health; }

        // Attributes
        private int locationX = 0;
        private int locationY = 0;
        private int health = 100;
    }
}
