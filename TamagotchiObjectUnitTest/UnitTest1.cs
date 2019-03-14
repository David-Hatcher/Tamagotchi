using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi;

namespace TamagotchiObjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHappinessAdjust()
        {
            TamagotchiObject to = new TamagotchiObject();
            int expected = to.happinessLevel - 5;
            to.happyAdjust(-5);
            Assert.AreEqual(to.happinessLevel, expected);
        }
        [TestMethod]
        public void TestHungerAdjust()
        {
            TamagotchiObject to = new TamagotchiObject();
            int expected = to.hungerLevel - 5;
            to.hungerAdjust(-5);
            Assert.AreEqual(to.hungerLevel, expected);
        }
        [TestMethod]
        public void TestTiredAdjust()
        {
            TamagotchiObject to = new TamagotchiObject();            
            int expected = to.tirednessLevel -5;
            to.tiredAdjust(-5);
            Assert.AreEqual(to.tirednessLevel, expected);
        }
        [TestMethod]
        public void TestFullAdjust()
        {
            TamagotchiObject to = new TamagotchiObject();
            int expected = to.fullnessLevel - 5;
            to.fullAdjust(-5);            
            Assert.AreEqual(to.fullnessLevel, expected);
        }
        [TestMethod]
        public void TestNameGetSet()
        {
            TamagotchiObject to = new TamagotchiObject();
            to.name = "Jimmy";
            string result = to.name;
            string expected ="Jimmy";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestGenderGetSet()
        {
            TamagotchiObject to = new TamagotchiObject();
            to.gender = "Jimmy";
            string result = to.gender;
            string expected = "Jimmy";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatValue_Happiness()
        {
            TamagotchiObject to = new TamagotchiObject();
            int result = to.statValue("happiness");
            int expected = to.happinessLevel;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatValue_Tiredness()
        {
            TamagotchiObject to = new TamagotchiObject();
            int result = to.statValue("tiredness");
            int expected = to.tirednessLevel;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus()
        {
            TamagotchiObject to = new TamagotchiObject();
            string result = to.statStatus("tiredness");
            string expected = "a little tired.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus2()
        {
            TamagotchiObject to = new TamagotchiObject();
            string result = to.statStatus("hunger");
            string expected = "like they could probably eat.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus3()
        {
            TamagotchiObject to = new TamagotchiObject();
            string result = to.statStatus("happiness");
            string expected = "content.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus4()
        {
            TamagotchiObject to = new TamagotchiObject();
            string result = to.statStatus("fullness");
            string expected = "like they can wait awhile to use the bathroom.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TeststatStatus5()
        {
            TamagotchiObject to = new TamagotchiObject();
            string result = to.statStatus("buttstuff");
            string expected = "please enter a valid stat(hunger, tiredness, happiness, fullness)";
            Assert.AreEqual(result, expected);
        }


    }
}
