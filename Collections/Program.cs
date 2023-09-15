#region
// Collections / Sammlungen
int[] ints = new int[10];
int[] ints1 = { 1, 2, 3 };

for (int i = 0; i < ints.Length; i++)
{

  ints[i] = i;
}

Console.WriteLine(string.Join(',', ints));

Console.WriteLine(ints[1]);

ints[1] = 952;

Console.WriteLine(string.Join(',', ints));

ints = new int[20];
ints[0] = 10;
Console.WriteLine(string.Join(',', ints));
var newInts = ints.Append(20);
Console.WriteLine("ints: " + string.Join(',', ints));
Console.WriteLine("Newints: " + string.Join(',', ints));

#endregion


#region Lists
//Listen

List<string> names = new();

names.Add("Tobias Wehrle");
names.Add("André");
names.Add("Marley");

Console.WriteLine(string.Join(", ", names));
names.Remove("Tobias Wehrle");
names.Remove(names[1]);

Console.WriteLine(string.Join(", ", names));

if (names.Contains("Marley"))

{
  Console.WriteLine("Marley ist in der Liste");
}

names.Sort();

Console.WriteLine(string.Join(", ", names));

List<int> intList = new List<int>() { 20, 40, 10, 12, 42, 13 };
intList.Sort();
Console.WriteLine(string.Join(", ", intList));

Console.WriteLine("FOR-EACH");
foreach (var name in names)
{
  Console.WriteLine(name);
}
for(int i = 0; i < 10; i++)
{
  Console.WriteLine("FOR");
}

#endregion