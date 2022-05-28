using System.Collections;

namespace LinearDataStructures;

public class Queue<T> : IEnumerable
{
    private int count = 0;
    private Node<T> top = null;

    public int Count { get { return count; } }

    public void Enqueue(T element)
    {
        Node<T> newNode = new Node<T>(element, null);

        if (this.top == null)
        {
            this.top = newNode;
        }
        else
        {
            this.top.Next = newNode;
        }
        count++;
    }

    public T Peek()
    {
        CheckIsValid();
        return this.top.Value;
    }

    public T Dequeue()
    {
        CheckIsValid();
        var oldTop = this.top;
        this.top = this.top.Next;

        count--;
        return oldTop.Value;
    }

    public void CheckIsValid()
    {
        if (count <= 0)
        {
            throw new InvalidOperationException();
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = this.top;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}