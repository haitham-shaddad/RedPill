﻿using Readify.RedPill.OldService.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.RedPill.OldService
{
    class Program
    {
        static void Main(string[] args)
        {
            RedPillClient client = new RedPillClient();

            //var mytoken = client.WhatIsYourToken();
            //Console.WriteLine("WhatIsYourToken Result: {0}", mytoken);

            //var result = client.FibonacciNumber(10);
            //Console.WriteLine("FibonacciNumber Result: {0}", result);

            //var reversed = client.ReverseWords("word1,word2");
            //Console.WriteLine("ReverseWords Result: {0}", reversed);

            //var shareType = client.WhatShapeIsThis(10, 20, 20);
            //Console.WriteLine("WhatShapeIsThis Result: {0}", shareType);


            /*Dump(client.WhoAreYou());
         Dump(client.WhoAreYou());
         try 
         { 
           client.ReverseWords(null); // err
         } catch (Exception ex)
         {
           Console.WriteLine(ex.Message);
         }
         //Console.WriteLine(client.ReverseWords(null)); // err*/
            Console.WriteLine(client.ReverseWords("detartrated kayak detartrated"));
            Console.WriteLine(client.ReverseWords("cat"));
            Console.WriteLine(client.ReverseWords("cat and dog"));
            Console.WriteLine(client.ReverseWords("two  spaces"));
            Console.WriteLine(client.ReverseWords(" leading space"));
            Console.WriteLine(client.ReverseWords("trailing space "));
            Console.WriteLine(client.ReverseWords("Capital"));
            Console.WriteLine(client.ReverseWords("Bang!"));
            Console.WriteLine(client.ReverseWords("Â¿QuÃ©?"));
            //Console.WriteLine(client.ReverseWords() // empty tag
            Console.WriteLine(client.ReverseWords("This is a snark: â¸®"));
            Console.WriteLine(client.ReverseWords("  S  P  A  C  E  Y  "));
            Console.WriteLine(client.ReverseWords("!B!A!N!G!S!"));
            Console.WriteLine(client.ReverseWords("P!u@n#c$t%u^a&amp;t*i(o)n"));



            Console.WriteLine(client.FibonacciNumber(-3));
            Console.WriteLine(client.FibonacciNumber(3));
            Console.WriteLine(client.FibonacciNumber(6));
            Console.WriteLine(client.FibonacciNumber(7));
            Console.WriteLine(client.FibonacciNumber(46));
            Console.WriteLine(client.FibonacciNumber(47));
            Console.WriteLine(client.FibonacciNumber(92));
            Console.WriteLine(client.FibonacciNumber(-47));
            Console.WriteLine(client.FibonacciNumber(-46));
            Console.WriteLine(client.FibonacciNumber(2));
            Console.WriteLine(client.FibonacciNumber(4));
            Console.WriteLine(client.FibonacciNumber(5));
            Console.WriteLine(client.FibonacciNumber(-4));
            Console.WriteLine(client.FibonacciNumber(-7));
            Console.WriteLine(client.FibonacciNumber(-6));
            Console.WriteLine(client.FibonacciNumber(-5));
            Console.WriteLine(client.FibonacciNumber(-2));
            Console.WriteLine(client.FibonacciNumber(-1));
            Console.WriteLine(client.FibonacciNumber(0));
            Console.WriteLine(client.FibonacciNumber(1));
            Console.WriteLine(client.FibonacciNumber(-93));
            Console.WriteLine(client.FibonacciNumber(93));
            Console.WriteLine(client.FibonacciNumber(93));
            Console.WriteLine(client.FibonacciNumber(-9223372036854775808));
            Console.WriteLine(client.FibonacciNumber(-2147483648));
            Console.WriteLine(client.FibonacciNumber(2147483647));
            Console.WriteLine(client.FibonacciNumber(9223372036854775807));

            Console.WriteLine(client.WhatShapeIsThis(1, 0, 1));
            Console.WriteLine(client.WhatShapeIsThis(1, 2, 1));
            Console.WriteLine(client.WhatShapeIsThis(2, 2, 2));
            Console.WriteLine(client.WhatShapeIsThis(2147483647, 2147483647, 2147483647));
            Console.WriteLine(client.WhatShapeIsThis(2, 2, 3));
            Console.WriteLine(client.WhatShapeIsThis(2, 3, 2));
            Console.WriteLine(client.WhatShapeIsThis(3, 2, 2));
            Console.WriteLine(client.WhatShapeIsThis(2, 3, 4));
            Console.WriteLine(client.WhatShapeIsThis(3, 4, 2));
            Console.WriteLine(client.WhatShapeIsThis(4, 2, 3));
            Console.WriteLine(client.WhatShapeIsThis(4, 3, 2));
            Console.WriteLine(client.WhatShapeIsThis(0, 1, 1));
            Console.WriteLine(client.WhatShapeIsThis(1, 1, 2147483647));
            Console.WriteLine(client.WhatShapeIsThis(-1, -1, -1));
            Console.WriteLine(client.WhatShapeIsThis(-1, 1, 1));
            Console.WriteLine(client.WhatShapeIsThis(1, -1, 1));
            Console.WriteLine(client.WhatShapeIsThis(1, 1, -1));
            Console.WriteLine(client.WhatShapeIsThis(0, 0, 0));
            Console.WriteLine(client.WhatShapeIsThis(-2147483648, -2147483648, -2147483648));
            Console.WriteLine(client.WhatShapeIsThis(1, 1, 0));
            Console.WriteLine(client.WhatShapeIsThis(1, 1, 2));
            Console.WriteLine(client.WhatShapeIsThis(1, 2, 1));
            Console.WriteLine(client.WhatShapeIsThis(2, 1, 1));
            Console.WriteLine(client.WhatShapeIsThis(1, 2, 3));
            Console.WriteLine(client.WhatShapeIsThis(2147483647, 2147483647, 2147483647));
            Console.ReadLine();
        }
    }
}
