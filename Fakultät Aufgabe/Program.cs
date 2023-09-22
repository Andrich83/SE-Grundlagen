/*
 * 
 * 3. Berechne die Fakultät einer Zahl:
	Aufgabenstellung: Schreibe eine Funktion in Pseudocode, die die Fakultät einer gegebenen Zahl berechnet. 
	Die Fakultät einer Zahl n ist das Produkt aller positiven ganzen Zahlen von 1 bis n und wird als n! bezeichnet (zum Beispiel: 5! = 5 × 4 × 3 × 2 × 1 = 120).

	Die Funktion sollte einen Parameter, der die Zahl repräsentiert, für die die Fakultät berechnet werden soll.
	Die Funktion sollte die Fakultät dieser Zahl zurückgeben.

(6! = 6 x 5 x 4 x 3 x 2 x 1)

Pseudocode:


----------

Parameter: Variable `n`
Setze Variable `i` auf den Wert `n`
Setze Variable Ergebnis auf den Wert von `n`

Schleife: bis `i` = 1;
		Dekrement `i` um 1
		Setze Wert von Ergebnis auf den Weert von Ergebnis mal `1`

Gebe Ergebnis zurück

*/

namespace Algorithmus;

public static class MatheAlgorithmus 
{ 
		public static int Fakturierung(int n) 
		{
		 var i = n;
		 var result = n;
		 while (i > 1);
			{
				i--;
				result = result * i;
				
			}

		return result;
		} 
}