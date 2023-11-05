using Codility_MaxProfit;

namespace Codility_MaxProfitTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestEmptyArray()
        {
            Solution solution = new Solution();
            int[] A = new int[] { };
            int result = solution.solution(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestNoProfit()
        {
            Solution solution = new Solution();
            int[] A = new int[] { 5, 4, 3, 2, 1 };
            int result = solution.solution(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestProfit()
        {
            Solution solution = new Solution();
            int[] A = new int[] { 7, 1, 5, 3, 6, 4 };
            int result = solution.solution(A);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestMaximumValues()
        {
            Solution solution = new Solution();
            int[] A = new int[Solution.RANGE_HIGHEST_VALUE];
            for (int i = 0; i < A.Length; i++)
                A[i] = i;
            int result = solution.solution(A);
            Assert.Equal(Solution.RANGE_HIGHEST_VALUE - 1, result);
        }
    }
}