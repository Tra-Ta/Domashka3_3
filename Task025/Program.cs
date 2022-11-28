//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243
//2, 4 -> 16


Console.WriteLine("Enter number A ->");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B ->");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
    int degree = 1;
    int result = 1;
    while (degree <= numB)
    {
        result = result * numA;
        degree++;
    }
    return result;
}
if (numberB > 0)
    Console.WriteLine(Exponentiation(numberA, numberB));
else Console.WriteLine("Number B is not natural");