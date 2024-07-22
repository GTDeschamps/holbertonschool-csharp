using System;

/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    public void Enqueue(T value)
    /// <summary>
    /// add the new node at the end of the queue
    /// </summary>
    /// <returns> the end of queue </returns>
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
    /// <summary>
    /// count the number of Node
    /// </summary>
    /// <returns> the number of Node </returns>
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

    public T Dequeue()
    /// <summary>
    /// Removes the first node in the queue and returns its value.
    /// </summary>
    /// <returns>The value of the removed node, or the default value of T if the queue is empty.</returns>
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T temp = head.Value;
            head = head.next;
            count--;
            return temp;
        }
    }
}
