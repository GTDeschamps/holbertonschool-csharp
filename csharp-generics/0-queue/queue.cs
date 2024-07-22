using System;

/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Checks the type of elements in the queue.
    /// </summary>
    /// <returns>The name of the type of elements in the queue.</returns>
    public string CheckType()
    {
        return typeof(T).Name;
    }
}
