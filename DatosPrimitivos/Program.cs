using System;

class Program
{
    static void Main()
    {
        // Tipos numéricos enteros
        byte miByte = 255;          // 0 a 255 (1 byte)
        short miShort = -32000;     // -32,768 a 32,767 (2 bytes)
        int miInt = 2147483647;     // -2,147,483,648 a 2,147,483,647 (4 bytes)
        long miLong = 9223372036854775807L; // 8 bytes

        // Tipos numéricos con decimales
        float miFloat = 3.14f;      // Precisión simple (4 bytes)
        double miDouble = 3.14159265359; // Precisión doble (8 bytes)
        decimal miDecimal = 1000.99m;     // Alta precisión para dinero (16 bytes)

        // Tipo carácter y cadena de texto
        char miChar = 'A';          // Un solo carácter Unicode (2 bytes)
        string miString = "Hola, mundo"; // Cadena de texto

        // Tipo booleano
        bool miBool = true;         // true o false

        // Tipo var (inferencia de tipo)
        var miVar = 123;            // El compilador infiere que es int

        // Tipo objeto (base de todos los tipos)
        object miObject = "Puede almacenar cualquier tipo";

        // Mostrar en consola
        Console.WriteLine($"byte: {miByte}");
        Console.WriteLine($"short: {miShort}");
        Console.WriteLine($"int: {miInt}");
        Console.WriteLine($"long: {miLong}");
        Console.WriteLine($"float: {miFloat}");
        Console.WriteLine($"double: {miDouble}");
        Console.WriteLine($"decimal: {miDecimal}");
        Console.WriteLine($"char: {miChar}");
        Console.WriteLine($"string: {miString}");
        Console.WriteLine($"bool: {miBool}");
        Console.WriteLine($"var: {miVar}");
        Console.WriteLine($"object: {miObject}");
    }
}
