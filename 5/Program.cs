int totalLegs = 64;

for (int geese = 0; geese <= totalLegs / 2; geese++)
{
    int numRabbits = (totalLegs - (geese * 2)) / 4;
    int remainingLegs = totalLegs - (geese * 2) - (numRabbits * 4);

    if (remainingLegs == 0)

        Console.WriteLine($"Гусей: {geese}, Кроликов: {numRabbits}");
}
