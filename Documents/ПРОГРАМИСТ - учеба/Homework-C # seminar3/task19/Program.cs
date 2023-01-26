// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int a=Convert.ToInt32(Console.ReadLine());

if (a>9999 || a<100000)   
{
        string b=Convert.ToString(a);
    if (b[0]==b[4] && b[1]==b[3]) Console.WriteLine("Данное число является полиндромом");
    else Console.WriteLine("Данное число НЕ является полиндромом");
}
else Console.WriteLine("Ошибка ввода");