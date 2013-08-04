using System;
using System.Collections.Generic;
using System.Linq;

class MissCat2011
{
    static void Main()
    {
        List<int> votes= new List<int>();
        int juryMembers = int.Parse(Console.ReadLine());
        for (int i = 0; i < juryMembers; i++)
        {
            votes.Add(int.Parse(Console.ReadLine()));
        }
        Dictionary<int,int> results = new Dictionary<int,int>();

        foreach (var vote in votes)
        {
            if (results.ContainsKey(vote))
            {
                results[vote] = results[vote] + 1;
            }
            else
            {
                results[vote] = 1;
            }
        }

        int winner = 0;
        int voteCounter = 0;
        foreach ( var key in results.Keys.Reverse())
        {
            if (results[key] >= voteCounter)
            {
                voteCounter = results[key];
                winner = key;
            }
        }
        Console.WriteLine(winner);
        
        
    }
    

}

