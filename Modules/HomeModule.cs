using System;
using System.Collections.Generic;
using WordCounter.Objects;
using Nancy;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get[""] = _ => {
        //Action Here
        return View["place.cshtml", Model];
      };
    }
  }
}
