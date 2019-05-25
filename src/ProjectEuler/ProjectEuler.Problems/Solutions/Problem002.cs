﻿namespace ProjectEuler.Problems.Solutions
{
    public class Problem002 : IProblem
    {
        public int Id => 2;
        public string Title => "Even Fibonacci numbers";

        public string Description =>
            "Each new term in the Fibonacci sequence is generated by adding the previous two terms.\r\n" +
            "By starting with 1 and 2, the first 10 terms will be: \r\n" +
            "1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...\r\n" +
            "By considering the terms in the Fibonacci sequence whose values do not exceed four million, \r\n" +
            "find the sum of the even-valued terms.";

        public string GetSolution()
        {
            var a = 1;
            var b = 2;
            var result = 0;
            while (b < 4000000)
            {
                if (b % 2 == 0) result += b;
                (a, b) = (b, a + b);
            }
            return result.ToString();
        }
    }
}
