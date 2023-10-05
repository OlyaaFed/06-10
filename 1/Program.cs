double i = -1;
double sum = 0;
while (true)
{
    Console.WriteLine("Введите число посдедовательности.");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
    {
        break;
    }
    {

    }
    sum += i;
    Console.WriteLine($"Сумма элементов последовательности: {sum}");


}