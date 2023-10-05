
Console.WriteLine("Введите часы кратные трем");
int k = Convert.ToInt32(Console.ReadLine());
;
int amb = 1;
 for (int hours = 3; hours <= k; hours += 3)
{
    amb *= 2; 
}


Console.WriteLine($"Через {k} часов будет {amb} амеб.");