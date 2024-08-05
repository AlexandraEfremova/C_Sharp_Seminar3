// Задаём массив и выводим его для пользователя
int[] numbers = {1, -5, 6, 6, 3, -4, -7, 34, 6, 3, 58, -8, -3};
foreach(int number in numbers)
{
    System.Console.Write(number + " ");
}
System.Console.WriteLine();
// Создаём и определяем размер нового массива. Определяется он следующим образом.
// Так как у нас будут пары старого массива, то мы просто размер старого массива делим на 2
int[] multPairs = new int[numbers.Length / 2];
// Определяемся с циклом. Цикл FOR будет идти до того момента, пока не закончится место
// в массиве multPairs
// for(int i = 0; i < multPairs.Length; i++)
// {
//     // В следующей строке новыми данными наполням новый массив.
//     // numbers[numbers.Length - 1 - i] - данная конструкция 
//     // вычисляет второе число из пары для произведения
//     multPairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
// }
// Так же есть второй вариант цикла с двумя переменными счётчиками
for(int i = 0, j = numbers.Length - 1; i < multPairs.Length; i++, j--)
{
    multPairs[i] = numbers[i] * numbers[j];
}

foreach (int pair in multPairs)
{
    System.Console.Write(pair + "\t");
}