using System;

/// <summary>
/// New Queue Class
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Public class Node
    /// </summary>
    public class Node
    {
        private T value;
        /// <summary>
        /// Public Value
        /// </summary>
        public T Value
        {
            get { return value; }
            set { value = default(T); }
        }

        private Node next;
        /// <summary>
        /// Public Next
        /// </summary>
        public Node Next
        {
            get { return next; }
            set { next = null; }
        }

        /// <summary>
        ///
        /// </summary>
        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    /// <summary>
    /// Public method that returns the Queue's type
    /// </summary>
    public string CheckType()
    {
        string QueueType = typeof(T).ToString();
        return(QueueType);
    }


    Node head;
    Node tail;
    int count;

    /// <summary>
    /// Public method that creates a new Node and adds
    /// it to the end of the queue
    /// </summary>
    public void Enqueue(T value)
    {
        if (head == null)
        {
            Node n = new Node(value);
            n.Next = null;
            head = n;
            count = Count();
        }
        /*else
        {
            Node n = new Node(t);
            n.Next = null;
            head = n;
            count = Count();
        }*/
    }

    /// <summary>
    /// Public method that returns the number of nodes
    /// in the Queue
    /// </summary>
    public int Count()
    {
        Node current = head;

        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return(count);
    }
}
