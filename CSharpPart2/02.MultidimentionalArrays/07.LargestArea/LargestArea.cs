/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Multidimensional Arrays
 * Problem 7: * Write a program that finds the largest area of equal 
 *              neighbor elements in a rectangular matrix and prints its size. 
 */


//Note: Work in Progress - DO NOT CONSIDERATE FOR GRADING
using System;
using System.Collections.Generic;
using System.Linq;


class LargestArea
{
    static void Main()
    {
        int[,] matrix = BuildRandomMatrix(10, 10);
        PrintArray(matrix);
        NodeList nodeMatrix = new NodeList(matrix.GetLength(0), matrix.GetLength(1));
        
        Random rnd = new Random();
        for (int x = 0; x<matrix.GetLength(1);x++)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
			{
			    Node newNode = new Node(matrix[y,x]);
                newNode.Y = y;
                newNode.X = x;
                nodeMatrix.Add(newNode); 
			}
        }
        nodeMatrix.Print();
        nodeMatrix.FindSameNodes(nodeMatrix.Nodes[5, 5], nodeMatrix.Nodes[5, 5].Value);
        Console.WriteLine();
        nodeMatrix.Print();
        

    }
    /// <summary>
    /// Builds a matrix with given dimensions and populates it with random numbers from a given range
    /// </summary>
    /// <param name="hight">Matrix height</param>
    /// <param name="width">Matrix width</param>
    /// <param name="minNumber">Low margin for the random numbers range</param>
    /// <param name="maxNumber">Top margin for the random numbers range</param>
    static int[,] BuildRandomMatrix(int heigth, int width, int minNumber = 1, int maxNumber = 4)
    {
        int[,] result = new int[heigth, width];
        Random rnd = new Random();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < heigth; j++)
            {
                result[j,i] = rnd.Next(minNumber, maxNumber);
            }
        }
        return result;
    }
    static void PrintArray<T>(T[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write("{0,5}", array[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static int GetRandomValue(int min = 0, int max = 100)
    {
        Random rnd = new Random();
        return rnd.Next(min, max);
    }
}
class Node
{
    public int X;
    public int Y;
    public int Value;
    public bool Checked = false;
    public bool Equal = false;
    public bool DeadEnd = false;
    public ConsoleColor Color = ConsoleColor.White;
    public List<Node> AdjastenNodes;
    public Node(int value)
    {
        this.Value = value;
    }
    
}
class NodeList
{
    public Node[,] Nodes;
    public int Heigth;
    public int Width;
    Stack<Node> nodeStack = new Stack<Node>();
    public void Add(Node element)
    {
        this.Nodes[element.Y, element.X] = element;
    }
    public NodeList(int heigth, int width)
    {
        this.Nodes = new Node[heigth, width];
        this.Width = width;
        this.Heigth = heigth;
    }
    public void Print()
    {
        for (int y = 0; y < this.Nodes.GetLength(0); y++)
        {
            for (int x = 0; x < this.Nodes.GetLength(1); x++)
            {
                Console.ForegroundColor = Nodes[y, x].Color;
                Console.Write(Nodes[y,x].Value+" ");
            }
            Console.WriteLine();
        }
    }
    private List<Node> GetAdjacentNodes(Node node)
    {
        List<Node> adjacentNodes = new List<Node>();
        
        
            if (node.X > 0)
            {
                Node left = this.Nodes[node.Y, node.X - 1];
                if (!left.Checked) adjacentNodes.Add(left);
            }
            if (node.X < this.Width - 1)
            {
                Node right = this.Nodes[node.Y, node.X + 1];
                if (!right.Checked) adjacentNodes.Add(right);
            }
            if (node.Y > 0)
            {
                Node up = this.Nodes[node.Y - 1, node.X];
                if (!up.Checked) adjacentNodes.Add(up);
            }
            if (node.Y < this.Heigth - 1)
            {
                Node down = this.Nodes[node.Y + 1, node.Y];
                if (!down.Checked) adjacentNodes.Add(down);

            }
            foreach (var item in adjacentNodes)
            {
                item.Color = ConsoleColor.Green;
            } 
        
        return adjacentNodes;

    }
    public  void FindSameNodes(Node node, int nodeValue)
    {
        this.nodeStack.Push(node);
        if (nodeStack.Peek().Checked ==true)
        {
            nodeStack.Pop(); 
        }
        else
        {
            node.AdjastenNodes = GetAdjacentNodes(node);
            foreach (var adj in node.AdjastenNodes)
            {
                if (adj.Value == node.Value)
                {
                    adj.Color = ConsoleColor.Red;
                    this.nodeStack.Push(adj);
                }
            }
        }

        
                
            
    }
        
        
        
        
        
            
        
            
            
                
                
                
                
            
        
    
    
}

