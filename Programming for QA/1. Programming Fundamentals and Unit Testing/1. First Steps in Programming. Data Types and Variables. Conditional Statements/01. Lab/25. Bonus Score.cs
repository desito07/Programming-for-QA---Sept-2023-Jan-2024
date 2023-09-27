namespace _03._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            int bonusPoints = 0;

            if (points >= 0 && points <= 3)
            {
                bonusPoints += 5;
            }
            else if (points >= 4 && points <= 6)
            {
                bonusPoints += 15;
            }
            else if (points >= 7 && points <= 9)
            {
                bonusPoints += 20;
            }
            int total = points + bonusPoints;
            Console.WriteLine(total);
        }
    }
}
