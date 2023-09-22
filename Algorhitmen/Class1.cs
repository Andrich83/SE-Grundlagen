using System;

namespace Algorhitmen
{
  public static class KartenAlgorithmus
  {
    public static int FindedieKartenposition(int[] Karten, int gesucht)
    {
      //initialisiere variable index mit Wert 0
      int index = 0;
      //Schleife bis Position gleich länge der Karten Liste
      while (index < Karten.Length)
      {
        //Wenn die gesuchte Zahl in den Karten im index gleich der gesuchten Karte ist
        if (Karten[index] == gesucht)
        //Wahr: gebe index zurück
        {
          return index;
        }

        //Inkrement Index um 1 (Itercount++;)

        index++;
      }
      return -1;
    }


    public static int FindedieKartenpositionBinary(int[] Karten, int gesucht)
    {

      // Setze Variable left auf Wert 0
      int left = 0;
      // Setze Variable right auf Wert Länge von cards minus 1
      int right = Karten.Length - 1;

      // Wenn Länge von cards gleich 0
      if (Karten.Length == 0)
      {
        //   Wahr: Gebe -1 zurück
        return -1;
      }
      // Schleife solange left kleiner als right:
      while (left < right)
      {
        //   Setze Variable middle auf den Wert (left + right) / 2
        int middle = (left + right) / 2;
        //   Wenn middle gleich query:
        if (Karten[middle] == gesucht)
        {
          //     Wahr: Gebe middle zurück
          return middle;
        }
        //   Wenn query kleiner cards an middle:
        else if (gesucht < Karten[middle])
        {
          //     Wahr: Setze right auf den Wert von middle - 1
          right = middle - 1;
        }
        else
        {
          //     Falsch: Setze left auf den Wert von middle + 1
          left = middle + 1;
        }
      }
      return -1;

    }
  }
}