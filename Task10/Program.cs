int SecondNumber(int num)
{
int seconNum = num / 10 % 10;
return seconNum;
}

int randomNum = new Random().Next(100, 1000);
Console. WriteLine($"Число на вход: {randomNum}");

int newNum = SecondNumber(randomNum);
Console. WriteLine($"Новое число: {newNum}");