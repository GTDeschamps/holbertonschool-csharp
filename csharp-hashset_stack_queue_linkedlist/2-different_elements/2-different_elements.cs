using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> allElements = new HashSet<int>();
        HashSet<int> commonElements = new HashSet<int>();

        foreach (int num in list1)
        {
            allElements.Add(num);
        }

        foreach (int num in list2)
        {
            if (!allElements.Add(num))
            {
                commonElements.Add(num);
            }
        }

        foreach (int num in commonElements)
        {
            allElements.Remove(num);
        }

        List<int> differentElements = new List<int>(allElements);
        differentElements.Sort();

        return differentElements;
    }
}

