using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MainProject
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello!");
      for(var i = 0; i < args.Length; i++) {
        Console.WriteLine(args[i]);
      }
      var abc = new List<string>(2) {
        "abc",
        "efg",
        "wdlkjg"
      };
      foreach (var item in abc)
        Console.WriteLine(item);
      Console.WriteLine("bye-bye");
    }
  }
}

