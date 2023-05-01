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