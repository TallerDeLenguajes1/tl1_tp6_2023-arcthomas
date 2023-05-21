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
aux = Console.ReadLine();
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

// CalculadoraV1

float a, b, c = 0;
int aux;
do
{
    Console.WriteLine("Calculadora V1\n0 - Salir\n1 - Suma\n2 - Resta\n3 - Multiplicacion\n4 - Division\nIngrese una opcion: ");
    int.TryParse(Console.ReadLine(), out aux);
    if (aux != 0)
    {
        Console.Write("Ingrese el valor de a: ");
        float.TryParse(Console.ReadLine(), out a);

        Console.Write("Ingrese el valor de b: ");
        float.TryParse(Console.ReadLine(), out b);
        switch (aux)
        {
            case 1:
                c = a + b;
                break;
            case 2:
                c = a - b;
                break;
            case 3:
                c = a * b;
                break;
            case 4:
                c = a / b;
                break;
            default:
                break;
        }
        Console.WriteLine("\nEl resultado de la operación entre " + a + " y " + b + " es: " + c);
    }
} while (aux != 0);
Console.WriteLine("\nFin del programa");