// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 0; i <= num; i++)
// {
//     // sum = sum + i;
//     sum += i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

// Реализуем с помощью метода

int SumNumber(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int result = SumNumber(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");