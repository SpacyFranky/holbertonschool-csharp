using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return("None");

        int max = int.MinValue;;
        string key = "";
        foreach(var item in myList)
        {
            if (myList[item.Key] > max)
            {
                max = myList[item.Key];
                key = item.Key;
            }
        }
        return(key);
    }
}
