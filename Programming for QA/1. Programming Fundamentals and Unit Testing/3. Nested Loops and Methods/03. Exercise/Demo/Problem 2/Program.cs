﻿using System;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());


int result1 = GetFactorial(num1);
int result2 = GetFactorial(num2);

Console.WriteLine(result1 / result2);

static int GetFactorial(int num)
{
    int factoriel = 1;
    for (int i = 1; i <= num; i++)
    {
        factoriel = factoriel * i;
    }
    return factoriel;
}




