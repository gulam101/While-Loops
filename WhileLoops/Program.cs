using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            while(index <= 5)
            {
                Console.WriteLine(index);
                index++; // Adds 1
            }
            //We set the index value to 1
            //Next we say if it is less than 5 add 1 onto the value
            //Finally it will stop looping until it reaches to 5

            //int breakHouse = 10;

            //while(breakHouse <= 50 )
            //{
            //    Console.WriteLine(breakHouse);                
            //        breakHouse++;
            //}

            //Do while loop

            int brains = 12;

            //Do while will execute the code in the loop before 
            //it checks the condition
            do
            {
                Console.WriteLine(brains);
                brains++;

            } while (brains <= 12);
            {
                Console.ReadLine();
            }
        }
    }
}
