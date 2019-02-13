using System;

namespace MyQueen{


  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter x coordinate for Queen:");
      int attackerX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter y coordinate for Queen:");
      int attackerY = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter x coordinate for defender:");
      int defenderX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter y coordinate for defender:");
      int defenderY = int.Parse(Console.ReadLine());

      Queen attacker = new Queen(attackerX, attackerY);
      Queen defender = new Queen(defenderX, defenderY);
      Console.WriteLine(attacker.AttackChecker(defender.GetXcoord(), defender.GetYcoord()));
    }
  }
}
