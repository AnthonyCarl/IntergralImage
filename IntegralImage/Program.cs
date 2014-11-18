using System;

namespace IntegralImage
{
    internal class Program
    {
        private const string HeaderBreak = "#####";

        private static void Main()
        {
            const int initialDimension = 8;
            const int numColumns = 128;
            //Uncomment to minimize Jitter if you don't run ngen on the build artifact
            //Console.WriteLine("Running All methods to eliminate Jitter.");
            //IntegralImage.TimeDoublingRows(initialDimension, numColumns, IntegralImage.GetIntegralImageSum);
            //IntegralImage.TimeDoublingRows(initialDimension, numColumns, IntegralImage.GetIntegralImageArrayAccess);
            //IntegralImage.TimeDoublingRows(initialDimension, numColumns, IntegralImage.GetIntegralImageBruteForce);
            VerifySolutions();
            Console.WriteLine("Fixed Number of Columns: {0}", numColumns);
            PrintHeader("Running Sum");
            DoublingRatio.Run(initialDimension,
                i => IntegralImage.TimeDoublingRows(i, numColumns, IntegralImage.GetIntegralImageSum));
            PrintHeader("Array Access");
            DoublingRatio.Run(initialDimension,
                i => IntegralImage.TimeDoublingRows(i, numColumns, IntegralImage.GetIntegralImageArrayAccess));
            PrintHeader("Brute Force");
            DoublingRatio.Run(initialDimension,
                i => IntegralImage.TimeDoublingRows(i, numColumns, IntegralImage.GetIntegralImageBruteForce));
            Console.WriteLine(HeaderBreak);

            Console.WriteLine("All Done. Hit enter to quit");

            Console.ReadLine();
        }

        private static void VerifySolutions()
        {
            int[][] testImage = {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            int[][] expectedResult = { new[] { 1, 3, 6 }, new[] { 5, 12, 21 }, new[] { 12, 27, 45 } };

            var resultSum = IntegralImage.GetIntegralImageSum(testImage);
            Console.WriteLine("Running Sum has correct result -> {0}", AreEqual(expectedResult, resultSum));
            
            var resultAccess = IntegralImage.GetIntegralImageArrayAccess(testImage);
            Console.WriteLine("Array Access has correct result -> {0}", AreEqual(expectedResult, resultAccess));
            
            var resultBruteForce = IntegralImage.GetIntegralImageBruteForce(testImage);
            Console.WriteLine("Brute Force has correct result -> {0}", AreEqual(expectedResult, resultBruteForce));

            Console.WriteLine(HeaderBreak);
        }

        private static bool AreEqual(int[][] expected, int[][] actual)
        {
            bool areDifferent = false;
            for (int i = 0; i < actual.Length; i++)
            {
                for (int j = 0; j < actual[i].Length; j++)
                {
                    areDifferent |= actual[i][j] != expected[i][j];
                }
            }

            return !areDifferent;
        }
        private static void PrintHeader(string sectionName)
        {
            Console.WriteLine(HeaderBreak + " " + sectionName);
            Console.WriteLine("{0,8} {1,11}   {2,5}", "Rows", "Time", "Ratio");
        }
    }
}