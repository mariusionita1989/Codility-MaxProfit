using System.Runtime.CompilerServices;

namespace Codility_MaxProfit
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 400000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (A == null || A.Length < 2)
                return 0; // No profit can be made with less than 2 days of data.

            int maxProfit = 0; // Initialize the maximum profit to 0.
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int minPrice = A[0]; // Initialize the minimum price to the price on the first day.
                for (int i = 1; i < A.Length; i++)
                {
                    int currentPrice = A[i];
                    int potentialProfit = currentPrice - minPrice;
                    if (potentialProfit > maxProfit)
                        maxProfit = potentialProfit; // Update the maximum profit if a better one is found.

                    if (currentPrice < minPrice)
                        minPrice = currentPrice; // Update the minimum price if a lower price is encountered.
                }
            }

            return maxProfit;
        }
    }
}
