//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//
//452 -> 11    
//82 -> 10
//9012 -> 12

Console.WriteLine("Enter number ->");
int number =Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int count = NumberOfDigits(number);
int SumDigits(int num)
{
    int sum = 0;
    for (int i = 1; i <= count; i++)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine(SumDigits(number));