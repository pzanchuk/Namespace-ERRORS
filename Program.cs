using System;

namespace MyQueen{


  public class Program
  {

    public static void DrawBoard(int xQ, int yQ, int xK, int yK)
    {
      string[,] array = new string [11,11];
      for(int i = 1; i < 11; i ++)
      {
        for(int j = 1; j < 11; j ++)
        {
          array[i,j] = "|_|";
          if(array[i,j] == array[xQ,yQ] )
          {
            array[i,j] = "|Q|";
          }else if(array[i,j] == array[xK, yK])
          {
            array[i,j] = "|K|";
          }
          Console.Write(array[i,j]);
        }
        Console.WriteLine();
      }
    }

    public static void Main()
    {
      Console.WriteLine("===============================");
      Console.WriteLine("Grid is set to 10 by 10");
      Console.WriteLine("Enter Y coordinate for Queen (1 to 10): ");
      int attackerX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter X coordinate for Queen:");
      int attackerY = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Y coordinate for defender (1 to 10): ");
      int defenderX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter X coordinate for defender:");
      int defenderY = int.Parse(Console.ReadLine());
      Console.WriteLine();
      DrawBoard(attackerX, attackerY, defenderX, defenderY);
      Queen attacker = new Queen(attackerX, attackerY);
      Queen defender = new Queen(defenderX, defenderY);
      Console.WriteLine(attacker.AttackChecker(defender.GetXcoord(), defender.GetYcoord()));
    }
  }
}
