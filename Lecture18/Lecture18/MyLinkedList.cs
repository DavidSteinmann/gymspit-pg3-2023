
class MyLinkedList : ILinkedList
{
    public MyNode Start;
    public MyNode End;

    public int Length;

    public void AddToEnd(string value)
    {
        MyNode node = new MyNode(value);
        if (End != null)
        {
            End.Next = node;
            End = node;
        }
        else
        {
            Start = node;
            End = node;
        }

        Length += 1;
    }
}
