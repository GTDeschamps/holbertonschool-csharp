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

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.Value;
        }
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.next;
            }
        }
    }
}
