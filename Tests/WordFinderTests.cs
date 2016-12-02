using System;
using System.Collections.Generic;
//using WordCounter.Objects;
using Xunit;

namespace WordCounterTests
{
  public class WordCounterTests
  {
      [Fact]
      public void WordCounter_MatchingSingleLetter_One()
      {
        //Arrange
        string _userWord = "a";
        string _userSentece = "a";
        int _instances = 0;
        int _expected = 1;
        //Action
        if(_userWord == _userSentece)
        {
          _instances += 1;
        }
        //Assert
        Assert.Equal(true, _instances == _expected);
      }
      [Fact]
      public void WordCounter_MatchingMultipleLetters_One()
      {
        //Arrange
        string _userWord = "ccc";
        string _userSentece = "ccc";
        int _instances = 0;
        int _expected = 1;
        //Action
        if(_userWord == _userSentece)
        {
          _instances += 1;
        }
        //Assert
          Assert.Equal(true, _instances == _expected);
      }
      [Fact]
      public void WordCounter_MatchingMultipleLettersAnywhere_One()
      {
        //Arrange
        string _userWord = "the";
        string _userSentece = "the cat in the hat";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 2;
        //Action
        _userSentenceArray = _userSentece.Split(' ');
        for(int i = 0; i <= _userSentenceArray.Length -1; i++)
        {
          if(_userWord == _userSentenceArray[i])
          {
            _instances += 1;
          }
        }
        //Assert
        Assert.Equal(true, _instances == _expected);
      }
      // [Fact]
      // public void WordCounter_DifferentCharacters_One()
      // {
      //   //Arrange
      //   //Action
      //   //Assert
      // }
      // [Fact]
      // public void WordCounter_DifferentCharactersAnywhere_One()
      // {
      //   //Arrange
      //   //Action
      //   //Assert
      // }
      // [Fact]
      // public void WordCounter_DifferentCharactersMultiple_Two()
      // {
      //   //Arrange
      //   //Action
      //   //Assert
      // }
      // [Fact]
      // public void WordCounter_CaseInsensitive_Two()
      // {
      //   //Arrange
      //   //Assert
      //   //Action
      // }

  }
}
