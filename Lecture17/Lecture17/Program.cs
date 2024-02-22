
Stack myStack = new Stack(10);

myStack.Add(4);
myStack.Add(5);
myStack.Add(-486);

int gotFromStack = myStack.Get();
Console.WriteLine(gotFromStack);

Console.WriteLine(myStack.Get());

myStack.Add(16);
myStack.Add(-42);

Console.WriteLine(myStack.Get());
Console.WriteLine(myStack.Get());
Console.WriteLine(myStack.Get());
