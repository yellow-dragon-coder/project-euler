﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.Solutions
{
    public class Problem014 : IProblem
    {
        public int Id => 14;
        public string Title => "Longest Collatz sequence";

        public string Description =>
            "The following iterative sequence is defined for the set of positive integers: \r\n" +
            "  n -> n/2    (n is even) \r\n" +
            "  n -> 3n + 1 (n is odd)  \r\n" +
            "Using the rule above and starting with 13, we generate the following sequence: \r\n" +
            "  13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1 \r\n" +
            "It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms.\r\n" +
            "Although it has not been proved yet (Collatz Problem), it is thought that " +
            "all starting numbers finish at 1. \r\n\r\n" +
            "Which starting number, under one million, produces the longest chain? \r\n\r\n" +
            "NOTE: Once the chain starts the terms are allowed to go above one million.";

        public string GetSolution()
        {
            throw new NotImplementedException();
        }
    }
}
