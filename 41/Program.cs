/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 3
*/

Console.WriteLine("Введите целые числа через ПРОБЕЛ");

int[] number = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int summ = 0;

for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > 0)
                {
                summ++;
                }

        Console.Write($"{number[i]}, ");
        }

Console.Write($"-> {summ}");