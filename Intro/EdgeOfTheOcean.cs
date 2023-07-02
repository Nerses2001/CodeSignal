using System.Linq;


namespace CodeSignal.Intro
{
    class EdgeOfTheOcean
    {
        // Given an array of integers, find the pair of adjacent elements
        // that has the largest product and return that product.
        public int AdjecntElemetsProduct(int[] inputArray)
        {
            int max = inputArray[0] * inputArray[1];
            for (int i = 1; i < inputArray.Length - 1; ++i)
            {
                if (inputArray[i] * inputArray[i + 1] > max) max = inputArray[i] * inputArray[i + 1];
            }

            return max;
        }


        // Below we will define an n-interesting polygon. Your task is to find the area of a polygon for a given n.
        // A 1-interesting polygon is just a square with a side of length 1.
        // An n-interesting polygon is obtained by taking the n - 1-interesting polygon and appending 1-interesting polygons to
        // its rim, side by side.You can see the 1-, 2-, 3- and 4-interesting polygons in the picture below.
        public int SgapeArea(int n)
        {
            if (n == 1) return 1;
            int a = n + n - 1;
            return a * a - (a * a / 2);
        }


        // Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size.
        // Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will
        // be bigger than the previous one exactly by 1.
        // He may need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.
        public int MakeArrayConsecutive2(int[] statues)
        {
            int max = statues.Max();
            int min = statues.Min();
            return max - min + 1 - statues.Length;
        }


        // Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence by removing no more
        // than one element from the array.
        // Note: sequence a0, a1, ..., an is considered to be a strictly increasing if a0 < a1 < ... < an.
        // Sequence containing only one element is also considered to be strictly increasing.
        public bool AlmostIncreasingSequence(int[] sequence)
        {
            int count = 0;

            for (int i = 1; i < sequence.Length; ++i)
            {
                if (sequence[i] <= sequence[i - 1])
                {
                    ++count;

                    if (count > 1) return false;
                    
                    if (i == 1 || sequence[i] > sequence[i - 2])  sequence[i - 1] = sequence[i];
                    
                    else sequence[i] = sequence[i - 1];
                    
                }
            }

            return true;
        }

        // After becoming famous, the CodeBots decided to move into a new building together.
        // Each of the rooms has a different cost, and some of them are free, but there's a rumour that all
        // the free rooms are haunted! Since the CodeBots are quite superstitious,
        // they refuse to stay in any of the free rooms, or any of the rooms below any of the free rooms.
        // Given matrix, a rectangular matrix of integers, where each value represents the cost of the room,
        // your task is to return the total sum of all rooms that are suitable
        // for the CodeBots (ie: add up all the values that don't appear below a 0).
        public int MatrixElementsSum(int[][] matrix)
        {
            int m = matrix[0].Length;
            int n = matrix.Length;
            int sum = 0;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (matrix[i][j] > 0) sum += matrix[i][j];
                    
                    if (matrix[i][j] == 0 && i < n - 1) matrix[i + 1][j] = 0;
                  
                }
            }

            return sum;

        }






    }
}
