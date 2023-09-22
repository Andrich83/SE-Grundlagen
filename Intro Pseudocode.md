## Alice und Bob spielen Karten

**Aufgabenstellung**

Alice hat einige Karten mit Zahlen darauf. Sie sortiert die Karten in aufsteigender Reihenfolge und legt sie mit der Schrift nach unten in einer Reihe auf den Tisch. Nun soll Bob die Karte mit einer von Alice vorgegebenen Zahl finden und dabei so wenig falsche Karten wie möglich aufdecken. Schreibe eine Helfer-Funktion für den armen Bob.

## Methidik

1. Definiere das Problem
2. Denke Beispiel Inputs und Outputs aus
3. Pseudo-Code Lösung kozeptionieren
4. Implementierung der konzeptionierten Lösung in Code
5. Optimiere und Iteriere den Algorithmus

## 1. Problem Definieren

Karten = 1, 2, 3, 4, 5
Gesuchte Karte = 3

Position = ?

C#
```csharp
int[] Karten = { 1, 2, 3, 4, 5 }; // ist sortiert
int gesucht = 3;

var Position = FindedieKartenposition(Karten, gesucht); //sollte 2 zurückgeben (Index 0,1,2,3,4)
```

```csharp
int FindedieKartenposition(int[] Karten, int gesucht)
{


}
```

## 2. Beispiel Input/Output

**TestCases:**

- `gesucht` nicht in Karten enthalten
- wenn `gesucht` mehrmals in `Karten` vorkommt, dann geben wir die Position des ersten Ergebnisses zurück.
- Wenn `Karten` leer, dann geben wir `-1` zurück
- Wenn die `gesucht` Karte nicht in `Karten` vorhanden ist, geben wir -1 zurück
  
  ## 3. Pseudo-Code-Implementierung

  ### Was ist Pseudo-Code?

  ```text
  Schleife (x < y):
    mache x
    mache y
    Schleife ende    
    Wiederhole solange x kleiner als 0:
    mache x
    mache y
    Wiederholung ende
  ```

  ```
  Wenn x gleich y:
    wahr: Setze den Wert von z auf den Wert von x
        y = x
    falsch: weise z den Wert von y zu mache x
  ```

  ```text
  Initialisiere variable num mit dem Wert 0
  Initialisiere variable checknumber mit dem Wert false
  Solange checkNumber gleich false
  Wiederhole:
  Frage Nutzer nach einer Zahal und speichere diese in variable input
  wandle input in eine Zahl um  
  ```

  ### Pseudo-Code-Implementierung

```csharp
int FindedieKartenposition(int[] Karten, int gesucht)
{


}
```

  ```text
  Parameter: Zahlenliste (Karten)
  Parameter: Zahl (gesuchte Karte)
  initialisiere variable index mit Wert 0
  Schleife bis Position gleich länge der Karten Liste
    Wenn die gesuchte Zahl in den Karten im index gleich der gesuchten Karte ist

    Wahr: gebe index zurück
Inkrement Index um 1 (Itercount ++;)
    
  ```