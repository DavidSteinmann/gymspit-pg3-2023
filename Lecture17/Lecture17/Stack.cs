
class Stack
{
    int[] array;

    int lastIndex;

    public Stack(int capacity)
    {
        array = new int[capacity];
    }

    public int Get()
    {
        int readValue = array[lastIndex];
        lastIndex = lastIndex - 1;
        return readValue;
    }

    public void Add(int value)
    {
        array[lastIndex + 1] = value;
        lastIndex = lastIndex + 1;
    }
}
