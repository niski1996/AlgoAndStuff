using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsTest.Test
{
    public class Tests
    {

        [Test]
        [TestCase( "5 4\n2 0 1 2", "NO")]
        [TestCase( "3 3\n2 2 3", "NO")]
        [TestCase( "4 3\n2 2 3", "YES")]
        [TestCase( "5 4\n2 0 1 3", "YES")]
        [TestCase("5 6 2 1 2 4 5 0", "NO")]
        [TestCase("5 4 1 2 2 3", "YES")]
        [TestCase("5 4 1 1 2 2", "NO")]
        [TestCase("2 2 1 1", "YES")]
        [TestCase("2 2 2 2", "NO")]
        [TestCase("8 6 1 2 2 3 4 4", "NO")]
        [TestCase("8 4 0 1 2 2", "NO")]
        [TestCase("15 14 1 0 1 1 1 1 2 2 1 2 0 2 2 0", "NO")]
        public void TestTeamworkTestdata1(string input, string output)
        {
            string smartNick = Cards.YouAreJokeNick(input);
            Assert.AreEqual(smartNick, output);



        }
    }
}
