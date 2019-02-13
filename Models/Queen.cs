using System;

namespace MyQueen{

  class Queen
  {
    private int Xcoord;
    private int Ycoord;


    public Queen(int x, int y)
    {
      Xcoord = x;
      Ycoord = y;
    }

    public int GetXcoord()
    {
      return Xcoord;
    }

    public int GetYcoord()
    {
      return Ycoord;
    }

    public bool AttackChecker(int x, int y)
    {
     if(Xcoord == x || Ycoord == y){
       Console.WriteLine();
       Console.WriteLine("Queen is going to destroy King!");
       Console.WriteLine();
       return true;
     }else if(Math.Abs(Xcoord - x) == Math.Abs(Ycoord - y))
     {
       Console.WriteLine();
       Console.WriteLine("Queen is going to destroy King!");
       Console.WriteLine();
       return true;
     }else
     {
       Console.WriteLine();
       Console.WriteLine("King is safe here! For now...");
       Console.WriteLine();
       return false;
     }

    }
  }
}
