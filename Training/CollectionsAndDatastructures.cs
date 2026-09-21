using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Training 
{
    public class CollectionsAndDatastructures
    {
        public CollectionsAndDatastructures()
        {
     
        }
        public void findDuplicates(List<int> numbers)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                for(int j = i + 1; j < numbers.Count; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        Console.Write("\nDuplikat gefunden bei " + numbers[i] + " und bei " + numbers[j]);
                    }
                }
            }
        }
    }
}