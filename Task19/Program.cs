// Выдаёт ошибку
// Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array
//at System.String.get_Chars(Int32 index)
//at Program.<Main>$(String[] args) in C:\Users\bounc\Desktop\курс сисадмина\3 знакомство с языком c# домашки\Introduction-to-programming-languages\Task19\Program.cs:line 6

Console.Clear();

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
int n = number.Length;
Console.WriteLine(Convert.ToInt32(number[n].ToString()));

while (n > 5)
{
    string? number1 = Console.ReadLine();
    Console.WriteLine($"ОШИБКА: {number1} не является пятизначным\nВведите пятизначное число: ");
}

if (n == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine($"{number} - палиндром");
        }
    else
    {
    Console.WriteLine($"{number} - не палиндром");
    }
}