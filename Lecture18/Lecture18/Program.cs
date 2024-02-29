
MyNode start0 = new MyNode("ahoj");

MyNode elem1 = new MyNode("dwao");

start0.Next = elem1;

MyNode elem2 = new MyNode("dwaihoawd");
elem1.Next = elem2;


MyNode printNode = start0;
while (true)
{
    Console.WriteLine(printNode.Value);
    printNode = printNode.Next;
    if (printNode == null)
    {
        break;
    }
}

int[] myArray = new int[1];

ILinkedList myLinkedList = new MyBetterLinkedList();

myLinkedList.AddToEnd("dawda");

myLinkedList.AddToEnd("adwai");
myLinkedList.AddToEnd("rqa");
myLinkedList.AddToEnd("dwqd");
myLinkedList.AddToEnd("adwdawd");
