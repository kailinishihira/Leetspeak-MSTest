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
      List<string> expected = new List<string> {"n30n"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("neon");

      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_ItoOne_One()
    {
      //Arrange
      List<string> expected = new List<string> {"1nf3ri0r"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("Inferior");
      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_TToSeven_Seven()
    {
      //Arrange
      List<string> expected = new List<string> {"1n73ri0r"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("Interior");
      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_SToZ_Z()
    {
      //Arrange
      List<string> expected = new List<string> {"1n73ri0rz"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("Interiors");
      List<string> actual = newWord.ChangeLetter();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ChangeLetter_FirstLetterSNoChange_S()
    {
      //Arrange
      List<string> expected = new List<string> {"z007z"};

      //Act
      LeetspeakTranslator newWord = new LeetspeakTranslator("Soots");
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
