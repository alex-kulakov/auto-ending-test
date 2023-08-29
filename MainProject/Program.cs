using System;
using System.Text;
using System.Linq;
using System.Collections;
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
    }
  }
}

