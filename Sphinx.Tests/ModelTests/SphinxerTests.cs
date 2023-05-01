using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      string expected = "what is Kyle's middle name?";
      Assert.AreEqual(expected, Riddle.Question1);
    }

    [TestMethod]
    public void CheckQuestion1_ChecksIfInputIsEqualToAnswer_Bool()
    {
      string input = "joseph";
      Assert.AreEqual(true, Riddle.CheckQuestion1(input));
    }
  }
}