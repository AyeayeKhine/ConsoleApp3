using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "qqqqkkkkkkhkkkkklllqqqqcftryab";
            string output = "";
            int tempCount = 1;
            char temp = ' ';

            temp = input[0];
            for (int i = 1; i < input.Length; i++)
            {               
                if (temp == input[i])
                {
                    tempCount += 1;
                }
                else
                {
                    output += tempCount + "" + temp +" ";
                    tempCount = 1;
                    temp = input[i];

                }
                if(i == input.Length - 1)
                {
                    output += tempCount + "" + temp + " ";
                }
            }
            Console.WriteLine("Result is {0} and Total Count is {1}",output,input.Length);
        }
    }
}
