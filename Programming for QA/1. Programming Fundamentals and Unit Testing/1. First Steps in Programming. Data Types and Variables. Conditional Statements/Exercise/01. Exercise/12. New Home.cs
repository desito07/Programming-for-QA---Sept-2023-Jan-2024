namespace _03._New_Home
{
    internal class Program
    {
        static void Main(string[] args)
    {
            string typeOfFrower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double cost = 0.00;
            
            
            if(typeOfFrower == "Roses")
            {
                cost = 5 * count;
                if (count > 80)
                {
                    cost -= cost * 0.1;
                }
            }
            else if (typeOfFrower == "Dahlias")
            {
                cost = 3.80 * count;
                if (count > 90)
                {
                    
                    cost -= cost * 0.15;
                }
            }
            else if (typeOfFrower == "Tulips")
            {
                cost = 2.80 * count;
                if (count > 80)
                {
                    cost -= cost * 0.15;
                }
            }
            else if (typeOfFrower == "Narcissus")
            {
                cost = 3 * count;
                if (count < 120)
                {
                    cost += cost * 0.15;
                }
            }
            else if (typeOfFrower == "Gladiolus")
            {
                cost = 2.50 * count;
                if (count < 80)
                {
                    cost += cost * 0.2;
                }
            }
            if(budget >= cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {typeOfFrower} and {(budget - cost):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(cost - budget):f2} leva more.");
            }
            


        }
    }
}