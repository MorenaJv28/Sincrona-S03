//Ejercicio 5

int[] NUM = { 4, 10, 45, -67, -7, 25, 89, 64 };

Console.WriteLine("Arreglo en orden original");

foreach (int n in NUM)
{
    Console.WriteLine(n);
}

Array.Reverse(NUM);
Console.WriteLine("\nArreglo con Reverse");

foreach (int n in NUM)
{
    Console.WriteLine(n);
}

Array.Sort(NUM);
Console.WriteLine("\nArreglo con Sort");
foreach (int n in NUM)
{
    Console.WriteLine(n);
}