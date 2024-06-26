﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int max = myList[0];
        foreach(int current in myList)
        {
            if (current > max)
            {
                max = current;
            }
        }
        return max;
   }
}

