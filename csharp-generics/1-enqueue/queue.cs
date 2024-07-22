using System;

class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = head;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public int Count()
    {
        return count;
    }
    /// <summary>
    /// create new Node.
    /// </summary>
    /// <returns>The new Node.</returns>
    public class Node
    {
        public T Value { get; set; }
        public Node next { get; set; }
        public Node(T value)
        {
            this.Value = value;
            this.next = null;
        }
    }
}
