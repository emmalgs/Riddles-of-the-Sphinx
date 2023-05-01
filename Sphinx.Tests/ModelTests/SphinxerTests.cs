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

    // [TestMethod]
    // public void Riddles_HasKeyOfRiddleAndValueOfAnswer_String()
    // {
    //   Riddle newRiddle = new Riddle();
    //   Dictionary<string, string> expected = new Dictionary<string, string> {{ "kyle", "what is probably 6 feet tall and definitely stupid"}, {"a bottle", "what best describes the shape of kyle's head?"}, {"kyle's shirt", "what is sweaty and probably grey?"}};
    //   Dictionary<string, string> result = newRiddle.Riddles;
    //   CollectionAssert.AreEqual(expected, result);
    // }

    [TestMethod]
    public void Question1_GetsQuestion1_String()
    {
      Riddle newRiddle = new Riddle();
      string expected = "what is Kyle's middle name?";
      Assert.AreEqual(expected, newRiddle.Question1);
    }

    [TestMethod]
    public void CheckQuestion1_ChecksIfInputIsEqualToAnswer_Bool()
    {
      Riddle newRiddle = new Riddle();
      string input = "joseph";
      Assert.AreEqual(true, newRiddle.CheckQuestion1(input));
    }
  }
}