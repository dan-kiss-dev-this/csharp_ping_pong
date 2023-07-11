using System;
using System.Collections.Generic;

namespace PingPong.Models
{
  public class ValueMaker
  {
    public int Number { get; set; }
    public ValueMaker(int input)
    {
      Number = input;
    }

    private List<string> output = new List<string> { };

    public List<string> UpdateList(int input)
    {
      for (int i = 1; i <= input; i++)
      {
        if ((i % 3 == 0) && (i % 5 == 0))
        {
          output.Add("Ping Pong");
        }
        else if (i % 3 == 0)
        {
          output.Add("Ping");
        }
        else if (i % 5 == 0)
        {
          output.Add("Pong");
        }
        else
        {
          output.Add($"{i}");
        }
      }
      return output;
    }

  }
}

