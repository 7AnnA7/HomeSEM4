// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (вводим массив с клавиатуры (т. е. через консоль :) ))
int n = 8;
int [] MyArr = new int [n];

for (int i = 0; i < MyArr.Length; i++)
{
    Console.Write($"Введите один из восьми целочисленных элементов массива с индексом {i}: ");
    MyArr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Массив из 8 элементов на экране: ");
for (int i = 0; i < MyArr.Length; i++)
{
    Console.WriteLine(MyArr[i]);
}
