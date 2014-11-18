using System;

namespace IntegralImage
{
    public static class DoublingRatio
    {
        //Because I want to still be able to use my machine if this goes south
        private const int MaxN = 1024*1024;
        public static void Run(int startingN, Func<int, TimeSpan> timeTrial)
        {
            var currentN = startingN;
            var previousMs = timeTrial(startingN).TotalMilliseconds;
            double previousRatio = 0;
            
            while (true)
            {
                currentN += currentN;
                var currentMs = timeTrial(currentN).TotalMilliseconds;

                var currentRatio = Math.Round(currentMs / previousMs, 1);

                Console.WriteLine("{0,6} {1,9}ms {2,5}", currentN, currentMs, currentRatio);
                previousMs = currentMs;
                
                if (currentN >= MaxN)
                {
                    Console.WriteLine("Stopping the madness before all memory are belong to us.");
                    break;
                }
                if (previousRatio == currentRatio)
                {
                    break;
                }

                previousRatio = currentRatio;
            }

            Console.WriteLine(":: The ratio is -> {0}", previousRatio);
        }

    }
}