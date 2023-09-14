void printHello()
{
  Console.WriteLine("Hallo");
}

string getHello()
{
  return "Hello";
}

void printGreeting(string name, int itercount = 1)
{
  int i = 0;
  while (i < 10)
  {
    Console.WriteLine($"Hello {name}");
    i++;
  }
}
printHello();

var hello = getHello();

hello = hello + " shut up and go away";

Console.WriteLine(hello);

Console.WriteLine("Nenne mir deinen Name, Rübennase");
var inputName = Console.ReadLine();

printGreeting(inputName, 20);

Console.WriteLine("Du solltest mehr ITIL lernen!");

printGreeting(inputName);

//printGreeting(name: inputName, itercount: 10);
//printGreeting(itercount: 40, name: "Olaf");
//printGreeting(itercount: 40, name: inputName);