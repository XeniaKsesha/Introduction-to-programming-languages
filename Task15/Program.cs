Console.Clear();

Console.Write("Введите цифру, обозначающую день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 5); {
    Console.WriteLine("Сегодня рабочий день");
}
if (n > 5) {
    Console.WriteLine("Сегодня выходной день"); 
}

//выдает на выходных днях что они и рабочие тоже, тролль
// но как исправить не знаю :(