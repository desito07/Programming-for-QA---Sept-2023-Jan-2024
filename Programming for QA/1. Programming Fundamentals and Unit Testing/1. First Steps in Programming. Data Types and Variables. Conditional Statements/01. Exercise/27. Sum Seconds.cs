namespace _27._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sumTime = n1 + n2 + n3;
            int minutes = sumTime / 60;
            int seconds = sumTime % 60;

            string leadingZero = "";
            if(seconds < 10)
            {
                leadingZero = "0";
            }
            Console.WriteLine($"{minutes}:{leadingZero}{seconds}");
            

        }
    }
}