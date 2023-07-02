using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignal.Intro
{
    class IslandOfKnowledge
    {

        // Call two arms equally strong if the heaviest weights they each are able to lift are equal
        // Call two people equally strong if their strongest arms are equally strong (the strongest arm can be both the right and the left),
        // and so are their weakest arms. 
        // Given your and your friend's arms' lifting capabilities find out if you two are equally strong.

        public bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            int yourStrongest = Max(yourLeft, yourRight);
            int yourWeakest = Min(yourLeft, yourRight);

            int friendStrongest = Max(friendsLeft, friendsRight);
            int friendWeakest = Min(friendsLeft, friendsRight);

            return yourStrongest == friendStrongest && yourWeakest == friendWeakest;

        }

        private int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        private int Min(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        // Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
        public int ArrayMaximalAdjacentDifference(int[] inputArray)
        {
            int min = inputArray[0] - inputArray[1];


            for (int i = 1; i < inputArray.Length; ++i)
            {

                if (Math.Abs(inputArray[i] - inputArray[i - 1]) > min)
                    min = Math.Abs(inputArray[i] - inputArray[i - 1]);
                
            }

            return min;

        }

        // An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a
        // computer network that uses the Internet Protocol for communication. There are two versions of the Internet protocol, and thus two versions of addresses. One of them is the IPv4 address.
        // Given a string, find out if it satisfies the IPv4 address naming rules.
        public bool IsIPv4Address(string inputString)
        {
            string[] segments = inputString.Split('.');

            if (segments.Length != 4)
                return false;

            foreach (string segment in segments)
            {
                if (!int.TryParse(segment, out int value) || value < 0 || value > 255 || segment != value.ToString())
                    return false;
            }

            return true;
        }

        // You are given an array of integers representing coordinates of obstacles situated on a straight line.
        // Assume that you are jumping from the point with coordinate 0 to the right. You are allowed only to make
        // jumps of the same length represented by some integer.
        // Find the minimal length of the jump enough to avoid all the obstacles.
        public int AvoidObstacles(int[] inputArray)
        {
            HashSet<int> myWay = new HashSet<int>();

            myWay.Add(inputArray[0]);

            int max = inputArray[0];

            for (int i = 1; i < inputArray.Length; ++i)
            {
                myWay.Add(Math.Abs(inputArray[i] - inputArray[i - 1]));
                max = Math.Max(max, inputArray[i]);

            }

            for (int i = 1; i < max; ++i)
            {
                bool divs = inputArray.Any(x => x % i == 0);
                if (!divs) return i;
            }


            return max + 1;
        }

        // Last night you partied a little too hard. Now there's a black and white photo of you that's about to go viral! You can't let
        // this ruin your reputation, so you want to apply the box blur algorithm to the photo to hide its content.
        // The pixels in the input image are represented as integers. The algorithm distorts the
        // input image in the following way: Every pixel x in the output image has a value equal to the average value of
        // the pixel values from the 3 × 3 square that has its center at x, including x itself. All the pixels on the border of x are then removed.
        public int[][] BoxBlur(int[][] image)
        {
            int row = image.Length;
            int col = image[0].Length;

            int rowRes = row - 2;
            int colRes = col - 2;

            int[][] blurredImage = new int[rowRes][];

            for (int i = 0; i < rowRes; i++)
            {
                blurredImage[i] = new int[colRes];

                for (int j = 0; j < colRes; j++)
                {
                    int[][] subMatrix = GetSubMatrix(image, i, j);
                    blurredImage[i][j] = GetAverage(subMatrix);
                }
            }

            return blurredImage; ;
        }

        private int[][] GetSubMatrix(int[][] matrix, int rowIndex, int colIndex)
        {
            int[][] subMatrix = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                subMatrix[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    subMatrix[i][j] = matrix[rowIndex + i][colIndex + j];
                }
            }
            return subMatrix;
        }

        private int GetAverage(int[][] matrix)
        {
            int totalSum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    totalSum += matrix[i][j];
                }
            }
            return totalSum / 9;
        }

        // In the popular Minesweeper game you have a board with some mines and those cells that don't
        // contain a mine have a number in it that indicates the total number of mines in the neighboring cells.
        // Starting off with some arrangement of mines we want to create a Minesweeper game setup.
        public int[][] Minesweeper(bool[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int[][] hintsMatrix = new int[rows][];
            for (int i = 0; i < rows; ++i)
            {
                hintsMatrix[i] = new int[cols];
            }

            int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    if (matrix[i][j])
                    {
                        for (int k = 0; k < 8; ++k)
                        {
                            int newRow = i + dr[k];
                            int newCol = j + dc[k];

                            if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols)
                            {
                                ++hintsMatrix[newRow][newCol];
                            }
                        }
                    }
                }
            }

            return hintsMatrix;
        }





    }
}
