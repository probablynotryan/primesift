using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Prime.Models;

namespace Prime.TestTools
{
  [TestClass]
  public class PrimeTests
  {
    [TestMethod]
    public void PrimeSift_FourReturnsTwo_Two()
    {
      PrimeClass testPrime = new PrimeClass();
      Assert.AreEqual("2", testPrime.PrimeSift(4));
    }
    [TestMethod]
    public void PrimeSift_16Returns_248()
    {
      PrimeClass testPrime = new PrimeClass();
      Assert.AreEqual("248", testPrime.PrimeSift(16));
    }
  }
}