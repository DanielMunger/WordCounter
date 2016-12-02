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
      [Fact]
      public void WordCounter_DifferentCharacters_One()
      {
        //Arrange
        string _userWord = "the";
        string _userSentece = "the";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 1;
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
      [Fact]
      public void WordCounter_DifferentCharactersAnywhere_One()
      {
        //Arrange
        string _userWord = "the";
        string _userSentece = "a cat in the hat";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 1;
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
      [Fact]
      public void WordCounter_DifferentCharactersMultiple_Two()
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
      [Fact]
      public void WordCounter_CaseInsensitive_Two()
      {
        //Arrange
        string _userWord = "tHe";
        string _userSentece = "thE Cat in The hat";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 2;
        //Action
        _userWord = _userWord.ToLower();
        Console.WriteLine(_userWord);
        _userSentece = _userSentece.ToLower();
        Console.WriteLine(_userSentece);
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
  }
}
