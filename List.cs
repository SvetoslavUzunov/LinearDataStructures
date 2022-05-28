namespace LinearDataStructures;

public class List<T> 
{
    private T[] array;
    private int index = 0;

    public int Count { get { return index; } }

    public List(int initialCapacity = 4)
    {
        array = new T[initialCapacity];
    }

    public T this[int i]
    {
        get
        {
            try
            {
                return array[i];
            }
            catch
            {
                throw new IndexOutOfRangeException();
            }
        }
        set
        {
            try
            {
                array[i] = value;
            }
            catch
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public void Add(T element)
    {
        if (index == array.Length)
        {
            array = DoubleArraySize(array);
        }

        array[index++] = element;
    }

    public void Insert(int index, T element)
    {
        try
        {
            array[index] = element;
        }
        catch
        {
            throw new IndexOutOfRangeException();
        }
    }

    public void RemoveAt(int index)
    {
        try
        {
            Array.Clear(array, index, 1);
        }
        catch
        {
            throw new IndexOutOfRangeException();
        }
    }


    public bool Contains(T element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(element))
            {
                return true;
                break;
            }
        }
        return false;
    }

    public int IndexOf(T element)
    {
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index].Equals(element))
            {
                return index;
            }
        }
        return -1;
    }

    public bool Remove(T element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(element))
            {
                Array.Clear(array, i, 1);
                return true;
            }
        }
        return false;
    }

    private T[] DoubleArraySize(T[] array)
    {
        T[] newArray = new T[array.Length * 2];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }

        return newArray;
    }

    public int CompareTo(List<T>? other)
    {
        throw new NotImplementedException();
    }
}