using System;


class Pillars
{
    static void Main()
        {
            int leftCount=0;
            int rightCount=0;
            byte[] inputNums = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                inputNums[i] = byte.Parse(Console.ReadLine());
            }
            string[] bitStrings = new string[8]; 
            char[][] bitTable = new char[8][];
            for (int i = 0; i < 8; i++)
            {
                bitStrings[i] = Convert.ToString(inputNums[i], 2).PadLeft(8, '0');
            }
            for (int i = 0; i < 8; i++)
            {
                bitTable[i] = bitStrings[i].ToCharArray(); 
            }
            //foreach (var item in bitTable)
            //{
            //    for (int i = 0; i < 8; i++)
            //    {
            //        Console.Write(item[i]);
            //    }
            //    Console.WriteLine();
            //}
            for (int pillar = 0; pillar < 8; pillar++)
            {
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < pillar; column++)
                    {
                        if (bitTable[row][column] == '1')
                        {
                            leftCount += 1;
                        }
                    }
                    for (int column = 7; column > pillar; column--)
                    {
                        if (bitTable[row][column]=='1')
                        {
                            rightCount += 1;
                        }
                    }
                }
                if (leftCount==rightCount)
                {
                    Console.WriteLine(7-pillar);
                    Console.WriteLine(leftCount);
                    return;
                }
                //Console.WriteLine("Pillar at:"+pillar);
                //Console.WriteLine("Lefty from  Pillar:" + leftCount);
                //Console.WriteLine("Right from Pillar:"+rightCount);
                leftCount = 0;
                rightCount = 0;
            }
            Console.WriteLine("No");
        }
}

