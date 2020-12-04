using System;
using System.IO;
using System.Collections.Generic;


namespace day1
{
    class Program
    {
        const int sumtotal = 2020;
        static void Main(string[] args)
        {
            // Test if input arguments were supplied.
            if (args.Length != 1)
            {
                Console.WriteLine("Please provide an input file.");
            }
            try
            {
                String[] lines = System.IO.File.ReadAllLines(args[0]);
                Stack<int> stack = new Stack<int>();
                
                foreach(var line in lines)
                {
                    int result;
                    Int32.TryParse(line, out result);
                    stack.Push(result);
                }

                while(stack.Count > 0)
                {
                    int top = stack.Pop();
                    foreach(var item in stack)
                    {
                        if( (top + item) == sumtotal )
                        {
                            int answer = (top * item);
                            Console.WriteLine($"Numbers are {top} and {item}");
                            Console.WriteLine($"Answer is {answer}");
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.Write($"Error reading file: {e}");
            }
        }
    }
}
