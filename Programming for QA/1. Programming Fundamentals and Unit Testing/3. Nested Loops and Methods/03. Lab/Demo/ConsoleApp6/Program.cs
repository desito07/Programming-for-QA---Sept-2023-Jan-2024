int based = int.Parse(Console.ReadLine());
int power =  int.Parse(Console.ReadLine());

static int BasedRaisedToPower(int based, int power)
{
   /* int output = based;
    for(int i = 0; i < power - 1; i++)
    {
        output *= based;
    }*/
   int output = (int)Math.Pow(based, power);
   return output;
    
}
int result = BasedRaisedToPower(based, power);

Console.WriteLine(result);