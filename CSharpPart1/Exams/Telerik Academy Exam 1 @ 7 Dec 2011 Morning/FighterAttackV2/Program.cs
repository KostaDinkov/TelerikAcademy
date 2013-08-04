using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterAttackV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Px1 = int.Parse(Console.ReadLine());
            int Py1 = int.Parse(Console.ReadLine());
            int Px2 = int.Parse(Console.ReadLine())+1;
            int Py2 = int.Parse(Console.ReadLine())-1;
            int Fx = int.Parse(Console.ReadLine());
            int Fy = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            double impactX = Fx + D+0.5;
            double impactY = Fy - 0.5;
            int damage = 0;
            if ((impactX>=Math.Min(Px1,Px2) && impactX<= Math.Max(Px1,Px2)) &&
                ( impactY <= Math.Max(Py1,Py2) && impactY >= Math.Min(Py1,Py2)))
            {
                damage += 100;
            }
            if ((impactX+1>=Math.Min(Px1,Px2) && impactX<= Math.Max(Px1,Px2)) &&
                ( impactY <= Math.Max(Py1,Py2) && impactY >= Math.Min(Py1,Py2)))
            {
                damage += 75;
            }
            if ((impactX >= Math.Min(Px1, Px2) && impactX <= Math.Max(Px1, Px2)) && 
                (impactY-1 <= Math.Max(Py1, Py2) && impactY-1 >= Math.Min(Py1, Py2)))
            {
                damage += 50;
            }
            if ((impactX >= Math.Min(Px1, Px2) && impactX <= Math.Max(Px1, Px2)) && 
                (impactY+1 <= Math.Max(Py1, Py2) && impactY+1 >= Math.Min(Py1, Py2)))
            {
                damage += 50;
            }
            Console.WriteLine(damage+"%");


            
        }
    }
}
