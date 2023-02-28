// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// создать массив +

int[] CreateArray(int size)
{
    return new int[size];
}

// ввод данных пользователем +
int Input(string number)
{
    Console.Write(number + " ");
    return Convert.ToInt32(Console.ReadLine());
}

// Печать +
  void Print1(int[] array)
  {
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
      Console.Write(array[index] + " ");
      index++;
    }
    System.Console.WriteLine();
  }

// Заполнение руками
  void FillByUser(int[] array)
  {
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
      array[index] = Input("Введите array[" + index + "]: ");
      index++;
    }
  }

// вывод количества раз +
void Find(int[] numbers)
{
    int index = 0;
    int count = 0;
    // int number = Input("Введите число: ");

    for (index = 0; index < numbers.Length; index++)
        {
            if (numbers[index] > 0)
            count = count + 1;
        }
        Console.WriteLine(count + " раза больше 0");
}

int count = Input("Введите размер массива ");
int[] numbers = CreateArray(count);
Print1(numbers);
FillByUser(numbers);
// int[] numbers = new ; 
// int length = numbers.Length;
Find(numbers);