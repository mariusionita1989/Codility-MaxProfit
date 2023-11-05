# Codility-MaxProfit
 An array A consisting of N integers is given.</br>
 It contains daily prices of a stock share for a period of N consecutive days.</br> 
 If a single share was bought on day P and sold on day Q, where 0 ≤ P ≤ Q < N,</br> 
 then the profit of such transaction is equal to A[Q] − A[P], provided that A[Q] ≥ A[P].</br> 
 Otherwise, the transaction brings loss of A[P] − A[Q].

 For example, consider the following array A consisting of six elements such that:</br>
 A[0] = 23171</br>
 A[1] = 21011</br>
 A[2] = 21123</br>
 A[3] = 21366</br>
 A[4] = 21013</br>
 A[5] = 21367</br>
 If a share was bought on day 0 and sold on day 2,</br> 
 a loss of 2048 would occur because A[2] − A[0] = 21123 − 23171 = −2048.</br> 
 If a share was bought on day 4 and sold on day 5,</br> 
 a profit of 354 would occur because A[5] − A[4] = 21367 − 21013 = 354.</br> 
 Maximum possible profit was 356.</br> 
 It would occur if a share was bought on day 1 and sold on day 5.

 Write a function</br>
 class Solution { public int solution(int[] A); }</br>
 that, given an array A consisting of N integers containing daily prices of a stock share for a period of N consecutive days,</br> 
 returns the maximum possible profit from one transaction during this period.</br> 
 The function should return 0 if it was impossible to gain any profit.

 For example, given array A consisting of six elements such that:</br>
 A[0] = 23171</br>
 A[1] = 21011</br>
 A[2] = 21123</br>
 A[3] = 21366</br>
 A[4] = 21013</br>
 A[5] = 21367</br>
 the function should return 356, as explained above.

 Write an efficient algorithm for the following assumptions:</br>
 N is an integer within the range [0..400,000];</br>
 each element of array A is an integer within the range [0..200,000].
