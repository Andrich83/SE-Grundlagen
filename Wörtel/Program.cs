/*
 * Programmstart:
 * 
 * Definiere SolutionWord als das zu erratende Wort
 * 
 * Schleife:
 * 
 *  Definiere guess und speichere das vom User eingegebene Wort
 *  Schleife für jeden Buchstaben im guess:
 *    Schleife für jeden Buchstaben im SolutionWord:
 *      Prüfe Buchstabe aus guess gleich Buchstabe in SolutionWord
 *        Wahr: 
 * 
 * */

var SolutionWord = "Hotel";

string guess;

while (true) 
{
  Console.WriteLine("Errate das 5-Stellige Wort");
  guess = Console.ReadLine();
  if (guess.Length != 5) continue;

  /*foreach (char c in guess)
  {
    if (SolutionWord.Contains(c))
       Console.BackgroundColor = ConsoleColor.Yellow;
    if (/* ...*/)
   //   Console.BackgroundColor = ConsoleColor.Green;
  //  Console.WriteLine($"{c}");
  }


  // Gedankenspiel

  for(int i = 0; i < guess.Length; i++)
  {
    if (SolutionWord.Contains(guess[i]))
      Console.BackgroundColor = ConsoleColor.Yellow;
    if (SolutionWord[i] == guess[i])
      Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine($"{guess[i]}");

  }
