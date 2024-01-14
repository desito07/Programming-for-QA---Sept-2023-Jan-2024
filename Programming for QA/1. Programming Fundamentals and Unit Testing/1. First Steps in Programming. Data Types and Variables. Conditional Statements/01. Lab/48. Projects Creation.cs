string name = Console.ReadLine();
int countOfProjects = int.Parse(Console.ReadLine());

int countOfHoursPerProject = countOfProjects * 3;
Console.WriteLine($"The architect {name} will need {countOfHoursPerProject} hours to complete {countOfProjects} project/s.");