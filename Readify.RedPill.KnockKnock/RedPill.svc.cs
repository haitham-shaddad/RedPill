using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Readify.RedPill.KnockKnock
{
    public class RedPill : IRedPill
    {

        private static double Phi = ((1d + Math.Sqrt(5d)) / 2d);
        private static double D = 1d / Math.Sqrt(5d);

        public Guid WhatIsYourToken()
        {
            return new Guid(ConfigurationManager.AppSettings["YourToken"]);
        }

        public long FibonacciNumber(long n)
        {
            if (!(-92 <= n && n <= 92))
                Fault(new ArgumentOutOfRangeException("n", "Require 0 <= n <= 92"));
                //return 0;

            //if (n < 0) return (long)Math.Pow(-1, -n + 1) * FibonacciNumber(-n);
            //return (long)((Math.Pow(Phi, n) - Math.Pow(1d - Phi, n)) * D);

            return Fibonacci.ValueAt(n);
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.Error;
            else if (!(a < b + c && b < a + c && c < a + b))
                return TriangleType.Error;
            else if (a == b && b == c)
                return TriangleType.Equilateral;
            else if (a == b || a == c || b == c)
                return TriangleType.Isosceles;
            else
                return TriangleType.Scalene;
        }

        public string ReverseWords(string s)
        {
            //string reverseWords = string.Concat(s.Reverse());
            //return reverseWords;

            if (s == null)
                Fault(new ArgumentNullException("s", "Require s != null"));

            var result = new StringBuilder(s.Length);

            int start = 0;

            while (start < s.Length)
            {
                int end = start;
                while (end < s.Length && !Char.IsWhiteSpace(s[end])) end++;

                for (int i = end - 1; i >= start; i--) result.Append(s[i]);

                start = end;
                while (start < s.Length && Char.IsWhiteSpace(s[start])) result.Append(s[start++]);
            }


            return result.ToString();
        }

        void Fault<T>(T detail) where T : Exception
        {
            throw new FaultException<T>(detail, detail.Message);
        }
    }
}
