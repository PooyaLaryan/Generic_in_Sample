DDoSomething<object> doSomething = (object obj) => Console.WriteLine(obj);

DDoSomething<string> doSomethinString = doSomething;
// Using a DDoSomething<object> in place of DDoSomething<string> is legal because of "in"

doSomethinString("text");
// This is safe because string is used in place of object (derived in place of base)

Console.ReadKey();

public delegate void DDoSomething<in A>(A str);