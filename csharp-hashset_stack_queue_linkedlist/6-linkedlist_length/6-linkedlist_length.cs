using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int length = 0;

         LinkedListNode<int> currentNode = myLList.First;
         while (currentNode != null)
         {
            length++;
            currentNode = currentNode.Next;
         }
         return length;
    }
}

