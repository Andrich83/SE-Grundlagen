decimal GetNumber()
{
  decimal num = 0;
  bool checkParse = false;
  do
  {
    Console.WriteLine(" Bitte gib eine Zahl ein ");
    string input = Console.ReadLine();
    checkParse = decimal.TryParse(input, out num);

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
decimal num1 = 0;
decimal num2 = 0;
while (!checkParse1 || !checkParse2)
{
  Console.WriteLine("Bitte gebe Zahl 1 an:");
  string input1 = Console.ReadLine();

  Console.WriteLine("Bitte gebe Zahl 2 an:");
  string input2 = Console.ReadLine();


  // Konvertierung von Text zu Zahlen
  checkParse1 = decimal.TryParse(input1, out num1);
  checkParse2 = decimal.TryParse(input2, out num2);
}
var result = num1 + num2;
Console.WriteLine($"{num1} + {num2} = {result}");
*/

// Entweder (Var), Oder (Datentyp eg. string, decimal, float, decimal,...)
//string test1 = "Buxtehude";
//decimal test2 = 69;
//var test3 = "Buxtehude";
//test3 = 69;
//var decimal x = 420; // "Var" ist nicht kombinierbar mit Datentypenangaben


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

decimal Calculate(decimal num1, decimal num2, string operation)
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
while (true)
{
  // get user input
  var num1 = GetNumber();
  var num2 = GetNumber();
  var operation = GetOperation();


  // calculate result
  var result = Calculate(num1, num2, operation);
  // Display output
  Console.WriteLine($"{num1} {num2} {operation} = {result}");
  Console.WriteLine("------------------------------------------------------------");
}


