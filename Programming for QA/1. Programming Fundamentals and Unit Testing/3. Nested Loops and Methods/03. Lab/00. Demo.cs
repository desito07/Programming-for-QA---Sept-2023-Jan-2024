namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // THE CLOCK WITH HOURS MIN SECONDS
            //for (int hour = 0; hour <= 23; hour += 1)
            //{

            //    for (int min = 0; min <= 59; min += 1)
            //    {
            //        for (int sec = 0; sec <= 59; sec += 1)
            //        {
            //            if (min < 10 && sec < 10 || hour < 10)
            //            {
            //                 Console.WriteLine($"0{hour}:0{min}:0{sec}");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{hour}:{min}:{sec}");
            //            }

            //        }
            //    }
            //}
            //----------------------------------------------------------------------------
            // STARS 
            // * * * 
            // * * * 
            // * * * 

            //int n = 9;

            //for (int row = 1; row<= n; row++)
            //{
            //    // printa our row
            //    for (int col = 1; col <= n; col++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}
            //-----------------------------------------------------------------------------
            // ROWS & COLS
            int rows = 3;
            int cols = 5;

            for(int r = 1; r <= rows; r++) { 
                Console.WriteLine("row = " + r);

                for(int c = 1; c <= cols; c++)
                {
                    Console.WriteLine(" cols = " + c);
                }
            }

            
        }
    }
}