using System;
using PingPong.Models;
using System.Collections.Generic;

namespace PingPong
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a number to see ping pong for");
      int userInput = Int32.Parse((Console.ReadLine()));
      Console.WriteLine("-----------");
      OutputValues(userInput);
      Main();
    }

    static void OutputValues(int input)
    {
      ValueMaker newValueMaker = new ValueMaker(input);
      List<string> outputs = newValueMaker.UpdateList(input);
      for (int i = 0; i < input; i++)
      {
        Console.WriteLine(outputs[i]);
      }
      Console.WriteLine("-----------");
    }
  }
}