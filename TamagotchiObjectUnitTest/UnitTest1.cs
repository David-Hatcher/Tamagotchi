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
            TamagotchiOject to = new TamagotchiOject();
            to.happyAdjust(-5);
            int expected = 45;
            Assert.AreEqual(to.happinessLevel, expected);
        }
        [TestMethod]
        public void TestHungerAdjust()
        {
            TamagotchiOject to = new TamagotchiOject();
            to.hungerAdjust(-5);
            int expected = 45;
            Assert.AreEqual(to.hungerLevel, expected);
        }
        [TestMethod]
        public void TestTiredAdjust()
        {
            TamagotchiOject to = new TamagotchiOject();
            to.tiredAdjust(-5);
            int expected = 45;
            Assert.AreEqual(to.tirednessLevel, expected);
        }
        [TestMethod]
        public void TestFullAdjust()
        {
            TamagotchiOject to = new TamagotchiOject();
            to.fullAdjust(-5);
            int expected = 45;
            Assert.AreEqual(to.fullnessLevel, expected);
        }
        [TestMethod]
        public void TestNameGetSet()
        {
            TamagotchiOject to = new TamagotchiOject();
            to.name = "Jimmy";
            string result = to.name;
            string expected ="Jimmy";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestGenderGetSet()
        {
            TamagotchiOject to = new TamagotchiOject();
            to.gender = "Jimmy";
            string result = to.gender;
            string expected = "Jimmy";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestStatusResponse()
        {
            TamagotchiOject to = new TamagotchiOject();
            to.happinessLevel = 15;
            to.hungerLevel = 70;
            to.fullnessLevel = 100;
            to.tirednessLevel = 10;

            string result = to.tamagotchiNeeds();
            string expected = "like they're about to die from exhaustion.";
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestStatusResponse2()
        {
            TamagotchiOject to = new TamagotchiOject();
            to.happinessLevel = 15;
            to.hungerLevel = 20;
            to.fullnessLevel = 100;
            to.tirednessLevel = 10;

            string result = to.tamagotchiNeeds();
            string expected = "very hungry.";
            Assert.AreEqual(result, expected);
        }


    }
}
