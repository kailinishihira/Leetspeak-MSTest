using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Leetspeak.Models;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTest
  {
    [TestMethod]
    public void ChangeLetter_EToThree_Three()
    {
      //Arrange
      string inputWord = "3at";
      LeetspeakTranslator newWord = new LeetspeakTranslator(inputWord);

      //Act
      string result = newWord.GetInputWord();

      //Assert
      Assert.AreEqual(result, inputWord);
    }
  }
}
