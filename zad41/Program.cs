/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

//Проверка размерности массива на валидность ввода
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0) return result;
        else Console.Write("Введите натуральное число >0: ");
    }
    return result;
}

////Проверка элементов массива на валидность ввода
int CheckArrayOnNumber()
{
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) return result;
        else Console.Write("Введите правильное значение - число: ");
    }
}

//Ввод массива
int[] ArrayInput(int dimension)
{
    int[] array = new int[dimension];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        int tempelem = CheckArrayOnNumber();
        array[i] = tempelem;
    }
    return array;
}

//Вывод массива
void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "  ");
}
int CountNumber(int[] array)
{
    int count = 0;
    Console.WriteLine("\nВведенный массив");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int dimension = GetNumber("Введите размерность массива: ");
int[] myarray = ArrayInput(dimension);
ArrayPrint(myarray);
Console.WriteLine("Элементов массива >0 = " + CountNumber(myarray));
