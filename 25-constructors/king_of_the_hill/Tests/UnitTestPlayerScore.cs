using KingOfTheHill;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPlayerScore
    {
        private PlayerScore score = new PlayerScore();

        [Fact]
        public void TestDefaultConstructor()
        {
            score = new PlayerScore();
            Assert.Equal("The Unnamed Soldier", score.Name);
            Assert.Equal(0, score.Score);
        }

        [Fact]
        public void TestNameConstructor()
        {
            score = new PlayerScore("Ken Thompson");
            Assert.Equal("Ken Thompson", score.Name);
            Assert.Equal(0, score.Score);

            score = new PlayerScore("Alan Mathison Turing");
            Assert.Equal("Alan Mathison Turing", score.Name);
            Assert.Equal(0, score.Score);

            score = new PlayerScore(null);
            Assert.Equal("The Unnamed Soldier", score.Name);
            Assert.Equal(0, score.Score);
        }

        [Fact]
        public void TestNameScoreConstructor()
        {
            score = new PlayerScore("John Rambo", 1203);
            Assert.Equal("John Rambo", score.Name);
            Assert.Equal(1203, score.Score);

            score = new PlayerScore("Dennis Ritchie", 232);
            Assert.Equal("Dennis Ritchie", score.Name);
            Assert.Equal(232, score.Score);

            score = new PlayerScore(null, 666);
            Assert.Equal("The Unnamed Soldier", score.Name);
            Assert.Equal(666, score.Score);
        }

        [Fact]
        public void TestNameProperty()
        {
            score.Name = "Chuck Norris";
            Assert.Equal("Chuck Norris", score.Name);

            score.Name = "Sylvester Stallone";
            Assert.Equal("Sylvester Stallone", score.Name);
        }

        [Fact]
        public void TestNameNotNull()
        {
            score.Name = null;
            Assert.Equal("The Unnamed Soldier", score.Name);
        }

        [Fact]
        public void TestScoreProperty()
        {
            score.Score = 33;
            Assert.Equal(33, score.Score);

            score.Score = 1233;
            Assert.Equal(1233, score.Score);
        }

        [Fact]
        public void TestScoreNotBelowZero()
        {
            score.Score = -123;
            Assert.Equal(0, score.Score);
        }

        [Fact]
        public void TestToString()
        {
            score = new PlayerScore("Keanu Reeves", 323543);
            Assert.Equal("[Keanu Reeves] 323543", score.ToString());

            score = new PlayerScore("Tom Cruise", 1);
            Assert.Equal("[Tom Cruise] 1", score.ToString());
        }


    }
}
