using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Leetspeak.Models;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTest : IDisposable
  {
    [TestMethod]
    public void ChangeLetter_EToThree_Three()
    {
      //Arrange
      List<string> expected = new List<string> {"m3"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("me");

      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_OToZero_Zero()
    {
      //Arrange
      List<string> expected = new List<string> {"f0r"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("for");

      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_ItoOne_One()
    {
      //Arrange
      List<string> expected = new List<string> {"1f"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("If");
      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_TToSeven_Seven()
    {
      //Arrange
      List<string> expected = new List<string> {"a7"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("at");
      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_SToZ_Z()
    {
      //Arrange
      List<string> expected = new List<string> {"az"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("as");
      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_FirstLetterSNoChange_S()
    {
      //Arrange
      List<string> expected = new List<string> {"zay"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("say");
      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }


    public void Dispose()
    {
      LeetspeakTranslator.ClearAll();
    }
  }
}
