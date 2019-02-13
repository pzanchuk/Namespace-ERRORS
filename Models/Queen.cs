using System;


namespace Namespace.Models {

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

    public int GetXcoord()
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
