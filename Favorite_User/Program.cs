/*
Синтаксис:
Начало
Ввести имя пользователя
ЕСЛИ имя пользователя совпадает с "Маша", то ...
поприветствовать по особенному
ИНАЧЕ поприветствовать по обычному
Конец
*/

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") {
    Console.WriteLine("Ура, это же МАША!");
} else {
    Console.WriteLine("Привет, " + username);
}