int age = 17;
double gpa = 4.5;
bool isStudent = true;
string name = "Дмитрий";

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(gpa);
Console.WriteLine(isStudent);

var city = "Волжский";
var year = 2026;
var pi = 3.14159;
var isActive = true;

string myName = "Дмитрий";
int myAge = 20;
string myGroup = "ИСП-241";
Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}");

Console.Write("Введите ваше имя: ");
string name2 = Console.ReadLine();
Console.WriteLine($"Привет, {name2}!");

Console.Write("Введите ваш возраст: ");
string input = Console.ReadLine();
int age = int.Parse(input);
Console.WriteLine($"Через 10 лет вам будет {age + 10} лет.");

int x = 10;
int y = 3;
Console.WriteLine(x + y);
Console.WriteLine(x - y);
Console.WriteLine(x * y);
Console.WriteLine(x / y);
Console.WriteLine(x % y);
