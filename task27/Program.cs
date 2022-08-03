//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int n = N; n > 0; sum = sum + n % 10, n = n / 10) ;
Console.WriteLine($"Сумма цифр в числе равна {sum}");