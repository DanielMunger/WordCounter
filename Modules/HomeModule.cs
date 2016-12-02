using System;
using System.Collections.Generic;
using Repeat.Objects;
using Nancy;

namespace RepeatCounterNancy
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ => {
        string UserWord = Request.Form["user-word"];
        string UserSentence = Request.Form["user-sentence"];
        RepeatCounter newCounter = new RepeatCounter(UserWord, UserSentence);
        int result = newCounter.RepeatCounts();
        return View["result.cshtml", result];
      };
    }
  }
}
