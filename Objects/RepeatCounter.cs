using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {
    private string _userWord;
    private string _userSentece;
    private string[] _userSentenceArray;
    private int _instances = 0;

    public RepeatCounter(string UserWord, string UserSentence)
    {
    _userWord = UserWord;
    _userSentece = UserSentence;
    }

    public int RepeatCounts()
    {
      _userWord = _userWord.ToLower();
      _userSentece = _userSentece.ToLower();
      _userSentenceArray = _userSentece.Split(' ');
      for(int i = 0; i <= _userSentenceArray.Length -1; i++)
      {
        if(_userWord == _userSentenceArray[i])
        {
          _instances += 1;
        }
      }
      Console.WriteLine(_instances);
      return _instances;
    }
  }
}
