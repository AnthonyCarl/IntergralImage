using System;
using System.Diagnostics;

namespace IntegralImage
{
    public static class IntegralImage
    {
        public static TimeSpan TimeDoublingRows(int numOfRows, int numColumns, Func<int[][], int[][]> integralImageMethod)
        {
            var imageMap = new int[numOfRows][];

            for (int i = 0; i < imageMap.Length; i++)
            {
                imageMap[i] = CreateRandomRow(numColumns);
            }

            var sw = Stopwatch.StartNew();
            integralImageMethod(imageMap);
            sw.Stop();
            return sw.Elapsed;
        }

        public static int[][] GetIntegralImageSum(int[][] imageMap)
        {
            var dimension = imageMap.GetUpperBound(0) +1;
            var integralImage = new int[dimension][];

            for (int i = 0; i < dimension; i++)
            {
                integralImage[i] = new int[imageMap[i].Length];
                var currentRowSum = 0;
                for (int j = 0; j < imageMap[i].Length; j++)
                {
                    currentRowSum += imageMap[i][j];
                    var integralValue = currentRowSum;
                    if (i > 0)
                    {
                        integralValue += imageMap[i - 1][j];
                    }
                    integralImage[i][j] = integralValue;
                }
            }
            return integralImage;
        }

        public static int[][] GetIntegralImageArrayAccess(int[][] imageMap)
        {
            var dimension = imageMap.Length;
            var integralImage = new int[dimension][];

            for (int i = 0; i < dimension; i++)
            {
                integralImage[i] = new int[imageMap[i].Length];

                for (int j = 0; j < imageMap[i].Length; j++)
                {
                    var integralValue = imageMap[i][j];
                    
                    if (i > 0)
                    {
                        integralValue += imageMap[i - 1][j];
                    }
                    if (j > 0)
                    {
                        integralValue += imageMap[i][j - 1];
                    }
                    if (i > 0 && j > 0)
                    {
                        integralValue -= imageMap[i-1][j - 1];
                    }
                    integralImage[i][j] = integralValue;
                }
            }
            return integralImage;
        }

        public static int[][] GetIntegralImageBruteForce(int[][] imageMap)
        {
            var dimension = imageMap.Length;
            var integralImage = new int[dimension][];

            for (int i = 0; i < dimension; i++)
            {
                integralImage[i] = new int[imageMap[i].Length];

                for (int j = 0; j < imageMap[i].Length; j++)
                {
                    integralImage[i][j] = SumUpAndToTheLeft(imageMap, i, j);
                }
            }
            return integralImage;
        }

        private static int SumUpAndToTheLeft(int[][] imageMap, int x, int y)
        {
            int sum = 0;
            for (int i = x; i >= 0; i--)
            {
                for (int j = y; j >= 0; j--)
                {
                    sum += imageMap[i][j];
                }
            }
            return sum;
        }
        
        private static int[] CreateRandomRow(int length)
        {
            var row = new int[length];
            for (int i = 0; i < length; i++)
            {
                row[i] = Random.Next(0, 255);
            }
            return row;
        }

        private static readonly Random Random = new Random();
    }
}