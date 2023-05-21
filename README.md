# Taller de Lenguajes I
## TP 6
### Bertoluzzi Thomas

### Ejercicio 4, preguntas
#### ¿String es una tipo por valor o un tipo por referencia?
String es un tipo por referencia pero aunque string es un tipo por referencia, se definen los operadores de igualdad == y != para comparar los valores de los objetos string, no las referencias.
#### ¿Qué secuencias de escape tiene el tipo string?
| Secuencia de escape| Representación |
|--------------------|:---------------|
| **\a** | carácter de campana (alarma) |
| **\b** | un retroceso |
| **\t** | carácter de tabulación |
| **\r** | retorno de carro |
| **\v** | una tabulación vertical |
| **\f** | avance de página |
| **\n** | una nueva línea |
| **\xcc** | carácter ASCII, donde `cc` es un código de carácter hexadecimal de dos dígitos |
| **\nnn** | un carácter ASCII, donde `nnn` está compuesto de dos o tres dígitos que representan el código de carácter octal |
| **\unnnn** | una unidad de código UTF-16 cuyo valor hexadecimal es `nnnn` |
#### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Al utilizar el carácter @ antes de una cadena, se desactivan las secuencias de escape. Esto significa que las barras invertidas \ se tratan como caracteres normales y no como el inicio de una secuencia de escape. Resulta muy útil para cuando se usan rutas de archivos ya que usan estas barras.
Cuando usamos el símbolo $ antes de una cadena de texto, se crea una cadena interpolada. En una cadena interpolada, se pueden incluir expresiones o variables dentro de llaves `{}` y serán reemplazadas por su valor correspondiente. Esto permite construir cadenas de forma más legible y concisa.