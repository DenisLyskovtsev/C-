Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()); 
for (int i = 2; i <= number;)
{
    Console.Write($"{i} ");
    i = i + 2;
}