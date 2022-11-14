// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int size) // просим пользователя ввести числа и записываем их в массив
{
    int[] arr = new int[size];
    Console.WriteLine($"Введите {size} целых чисел: ");
    for(int i = 0; i < arr.Length; i ++)
    {
        Console.WriteLine($"число {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return arr;
}

int CountPositive(int[] array) // считаем количество чисел в массиве, которые > 0
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0) count ++;
    }
    return count;
}

int m = new Random().Next(1, 10); // случайным образом выбираем количество чисел, которое должен ввести пользователь
int[] userMassiv = FillArray(m);
Console.WriteLine($"Количество позитивных чисел, введенных вами: {CountPositive(userMassiv)}");