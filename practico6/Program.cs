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

