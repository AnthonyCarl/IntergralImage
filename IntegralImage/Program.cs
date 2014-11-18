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

            Console.WriteLine("Fixed Number of Columns: {0}", numColumns);
            PrintHeader();
            DoublingRatio.Run(initialDimension,
                i => IntegralImage.TimeDoublingRows(i, numColumns, IntegralImage.GetIntegralImageSum));
            PrintHeader();
            DoublingRatio.Run(initialDimension,
                i => IntegralImage.TimeDoublingRows(i, numColumns, IntegralImage.GetIntegralImageArrayAccess));
            PrintHeader();
            DoublingRatio.Run(initialDimension,
                i => IntegralImage.TimeDoublingRows(i, numColumns, IntegralImage.GetIntegralImageBruteForce));
            Console.WriteLine(HeaderBreak);

            Console.WriteLine("All Done. Hit enter to quit");

            Console.ReadLine();
        }

        private static void PrintHeader()
        {
            Console.WriteLine(HeaderBreak);
            Console.WriteLine("{0,6} {1,9}   {2,5}", "Rows", "Time", "Ratio");
        }
    }
}