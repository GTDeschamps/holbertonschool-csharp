using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        List<int> commonElements = new List<int>();

        foreach (int num in list2)
        {
            if( set1.Contains(num))
            {
                commonElements.Add(num);
                set1.Remove(num);
            }
        }
        commonElements.Sort();
        return commonElements;
    }
}

