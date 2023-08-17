//Ejercicio 2

using System.ComponentModel.DataAnnotations;

string[] NombreComplet = { "Morena", "Beralia", "Gutierrez", "Jovel" };

Console.WriteLine("Valores de Arreglo: ");

foreach (var i in NombreComplet)
{
    Console.WriteLine(i);
}

int TamañoA = NombreComplet.Length;

Console.WriteLine($"\nTamaño del arreglo: {TamañoA}");

Console.WriteLine($"\nTamaño del arreglo y valores: ");

for (int i = 0; i < TamañoA; i++)
{ 
    Console.WriteLine($"Posición {i+1}: {NombreComplet[i]}");
}


