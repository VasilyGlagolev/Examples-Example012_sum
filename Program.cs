// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
//12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string numberStr = Console.ReadLine();

if (numberStr.Length != 5)
{
    Console.WriteLine("Введенное число не является пятизначным.");
}
else
{
    bool isPalindrome = true;
    for (int i = 0; i < numberStr.Length / 2; i++)
    {
        if (numberStr[i] != numberStr[numberStr.Length - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }

    if (isPalindrome)
    {
        Console.WriteLine("Введенное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом.");
    }
}