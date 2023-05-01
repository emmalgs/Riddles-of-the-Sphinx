using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sphinx.Models;

namespace Sphinx.Tests
{
  [TestClass]
  public class SphinxerTests
  {

    [TestMethod]
    public void RiddleDictionary_IsInstanceOfDictionary_Dictionary()
    {
      Riddle newRiddle = new Riddle();
      Assert.AreEqual(typeof(Riddle), newRiddle.GetType());
    }
  }
}