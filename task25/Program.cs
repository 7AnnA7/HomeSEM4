//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int res = 1;
for (int i = 1; i <= B; i++)
{
    res = res * A;
}

Console.WriteLine($"Число А в степени В: {res}");
