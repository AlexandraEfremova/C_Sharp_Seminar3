﻿// Задаём массив
int[] numbers = {1, -5, 6, 6, 3, -4, -7};
// Считываем массив и делаем его вывод на экран
foreach(int number in numbers)
{
    // \t позволяет делать аккуратный отступ между элементами 
    // массива, ориентируясь на их местоположение
    // \n делает отступ на новую строку
    System.Console.Write(number + "\t");
}
System.Console.WriteLine(); // добавляем строку между циклами
// Так как при помощи цикла FOREACH видоизменять ничего нельзя, 
// то для того, чтобы произвести замену модуля у чисел используем цикл FOR
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
}
// Опять при помощи цикла FOREACH считаем и выведем уже видоизменённый цикл
foreach(int number in numbers)
{
    System.Console.Write(number + "\t");
}