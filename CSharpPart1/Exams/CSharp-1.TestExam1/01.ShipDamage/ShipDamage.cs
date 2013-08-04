using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShipDamage
{
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());
        Ship myShip = new Ship(sx1, sy1, sx2, sy2);
        Cannon FirstCannon = new Cannon(cx1, cy1, h);
        Cannon SeconCannon = new Cannon(cx2, cy2, h);
        Cannon ThirdCannon = new Cannon(cx3, cy3, h);
        myShip.GetHitDamage(FirstCannon.targetX, FirstCannon.targetY);
        myShip.GetHitDamage(SeconCannon.targetX, SeconCannon.targetY);
        myShip.GetHitDamage(ThirdCannon.targetX, ThirdCannon.targetY);
        Console.WriteLine(myShip.damage + "%");
    }
    
}

public class Ship
{
    public int Sx1,Sx2,Sy1,Sy2,damage;
        
    public Ship(int x1, int y1, int x2, int y2)
    {
        this.Sx1 = Math.Min(x1, x2);
        this.Sy1 = Math.Max(y1, y2);
        this.Sx2 = Math.Max(x1, x2);
        this.Sy2 = Math.Min(y1, y2);
        damage = 0;
    }
    public  int GetHitDamage(int x, int y)
    {

        if (x < this.Sx1 || x > this.Sx2 || y > this.Sy1 || y < this.Sy2)
        {
            damage += 0;

        }
        else if (((x == this.Sx1 || x == this.Sx2) && (y < this.Sy1 && y > Sy2)) || ((y == this.Sy1 || y == this.Sy2) && (x > this.Sx1 && x < this.Sx2)))
        {
            damage += 50;
        }
        else if ((x == this.Sx1 || x == this.Sx2) && (y == this.Sy1 || y == this.Sy2))
        {
            damage += 25;
        }
        else
        {
            damage += 100;
        }
        return this.damage;
    }

}
public class Cannon
{
    public int x;
    public int y;
    public int h;
    public int targetX;
    public int targetY;

    public Cannon(int x, int y, int h)
    {
        this.x = x;
        this.y = y;
        this.h = h;
        this.targetX = x;
        if (h < this.y)
        {
            this.targetY = this.y - 2 * (Math.Abs(this.y - h));
        }
        else
        {
            this.targetY = this.y + 2 * (Math.Abs(this.y - h));
        }
    }
}
    

