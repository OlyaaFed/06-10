double i = 1;
double pr = 1;
while (true)
{
    Console.WriteLine("Введите число посдедовательности для произведениея");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
       
    {
        break;
    }
    {

    }
    pr *= i;
    Console.WriteLine($" Произведение элемента последовательности {pr}");


}
