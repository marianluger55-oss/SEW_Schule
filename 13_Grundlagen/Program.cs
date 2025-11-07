double[] temp = new double[6]; 

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Bitte eine Temperatur eingeben: ");
    temp[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Temperatur in Kelvin: {temp[i] + 273.15}");
}

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Temperatur in Fahreinheit: {temp[i] * (9.0 / 5.0) + 32}");
}