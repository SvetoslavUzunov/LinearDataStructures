namespace LinearDataStructures;

public class LinkedList<T>
{
    private int count = 0;
    public Node<T> Head { get; set; }
    public Node<T> Last { get; set; }
    public int Count { get { return count; } }

    public void AddFirst(T element)
    {
        Node<T> newHead = new Node<T>(element, null);

        if (Head == null)
        {
            Last = newHead;
        }

        newHead.Next = Head;
        Head = newHead;
        count++;
    }

    public void AddLast(T element)
    {
        Node<T> newLast = new Node<T>(element, null);

        if (Last == null)
        {
            Last = newLast;
            Head = newLast;
        }
        else
        {
            Last.Next = newLast;
            Last = newLast;
        }
        count++;
    }

    public Node<T> RemoveFirst()
    {
        var oldHead = Head;
        Head = Head.Next;

        if (Head == null)
        {
            Last = null;
        }

        if (count > 0)
        {
            count--;
        }
        else
        {
            throw new InvalidOperationException();
        }

        return oldHead;
    }

    public Node<T> RemoveLast()
    {
        var oldLast = Last;
        var current = Head;
        for (int i = 1; i <= count; i++)
        {
            if (i == count - 1)
            {
                Last = current;
                break;
            }
            current = current.Next;
        }

        if (count > 0)
        {
            count--;
        }
        else
        {
            throw new InvalidOperationException();
        }

        return oldLast;
    }

    public Node<T> GetFirst()
    {
        if (count > 0)
        {
            return Head;
        }
        throw new InvalidOperationException();
    }

    public Node<T> GetLast()
    {
        if (count > 0)
        {
            return Last;
        }
        throw new InvalidOperationException();
    }
}