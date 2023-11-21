namespace Demo_Objects_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog
            {
                Name = "Sparky",
                Breed = "Corgi",
                Age = 3,
            };

            puppy.Bark();

            Dog friend = new Dog();
            friend.Name = "Ivan";
            friend.Breed = "Unknown";
            friend.Age = 3;

            friend.Bark();


            Dog dog1 = new Dog();
            Dog dog = new Dog("John", "Corgi", 2);
            Dog dog2 = new Dog("John", "Corgi2");

            Dog dog2 = new Dog
            {
                Nmae = "Test",
                Age = 1,
            };

            Console.WriteLine(dog2.Name);
        }
    }

    public class Dog
    {
        public Dog()
        {
            Name = "Default Name!";
        }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"{Name}: Bau bau");
        }
    }

    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        int CalcArea()
        {
            return Width * Height;
        }
    }
}