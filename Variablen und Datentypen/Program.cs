#region Variablen
// VariablenDeklarieren
string name;
int age;
object random;
float height;
// Variablen sind erst nach einer Deklaration verwendbar
// Console.WriteLine(age); --> funtioniert erst nach der Initialisierung

// Variablen Initialisierung / Assignment
name = "Default";
age = 0;
random = new object();
height = 0.0f;

// Deklaration und Initialisierung
int abc = 42;
string hello = "Hello";
var blubb = Console.ReadLine();

int i = 0;
while (i<5)
{
  var xyz = 10;
  Console.WriteLine(hello);
} // Wenn ein Codeblock geschlossen wird, sind alle Variablen, die innerhalb des Blocks deklariert wurden, nicht mehr gültig. --> können nicht mehr verwendet werden.
  // xyz --> Gehr nicht, da xyz in anderem Scope ist

//var xyz = 20; Variable kann aber neu deklariert werden

#endregion

#region Datentypen
// Primitive Datentypen --> Werte Typen, Value Types
bool boolean = false || true;
int ganzzahl = 200;
// ganzzahl = 500;
// Int16 test = 0; --> würde man nie verwenden, da der "normale" int dynamisch ist
float width = 1.0f;
double depth = 1.0;
decimal moneten = 9000000.627;
var testfloat = 1.0d;
char sign = 'a';
char letter = 'A';
#endregion

#region Komplexe-Datentypen
// Komplexe Typen --> Referenz-Typen
object myObject = new object();
string greeting = "Hello";
//dynamic myDynamic;
#endregion

#region WerteVSReferenz-Typen
int num1 = 10;

string mystring = "testme";

var num2 = num1;

var mystring2 = mystring;

num1 = num1 +1;
mystring = mystring + "mimimi";

Console.WriteLine(mystring2);
Console.WriteLine(num2);
#endregion