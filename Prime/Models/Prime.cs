using System.Collections.Generic;
using System;

namespace Prime.Models
{
  public class PrimeClass
  {
    public string PrimeSift (int num)
      {
        List<int> PrimeList = new List<int>();
        for (int i = 2; i < num; i++) 
        {
          PrimeList.Add(i);
        }

        for (int j = 2; j < num; j++) 
        {
          if (num % j != 0)
          {
            PrimeList.Remove(j);
          }
        }
      return string.Join("", PrimeList.ToArray());
    }
  }
}