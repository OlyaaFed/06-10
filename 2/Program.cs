Console.Write("Введите количество дней (k): ");
int k = Convert.ToInt32(Console.ReadLine());

double dist = 10;  
double Distance = 0;  

for (int day = 1; day <= k; day++)
{
   Distance += dist;
    dist *= 1.1; 
}

Console.WriteLine($"спортсмен пробежит данную дистанцию за количество такое {k} дней: такое расстояние{Distance} км");





