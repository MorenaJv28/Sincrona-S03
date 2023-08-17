//Ejercicio 3

using System.Threading.Tasks;
string[] word = {"Perro", "Casa", "Cebra", "Tortuga",
"Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol"};

Console.WriteLine("Arreglo sin ordenar: ");
for(int i = 0; i < word.Length; i++)
{
    Console.WriteLine($"Posición {i + 1}: {word[i]}");
}

Array.Sort(word);
Console.WriteLine("\n Arreglo en orden: ");

foreach (string i in word)
{
    Console.WriteLine(i);
}