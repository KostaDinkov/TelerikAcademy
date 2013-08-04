using System;
using System.Collections.Generic;



class FighterAttack
{
    static void Main(string[] args)
    {
        int Px1 = int.Parse(Console.ReadLine());
        int Py1 = int.Parse(Console.ReadLine());
        int Px2 = int.Parse(Console.ReadLine());
        int Py2 = int.Parse(Console.ReadLine());
        int Fx = int.Parse(Console.ReadLine());
        int Fy = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        Point a = new Point(Px1,Py1);
        Point b = new Point(Px2,Py2);
        Plant plant = new Plant(a, b);
        Point impactPoint = new Point(Fx+D,Fy);
        Console.WriteLine(plant.GetDamage(impactPoint)+"%"); 
    }
}
#region // The Point Class
public class Point : IEquatable<Point>
{
    public int x,y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public bool Equals (Point other)
    {
        return this.x == other.x &&
                this.y == other.y; 
    }
}
#endregion 
#region // The Plant Class
public class Plant
{
    public Point upperLeft = new Point(0,0);
    public Point lowerRight = new Point(0,0);
    public List<Point> cells = new List<Point>();
    private Point cell;
    public int damage;
        
    public Plant( Point a, Point b)
    {
        this.upperLeft.x = Math.Min(a.x, b.x);
        this.upperLeft.y = Math.Max(a.y, b.y);
        this.lowerRight.x = Math.Max(a.x, b.x);
        this.lowerRight.y = Math.Min(a.y, b.y);
            
        this.cell = upperLeft;

        while ( upperLeft.y >= lowerRight.y)
        {
            while( upperLeft.x <= lowerRight.x)
            {
                cells.Add(new Point (upperLeft.x,upperLeft.y));
                upperLeft.x++;
            }
            upperLeft.y--;
            upperLeft.x = this.upperLeft.x = Math.Min(a.x, b.x);
        }
    }
        
        
    public int GetDamage(Point impactPoint)
    {
        this.damage = 0;
        Point colaterallNorth = new Point(impactPoint.x,impactPoint.y+1);
        Point colaterallSouth = new Point(impactPoint.x,impactPoint.y-1);
        Point colaterallEast = new Point(impactPoint.x+1,impactPoint.y);
        if (this.cells.Contains(impactPoint))
        {
            this.damage += 100;
        }
        if (this.cells.Contains(colaterallNorth))
        {
            this.damage += 50;
        }
        if (this.cells.Contains(colaterallSouth))
        {
            this.damage += 50;
        }
        if (this.cells.Contains(colaterallEast))
        {
            this.damage += 75;
        }
        return this.damage;
            
    }
}
#endregion
