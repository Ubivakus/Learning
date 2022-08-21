/*
Синтаксис
Начало
Определить первое число
Определить второе число
Вывести сумму введенных чисел на экран
Конец
*/

int numberA = new Random().Next(1, 10); // число в диапазоне от 1 до 9
int numberB = new Random().Next(1, 10);
Console.WriteLine("Первое число: " + numberA);
Console.WriteLine("Второе число: " + numberB);
int result = numberA + numberB;
Console.WriteLine("Сумма чисел: " + result);