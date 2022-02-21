using System;
using System.Collections.Generic;
using System.Text;

namespace KingOfTheHill
{
    public class PlayerScore
    {
        public PlayerScore(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public PlayerScore(string name)
        {
            Name = name;
        }

        public PlayerScore()
        {
        }

        private int score = 0;
        public int Score
        {
            get { return score; }
            set { if (value < 0) value = 0;  score = value; }
        }


        private string name = "The Unnamed Soldier";
        public string Name
        {
            get { return name; }
            set { if (value == null) value = "The Unnamed Soldier"; name = value; }
        }


        public override string ToString()
        {
            return $"[{Name}] {score}";
        }
    }
}
