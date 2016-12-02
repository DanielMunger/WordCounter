using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounterTests
{
  public class RepeatCounterTests
  {
      [Fact]
      public void WordCounter_MatchingSingleLetter_One()
      {
        //Arrange
        string _userWord = "a";
        string _userSentence = "a";
        int _instances = 0;
        int _expected = 1;
        //Action
        if(_userWord == _userSentence)
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
        string _userSentence = "ccc";
        int _instances = 0;
        int _expected = 1;
        //Action
        if(_userWord == _userSentence)
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
        string _userSentence = "the cat in the hat";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 2;
        //Action
        _userSentenceArray = _userSentence.Split(' ');
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
        string _userSentence = "the";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 1;
        //Action
        _userSentenceArray = _userSentence.Split(' ');
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
        string _userSentence = "a cat in the hat";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 1;
        //Action
        _userSentenceArray = _userSentence.Split(' ');
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
        string _userSentence = "the cat in the hat";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 2;
        //Action
        _userSentenceArray = _userSentence.Split(' ');
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
        string _userSentence = "thE Cat in The hat";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 2;
        //Action
        _userWord = _userWord.ToLower();
        Console.WriteLine(_userWord);
        _userSentence = _userSentence.ToLower();
        Console.WriteLine(_userSentence);
        _userSentenceArray = _userSentence.Split(' ');
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
      public void WordCounter_IgnoreSymbols_Two()
      {
        //Arrange
        string _userWord = "hat";
        string _userSentence = "thE Cat! in The, hat.";
        string[] _userSentenceArray;
        int _instances = 0;
        int _expected = 1;
        //Action
        _userWord = _userWord.ToLower();
        Console.WriteLine(_userWord);
        _userSentence = _userSentence.ToLower();
        Console.WriteLine(_userSentence);
        _userSentenceArray = _userSentence.Split(' ' , '.' , ',' , '!' , '?');
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
