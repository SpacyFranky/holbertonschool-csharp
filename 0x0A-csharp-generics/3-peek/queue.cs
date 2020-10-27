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
        /// <summary>
        /// Node value property
        /// </summary>
        public T value
        {
            get;
            set;
        }

        /// <summary>
        /// Node next property
        /// </summary>
        public Node next
        {
            get;
            set;
        }

        /// <summary>
        /// Node Constructor
        /// </summary>
        public Node(T value)
        {
            this.value = value;
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


    /// <summary>
    /// Head of the queue
    /// </summary>
    public Node head { get; set; }
    /// <summary>
    /// Tail of the queue
    /// </summary>
    public Node tail { get; set; }
    private int count;

    /// <summary>
    /// Public method that creates a new Node and adds
    /// it to the end of the queue
    /// </summary>
    public void Enqueue(T value)
    {
        Node n = new Node(value);

        if (head == null && tail == null)
        {
            head = n;
            tail = n;
        }
        else
        {
            tail.next = n;
            tail = tail.next;
        }
    }

    /// <summary>
    /// Public method that removes the first node in the queue
    /// and returns its value
    /// </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        else
        {
            Node tmp = new Node(default(T));
            tmp = head;
            head = head.next;
            return(tmp.value);
        }
    }

    /// <summary>
    /// Public method that returns the value of the first
    /// node of the queue without removing the node
    /// </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        return(head.value);
    }

    /// <summary>
    /// Public method that returns the number of nodes
    /// in the Queue
    /// </summary>
    public int Count()
    {
        Node current = head;

        count = 0;
        while (current != null)
        {
            count++;
            current = current.next;
        }

        return(count);
    }
}
