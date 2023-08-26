//un arreglo que contenga las posiciones y los valores  del abecedario 
//una lista en la que hay que ingresar un nombre letra por letra
//la primera letra  del nombre debe buscar la posicion del arreglo en el que esta

String[] Alfabeto = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
    "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" }; 

List<char> Name = new List<char>(); 
Console.WriteLine("Ingrese su nombre letra por letra (escribe 'exit' para culminar el programa):");

while (true) 
{ string Ent = Console.ReadLine().ToUpper(); 
    if (Ent == "EXIT") break; 
    
    foreach (char L in Ent)
    
    { Name.Add(L); }
}

if (Name.Count > 0) 
{ char primerLetra = Name[0]; 
    int Position = Array.BinarySearch(Alfabeto, primerLetra.ToString()); 
    
    
    if (Position != -1) { Console.WriteLine($"\nEl primer carácter '{primerLetra}' se encuentra en la posición {Position + 1} del abecedario."); } 
    
    
    else { Console.WriteLine($"\nEl primer carácter '{primerLetra}' no está en el alfabeto."); } }

//MORENA BERALIA GUTIERREZ JOVEL
