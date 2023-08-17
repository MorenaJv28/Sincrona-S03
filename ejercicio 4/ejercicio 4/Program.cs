//Ejercicio 3

using System.Threading.Tasks;
string[] word = {"Perro", "Casa", "Cebra", "Tortuga",
"Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol"};

Console.WriteLine("Arreglo sin ordenar: ");
for (int i = 0; i < word.Length; i++)
{
    Console.WriteLine($"Posición {i + 1}: {word[i]}");
}

Array.Sort(word);
Console.WriteLine("\n Arreglo en orden: ");

foreach (string i in word)
{
    Console.WriteLine(i);
}

//Ejercicio 4

Console.WriteLine("\n Busqueda con BinarySearch");

String[] WordSearch = { "Sol", "Dedo", "Casa" };

foreach (string i in WordSearch)
{
    int posición = Array.BinarySearch(word, i);

    if (posición  >= 0)
    {
        Console.WriteLine($"La palabra '{i}' se encontro en la posición {posición}");
    }
    else
    {
        Console.WriteLine($"La palabra '{i}' no se encontro en la posición");
    }
    
}    