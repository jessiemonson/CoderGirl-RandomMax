using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int[] numList = new int[100];
            int topValue = 0;
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(0, 1000);
                numList[i] = randomNumber;
            }
            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.
            foreach (int i in numList)
            {
                if(i > topValue)
                {
                    topValue = i;
                }
            }
            Console.WriteLine(topValue);
            Console.ReadLine();
        }
    }
}
