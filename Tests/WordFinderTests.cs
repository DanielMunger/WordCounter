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
        string _userSentece = "";
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
    

  }
}
