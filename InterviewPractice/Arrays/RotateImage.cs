


using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CodeSignal.InterviewPracticeArrays
{
    internal class RotateImage
    {
        // Note: Try to solve this task in-place (with O(1) additional memory), since this is what you'll be asked to do during an interview.
        //You are given an n x n 2D matrix that represents an image.Rotate the image by 90 degrees(clockwise).
        public int[][] Solution(int[][] a) => a.Select((row, rowIndex) => a.Select(val => val[rowIndex]).Reverse().ToArray()).ToArray();
/*
        {
            int n = a[0].Length;

            for (int j = 0; j < n / 2; ++j)
            {
                for (int i = j; i < n - j - 1; ++i)
                {
                    int temp = a[j][i];

                    a[j][i] = a[n - i - 1][j];
                    a[n - i - 1][j] = a[n - 1 - j][n - i - 1];
                    a[n - 1 - j][n - i - 1] = a[i][n - 1 - j];
                    a[i][n - 1 - j] = temp;
                }
            }
            return a;
        }
*/

    }
}
