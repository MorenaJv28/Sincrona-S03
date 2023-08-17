//EJERCICIO 1

int TAMAÑO;
do
{

    Console.Write("ingresa el tamaño del arreglo (minimo 5)>> ");

}

while (!int.TryParse(Console.ReadLine(), out TAMAÑO) || TAMAÑO < 5);

double[] stock = new double[TAMAÑO];

for (int n = 0; n < stock.Length ; n++)
{
    Console.Write($"Ingresa el valor para la posicón {n +1}: ");
    stock[n] = double.Parse(Console.ReadLine());
}

Console.Write("Valores ingresados: ");
foreach (float n in stock)
{
    Console.Write($" >>{n}");
}

