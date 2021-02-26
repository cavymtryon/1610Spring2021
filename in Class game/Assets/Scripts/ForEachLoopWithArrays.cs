using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] bugs = {"Ladybug", "Rollypolly", "Stickbug", "Butterfly"};
      foreach (string i in bugs) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}