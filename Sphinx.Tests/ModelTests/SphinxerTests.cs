using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx.Tests
{
    [TestClass]
    public class SphinxerTests
    {

        [TestMethod]
        public void Riddle_IsInstanceOfRiddle_Riddle()
        {
            Riddle newRiddle = new Riddle();
            Assert.AreEqual(typeof(Riddle), newRiddle.GetType());
        }

        [TestMethod]
        public void Riddles_IsInstanceOfDictionary_Dictionary()
        {
            Riddle newRiddle = new Riddle();
            Dictionary<string, string> expected = new Dictionary<string, string> {};
            Dictionary<string, string> result = newRiddle.Riddles;
            CollectionAssert.AreEqual(expected, result);
        }

				
    }
}