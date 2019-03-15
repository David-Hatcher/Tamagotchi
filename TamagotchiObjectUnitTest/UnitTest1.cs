using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi;

namespace TamagotchiObjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        TamagotchiObject to = new TamagotchiObject();
        
        [TestMethod]
        public void TestHappinessAdjust()
        {
            int expected = 45;
            int[] changes = { -5, 0, 0, 0 };
            to.adjustStats(changes);
            int result = to.statValues["happiness"];
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestHungerAdjust()
        {
            int expected = 45;
            int[] changes = { 0, -5, 0, 0 };
            to.adjustStats(changes);
            int result = to.statValues["hunger"];
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTiredAdjust()
        {
            int expected = 45;
            int[] changes = { 0, 0, -5, 0 };
            to.adjustStats(changes);
            int result = to.statValues["tiredness"];
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestFullAdjust()
        {
            int expected = 45;
            int[] changes = { 0, 0, 0, -5 };
            to.adjustStats(changes);
            int result = to.statValues["fullness"];
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAllAdjust()
        {
            int[] expected = {37, 34, 100, 53 };
            int[] changes = {-13, -16, 50, 3 };
            to.adjustStats(changes);
            int[] result = to.statValues.Values.ToArray();
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestNameGetSet()
        {
            to.name = "Jimmy";
            string result = to.name;
            string expected ="Jimmy";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestGenderGetSet()
        {
            to.gender = "Jimmy";
            string result = to.gender;
            string expected = "Jimmy";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatValue_Happiness()
        {
            int result = to.statValue("happiness");
            int expected = to.statValues["happiness"];
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatValue_Tiredness()
        {
            int result = to.statValue("tiredness");
            int expected = to.statValues["tiredness"];
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus()
        {
            to.name = "Jimmy";
            string result = to.statStatus("tiredness");
            string expected = "Jimmy feels a little tired.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus2()
        {
            to.name = "Jimmy";
            string result = to.statStatus("hunger");
            string expected = "Jimmy feels like they could probably eat.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus3()
        {
            to.name = "Jimmy";
            string result = to.statStatus("happiness");
            string expected = "Jimmy feels content.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus4()
        {
            to.name = "Jimmy";
            string result = to.statStatus("fullness");
            string expected = "Jimmy feels like they can wait awhile to use the bathroom.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestPlayerChoiceError()
        {
            string result = to.PlayerChoice("buttstuff");
            string expected = "I don't understand. Type help for possible commands.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestPayerChoicePlay()
        {
            to.name = "Jimmy";
            string result = to.PlayerChoice("poop");
            string expected = "You took Jimmy to the bathroom.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestPayerChoiceHunger()
        {
            to.name = "Jimmy";
            string result = to.PlayerChoice("hunger");
            string expected = "Jimmy feels like they could probably eat.";
            Assert.AreEqual(result, expected);
        }

    }
}
