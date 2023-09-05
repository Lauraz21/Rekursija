
Recursion(5);

void Recursion(int number)
{
    if (number == 0)
    {
        return;
    }
    Console.WriteLine(number);

    Recursion(number - 1);

    Console.WriteLine(number);
    return;
}




Console.WriteLine(factorial_Recursion(5));

long factorial_Recursion(long number)
{
    if (number == 1)
    {
        return 1;
    }
    else
    {
        long result = number * factorial_Recursion(number - 1);
        return result;
    }
}
