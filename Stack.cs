using System.Collections;

namespace LinearDataStructures;

public class Stack<T> : IEnumerable
{
    private int count = 0;
    private Node<T> top;

    public int Count { get { return count; } }

    public void Push(T element)
    {
        Node<T> newNode = new Node<T>()
        {
            Value = element,
            Next = this.top
        };

        this.top = newNode;
        count++;
    }

    public T Peek()
    {
        CheckIsValid();

        return this.top.Value;
    }

    public T Pop()
    {
        CheckIsValid();

        var oldTop = this.top.Value;
        this.top = this.top.Next;

        count--;
        return oldTop;
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

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
