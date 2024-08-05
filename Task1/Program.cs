int[] numbers = {1, 3, 4, 19, 3};

// for(int i = 0; i < numbers.Length; i++)
// {
//     // Вывод всех элементов массива счерез пробел
//     System.Console.Write(numbers[i] + " ");
// }

// Рассмотрим этот же вариант с циклом FOREACH
// Однако если задать переменную до цикла и попробовать 
// в неё сложить все переменные по порядку
// при помощи цикла FOREACH то ошибки у нас не будет
// int temp = 0
foreach(int number in numbers)
{
    // temp += number - переменные по-порядку плюсуются в общую переменную
    System.Console.Write(number + " ");
}
// System.Console.WriteLine(temp);
// Запросим у пользователя число, которое мы будем искать в массиве.
System.Console.Write("Введите число: ");
int numberToFind = Convert.ToInt32(Console.ReadLine());

// Далее нужно определить есть ли заданное пользователем число в массиве
// Для этого переменную создадим булевую переменную numberIsFind, которая изначально
// Будет иметь ложное значение (False)
bool numberIsFind = false; // мы ещё не нашли переменную
foreach(int number in numbers)
{
    // Внутри цикла создаём другой цикл, который отвечает за поиск числа в массиве
    if(number == numberToFind)
        numberIsFind = true; // мы нашли переменную
}
// Вывод булевого значения на экран
// System.Console.WriteLine(numberIsFind);
// Так же можно создать ветвление при помощи булевой переменной
if(numberIsFind)
// Вывод строки в случает будевого ответа TRUE
    System.Console.WriteLine("Значение найдено!");
else
// Вывод строки в случае булевого ответа FALSE
    System.Console.WriteLine("Значения НЕТ");
