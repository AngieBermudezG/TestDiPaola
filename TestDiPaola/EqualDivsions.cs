using System;

namespace TestDiPaola
{
    public class EqualDivsions
    {

        public static void EquivalentDivision()
        {

            int cellsArray;
            while ((cellsArray = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                int[,] numArray = new int[cellsArray, cellsArray];
                
                for (int i = 0; i < cellsArray - 1; i++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    int array1 = Convert.ToInt32(input[0]);
                    int array2 = Convert.ToInt32(input[1]);
                    int array3 = Convert.ToInt32(input[2]);
                    int array4 = Convert.ToInt32(input[3]);

                    for (int row = array1 - 1; row < array3; row++)
                    {
                        for (int col = array2 - 1; col < array4; col++)
                        {
                            numArray[row, col] = i + 1;
                        }
                    }
                }
                
                int Partition = 1;
                bool isDivision = true;

                for (int row = 0; row < cellsArray; row++)
                {
                    for (int col = 0; col < cellsArray; col++)
                    {
                        if (numArray[row, col] != Partition)
                        {
                            isDivision = false;

                            break;
                        }
                    }
                    if (!isDivision)
                        
                        break;
                    Partition++;
                }
                
                if (isDivision)
                    Console.WriteLine("good");
                else
                    Console.WriteLine("wrong");
            }
        }
    }
}