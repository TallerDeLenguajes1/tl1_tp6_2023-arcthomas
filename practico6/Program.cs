// Introducción 

/*
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

// Ejercicio 1

/* 
int num = 0;
string aux;
int resto;
Console.WriteLine("Ingrese un numero: ");
string? input = Console.ReadLine();
aux = input ?? string.Empty;
bool resultado = int.TryParse(aux, out num);
if (resultado == true)
{
    aux = "";
    while (num > 0)
    {
        resto = num % 10;
        num = num / 10;
        aux = aux + String.Concat(resto);   // El numero es vuelto a convertir en String para mostrar el 0 al comienzo
    }
    Console.WriteLine("El numero invertido es: " + aux);
}
else
{
    Console.WriteLine("No se ingresó un numero.");
}
*/

// Ejercicio 4

Console.WriteLine("Ingrese un texto: ");
string? cadena = Console.ReadLine();

if (cadena != null)
{
    Console.WriteLine("1. Longitud de la cadena: " + cadena.Length);
    Console.WriteLine("2. Ingrese otro texto: ");
    string? cadena2 = Console.ReadLine();
    Console.WriteLine("2. Su concatenación es: " + string.Concat(cadena, cadena2));
    string subcadena = cadena.Substring(0, (cadena.Length / 2));
    Console.WriteLine("3. Un fragmento de la primera cadena: " + subcadena);
    Console.WriteLine("5. Recorrido de cada carácter de la cadena:");
    foreach (char c in cadena)
    {
        Console.WriteLine(c);
    }
    Console.WriteLine("6. Ingrese un fragmento a buscar en la primera cadena: ");
    string? search = Console.ReadLine();
    if (search != null)
    {
        if (cadena.Contains(search))
        {
            Console.WriteLine("  - El fragmento si existe en la cadena");
        }
        else
        {
            Console.WriteLine("  - El fragmento no existe en la cadena");
        }
    }
    Console.WriteLine("7. Cadena en mayusculas: " + cadena.ToUpper());
    Console.WriteLine("7. Cadena en minusculas: " + cadena.ToLower());
    Console.WriteLine("8. Cadena a separar: \"Una cadena a separar por espacios\"");
    string cadenaSp = "Cadena a separar por espacios";
    string[] sp = cadenaSp.Split(' ');
    Console.WriteLine("8 Recorrido de la cadena separada por Split()");
    foreach (string x in sp)
    {
        Console.WriteLine(x);
    }
    Console.WriteLine("Ingrese una operación simple SIN ESPACIOS (ej: 32+54, 10*6)");
    string? op = Console.ReadLine();
    int a, b;
    if (op != null)
    {
        if (op.Contains("+"))
        {
            string[] arrayOp = op.Split("+");
            int.TryParse(arrayOp[0], out a);
            int.TryParse(arrayOp[1], out b);
            Console.WriteLine("La suma entre " + a + " y " + b + " es: " + (a + b));
        }
        if (op.Contains("-"))
        {
            string[] arrayOp = op.Split("-");
            int.TryParse(arrayOp[0], out a);
            int.TryParse(arrayOp[1], out b);
            Console.WriteLine("La resta entre " + a + " y " + b + " es: " + (a - b));
        }
        if (op.Contains("*"))
        {
            string[] arrayOp = op.Split("*");
            int.TryParse(arrayOp[0], out a);
            int.TryParse(arrayOp[1], out b);
            Console.WriteLine("La multiplicación entre " + a + " y " + b + " es: " + (a * b));
        }
        if (op.Contains("/"))
        {
            string[] arrayOp = op.Split("/");
            int.TryParse(arrayOp[0], out a);
            int.TryParse(arrayOp[1], out b);
            Console.WriteLine("La división entre " + a + " y " + b + " es: " + (a / b));
        }
    }
}

