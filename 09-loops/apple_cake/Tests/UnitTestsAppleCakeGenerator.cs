using AppleCake;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestsAppleCakeGenerator
    {
        private AppleCakeGenerator generator = new AppleCakeGenerator();

        [Fact]
        public void TestApple()
        {
            Assert.Equal("apple", generator.AppleCake(3));
            Assert.Equal("apple", generator.AppleCake(321));
        }

        [Fact]
        public void TestCake()
        {
            Assert.Equal("cake", generator.AppleCake(5));
            Assert.Equal("cake", generator.AppleCake(500));
        }

        [Fact]
        public void TestAppleCake()
        {
            Assert.Equal("applecake", generator.AppleCake(15));
            Assert.Equal("applecake", generator.AppleCake(300));
        }

        [Fact]
        public void TestSingleGenerate()
        {
            string text = "3: apple\n";
            Assert.Equal(text.Trim(), generator.Generate(3, 3).Trim());
        }

        [Fact]
        public void TestStartToEndGenerator()
        {
            string text = "3: apple\n5: cake\n6: apple\n9: apple\n10: cake\n12: apple\n15: applecake\n18: apple\n20: cake\n21: apple\n24: apple\n25: cake\n27: apple\n30: applecake\n33: apple\n35: cake\n36: apple\n39: apple\n40: cake\n42: apple\n45: applecake\n48: apple\n50: cake\n51: apple\n54: apple\n55: cake\n57: apple\n60: applecake\n63: apple\n65: cake\n66: apple\n69: apple\n70: cake\n72: apple\n75: applecake\n78: apple\n80: cake\n81: apple\n84: apple\n85: cake\n87: apple\n90: applecake\n93: apple\n95: cake\n96: apple\n99: apple\n100: cake\n";

            Assert.Equal(text.Trim(), generator.Generate(1, 100).Trim());
        }
    }
}
