﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDishes
{
    public class GroupingDishes
    {
        Dictionary<string, int> ingredientCount = new Dictionary<string, int>();

        public string[][] GroupDishes(string[][] dishes)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> AddIngredientsAndCountsToDictionary(string[][] dishes)
        {
            for (int row = 0; row < dishes.Length; row++)
            {
                for (int col = 1; col < dishes[row].Length; col++)
                {
                    if (ingredientCount.ContainsKey(dishes[row][col]))
                        ingredientCount[dishes[row][col]]++;
                    else
                        ingredientCount.Add(dishes[row][col], 1);
                }
            }

            return ingredientCount;
        }
        
        public Dictionary<string, List<string>> AddIngredientsAndListOfDishesToDictionary(string[][] dishes)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

          //  List<string> dishesToAdd;

            for (int row = 0; row < dishes.Length; row++)
            {
                for (int col = 1; col < dishes[row].Length; col++)
                {
                    if (ingredientCount.ContainsKey(dishes[row][col]))
                    {

                    }



                    // List<string> test = 

                

                    Console.WriteLine(dishes[row][col]);
                }
            }

            return result;
        }

    }

}