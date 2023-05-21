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

// Calculadora V2

float a, b;
int aux;
do
{
    Console.WriteLine("Calculadora V2 - Use 0 para salir\n-- Funciones para un numero --\n1 - Valor absoluto\n2 - El cuadrado\n3 - La raiz cuadrada\n4 - Seno\n5 - Coseno\n6 - La parte entera (a partir de un float)\n-- Funciones para dos numeros --\n7 - El máximo numero entre ambos\n8 - El minimo numero entre ambos\nIngrese una función: ");
    int.TryParse(Console.ReadLine(), out aux);
    if (aux != 0 && aux <= 6)
    {
        Console.Write("Ingrese el valor de a: ");
        float.TryParse(Console.ReadLine(), out a);
        switch (aux)
        {
            case 1:
                if (a < 0)
                {
                    a *= -1;
                }
                break;
            case 2:
                a *= a;
                break;
            case 3:
                a = (float)Math.Sqrt(a);
                break;
            case 4:
                a = (float)Math.Sin(a);
                break;
            case 5:
                a = (float)Math.Cos(a);
                break;
            case 6:
                a = (float)Math.Round(a);
                break;
            default:
                break;
        }
        Console.WriteLine("La función devolvió: " + a + "\n");
    }
    else if (aux != 0 && aux <= 8)
    {
        Console.Write("Ingrese el valor de a: ");
        float.TryParse(Console.ReadLine(), out a);

        Console.Write("Ingrese el valor de b: ");
        float.TryParse(Console.ReadLine(), out b);
        switch (aux)
        {
            case 7:
                Console.WriteLine("El máximo numero entre ambos es: " + Math.Max(a, b) + "\n");
                break;
            case 8:
                Console.WriteLine("El minimo numero entre ambos es: " + Math.Min(a, b) + "\n");
                break;
            default:
                break;
        }
    }
    else
    {
        if (aux != 0)
        {
            Console.WriteLine("No se ingresó una función válida.\n");
        }
    }
} while (aux != 0);
Console.WriteLine("\nFin del programa");