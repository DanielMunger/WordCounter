using System;
using System.Collections.Generic;
using Xunit;
using Repeat.Objects;

namespace Repeat.Tests
{
  public class RepeatCounterTests
  {
      [Fact]
      public void WordCounter_UnmatchingSingleLetter_Zeros()
      {
        //Arrange
        string userWord = "a";
        string userSentence = "b";

        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);

        int result = testRepeat.RepeatCounts();
        int expected = 0;
        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_MatchingSingleLetter_One()
      {
        //Arrange
        string userWord = "a";
        string userSentence = "a";

        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);

        int result = testRepeat.RepeatCounts();
        int expected = 1;
        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_MatchingMultipleLetters_One()
      {
        //Arrange
        string userWord = "ccc";
        string userSentence = "ccc";
        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);
        int result = testRepeat.RepeatCounts();

        int expected = 1;
        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_MatchingMultipleLettersAnywhere_One()
      {
        //Arrange
        string userWord = "the";
        string userSentence = "the cat in the hat";
        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);

        int result = testRepeat.RepeatCounts();
        int expected = 2;

        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_DifferentCharacters_One()
      {
        //Arrange
        string userWord = "the";
        string userSentence = "the";

        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);
        int result = testRepeat.RepeatCounts();

        int expected = 1;

        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_DifferentCharactersAnywhere_One()
      {
        //Arrange
        string userWord = "the";
        string userSentence = "a cat in the hat";
        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);

        int result = testRepeat.RepeatCounts();
        int expected = 1;

        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_DifferentCharactersMultiple_Two()
      {
        //Arrange
        string userWord = "the";
        string userSentence = "the cat in the hat";
        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);

        int result = testRepeat.RepeatCounts();
        int expected = 2;

        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_CaseInsensitive_Two()
      {
        //Arrange
        string userWord = "tHe";
        string userSentence = "thE Cat in The hat";
        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);

        int result = testRepeat.RepeatCounts();
        int expected = 2;

        Assert.Equal(expected, result);
      }
      [Fact]
      public void WordCounter_IgnoreSymbols_Two()
      {
        //Arrange
        string userWord = "hat";
        string userSentence = "thE Cat! in The, hat.";
        RepeatCounter testRepeat = new RepeatCounter(userWord, userSentence);

        int result = testRepeat.RepeatCounts();
        int expected = 1;

        Assert.Equal(expected, result);

      }
  }
}
