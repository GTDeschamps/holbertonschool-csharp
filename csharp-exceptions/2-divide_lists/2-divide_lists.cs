using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
    List<int> resultList = new List<int>();
        try
        {
            for (int i = 0; i < listLength; i++)
            {
                // Check if index is out of range for either list
                if (i >= list1.Count || i >= list2.Count)
                {
                    Console.WriteLine("Out of range");
                    break;
                }

                // Divide element by element, handle division by zero
                try
                {
                    int result = list2[i] != 0 ? list1[i] / list2[i] : 0;
                    resultList.Add(result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    resultList.Add(0);
                }
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }

        return resultList;
    }
}
