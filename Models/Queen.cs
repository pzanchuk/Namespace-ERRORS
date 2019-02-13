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
       return true;
     }else if(Math.Abs(Xcoord - x) == Math.Abs(Ycoord - y))
     {
       return true;
     }else
     {
       return false;
     }

    }
  }
}
