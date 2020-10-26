using System;

/// <summary>
/// New Queue Class
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Public method that returns the Queue's type
    /// </summary>
    public string CheckType()
    {
        string QueueType = typeof(T).ToString();
        return(QueueType);
    }
}
