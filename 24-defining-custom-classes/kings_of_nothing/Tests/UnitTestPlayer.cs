using KingsOfNothing;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPlayer
    {
        private Player player = new Player();

        [Fact]
        public void TestMove()
        {
            Assert.Equal(0, player.GetX());
            Assert.Equal(0, player.GetY());

            player.Move(15, -3);
            Assert.Equal(15, player.GetX());
            Assert.Equal(-3, player.GetY());

            player.Move(0, 23);
            Assert.Equal(15, player.GetX());
            Assert.Equal(20, player.GetY());

            player.Move(0, 0);
            Assert.Equal(15, player.GetX());
            Assert.Equal(20, player.GetY());
        }

        [Fact]
        public void TestDamage()
        {
            Assert.Equal(100, player.GetHealth());

            player.Damage(5);
            Assert.Equal(95, player.GetHealth());

            player.Damage(0);
            Assert.Equal(95, player.GetHealth());

            player.Damage(94);
            Assert.Equal(1, player.GetHealth());

            player.Damage(10);
            Assert.Equal(0, player.GetHealth());

            player.Damage(100);
            Assert.Equal(0, player.GetHealth());
        }

        [Fact]
        public void TestAlive()
        {
            Assert.Equal(100, player.GetHealth());
            Assert.True(player.IsAlive());

            player.SetHealth(20);
            Assert.True(player.IsAlive());

            player.SetHealth(0);
            Assert.False(player.IsAlive());
        }

        [Fact]
        public void TestHeal()
        {
            Assert.Equal(100, player.GetHealth());

            player.Heal(20);
            Assert.Equal(100, player.GetHealth());

            player.SetHealth(30);
            player.Heal(10);
            Assert.Equal(40, player.GetHealth());

            player.SetHealth(0);
            player.Heal(10);
            Assert.Equal(0, player.GetHealth());
        }
    }
}
