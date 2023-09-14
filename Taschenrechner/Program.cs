int GetNumber()
{
  int num = 0;
  bool checkParse = false;
  do
  {
    Console.WriteLine(" Bitte gib eine Zahl ein ");
    string input = Console.ReadLine();
    checkParse = int.TryParse(input, out num);

    if (checkParse == false)
    {
      Console.WriteLine("Falsche Zahl, nur ganze Zahlen du Seggl");
    }
  } while (checkParse == false);
  return num;
}

/*
Console.WriteLine("Willkommen beim Taschenrechner 3000");
bool checkParse1 = false;
bool checkParse2 = false;
int num1 = 0;
int num2 = 0;
while (!checkParse1 || !checkParse2)
{
  Console.WriteLine("Bitte gebe Zahl 1 an:");
  string input1 = Console.ReadLine();

  Console.WriteLine("Bitte gebe Zahl 2 an:");
  string input2 = Console.ReadLine();


  // Konvertierung von Text zu Zahlen
  checkParse1 = int.TryParse(input1, out num1);
  checkParse2 = int.TryParse(input2, out num2);
}
var result = num1 + num2;
Console.WriteLine($"{num1} + {num2} = {result}");
*/

// Entweder (Var), Oder (Datentyp eg. string, int, float, decimal,...)
//string test1 = "Buxtehude";
//int test2 = 69;
//var test3 = "Buxtehude";
//test3 = 69;
//var int x = 420; // "Var" ist nicht kombinierbar mit Datentypenangaben


string GetOperation()
{
  string operation;
  bool validOperation;

  do
  {
    Console.Write("Enter a valid operation (+, -, *, /): ");
    operation = Console.ReadLine();
    validOperation = (operation == "+" || operation == "-" || operation == "*" || operation == "/");

    if (validOperation == false) ;
    {
      Console.WriteLine("Invalid operation. Please try again.");
    }
    
  } while (validOperation == false);


  return operation;
}

int Calculate(int num1, int num2, string operation)
{
  switch (operation)
  {
    case "+": return num1 + num2;
    case "-": return num1 - num2;
    case "*": return num1 * num2;
    case "/": return num1 / num2;
    default:
      Console.WriteLine("Ungültige Operation: Mögliche Werte sind + - * /");
      return 0;
  }
}

Console.WriteLine("Willkommen beim Taschenrechner 3000?");

var num1 = GetNumber();
var num2 = GetNumber();
var operation = GetOperation();

var result = Calculate(num1, num2, operation);

Console.WriteLine($"{num1} {num2} {operation} = {result}");