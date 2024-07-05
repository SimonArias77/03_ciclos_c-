// CICLO FOR

//primero crear al contador/ luego decir cuantas vueltas dará/ luego declarar el incrementador i++
// for (int i = 0; i < 10; i++) // 10 sería el número de repeticiones o vueltas, el i++ es para sumar de uno en uno
// {
//     Console.WriteLine($"hola coders, esta es la iteración número {i}");
// }


// CICLO FOR EACH

// using System.ComponentModel;

// string[] nombres = {"Juan", "Pedro", "Ana"};

// Lista de nombres (SE RECOMIENDA TRABAJAR MEJOR CON LISTAS QUE CON ARRAYS)


// Array (NO SE RECOMIENDA)



// while (true) // false
// {
//     Console.WriteLine("sigue adelante");
//     Console.WriteLine("quieres repetir la iteración");
//     string? respuesta = Console.ReadLine(); //para strings en este ciclo se utiliza el ? para dejar que el usuario ponga valor vacío o nulo y de todos modos se ejecute
//     if (respuesta?.ToLower() == "no")
//     {
//         break; // se usa el return para romper el ciclo en este caso, se puede usar bandera tambien o  poner break
//     }
// }


//Ejercicios.

// 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.

// for (int i = 1; i<100; i++)
// {
//     Console.WriteLine($"esta es la iteración número: {i}");
// }

// 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// números pares desde 1 hasta ese número usando un ciclo for.

// int numero = 100;
// for (int i = 1; i<=numero; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine($"esta es la iteración número: {i}");
//     }
// }

// 3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de
// multiplicar de ese número del 1 al 10 usando un ciclo for.


// Console.WriteLine("por favor escriba un número entero positivo");
// int numero = int.Parse(Console.ReadLine());

// for (int i=1; i<=10; i++) 
// {
//     Console.WriteLine($"{i} X {numero} = {i*numero}"); 
// }

// 4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que
// adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado
// alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que
// adivine correctamente usando un ciclo do-while.

// Random aleatorio = new Random();
// int numero = aleatorio.Next(1, 100);
// int intento;

// do
// {
//     Console.WriteLine("Adivina un número entre el 1 y el 100");
//     intento = Convert.ToInt32(Console.ReadLine());
//     if (intento < numero)
//     {
//         Console.WriteLine("el número ingresado es muy bajo, intenta de nuevo");

//     }

//     else if (intento > numero)
//     {
//         Console.WriteLine("el número es muy alto, intenta de nuevo ");
//     }
//     else
//     {
//         Console.WriteLine("correcto!, adivinaste el número");

//     }
// } while (numero != intento);


// 5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// números impares desde ese número hasta 1 usando un ciclo while.


// Console.WriteLine("Por favor ingresa un numero entero positivo: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// while (numero >= 1) // " while = mientras que"  el número sea mayor o igual a 1
// {
//     if (numero % 2 != 0) // si al dividir el número por 2 el cociente es "diferente de cero" entonces quiere decir que es impar y se puede operar
//     {
//         Console.WriteLine(numero);
//     }
//     numero--; //finalmente se opera el número restandole "2 unidades en cada ciclo (numero--;)" hasta llegar a 1.
// }


// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no
// es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta
// usando un ciclo while.


// string contraseñaCorrecta = "secreta";
// string contraseñaIngresada;

// Console.WriteLine("por favor ingrese su contraseña:");

// while (true)
// {
//     contraseñaIngresada = Console.ReadLine(); 
//     if (contraseñaIngresada == contraseñaCorrecta)
//     {
//         Console.WriteLine("Contraseña correcta!");
//         break;
//     }
//     else 
//     {
//         Console.WriteLine("Contraseña incorrecta. Intente de nuevo:");
//     }
// }



// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la
// secuencia de Fibonacci hasta ese número usando un ciclo for.

// Console.WriteLine("ingrese un número entero positivo para ejecutar la secuencia de Fibonacci:");
// int numeroLimite;

// // Verificamos por medio de un ciclo "while" que el número sea un entero positivo

// while (true)
// {
//     string? numeroIngresado = Console.ReadLine();
//     if (int.TryParse(numeroIngresado, out numeroLimite) && numeroLimite > 0)
//     {
//         break; // sale del ciclo si el número ingresado es válido.
//     }
//     else
//     {
//         Console.WriteLine("el número ingresado no es válido, intenta de nuevo");
//     }
// }

// // Variables de la secuencia Fibonacci
// int a = 0, b = 1;

// Console.WriteLine($"secuencia de Fibonacci hasta el número {numeroLimite}");

// for ( int i = 0; a <= numeroLimite; i++)
// {
//     Console.Write(a + "");

//     int temporal = a;
//     a = b;
//     b = b + temporal;
// }

// Console.WriteLine();



// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el
// número es primo o no usando un ciclo for.


// Console.WriteLine("Por favor ingrese un número entero positivo:");
// int numeroIngresado;

// // Por medio de un ciclo "while" hacemos validación de que el número ingresado sea entero positivo.

// while (true)
// {
//  string? input = Console.ReadLine();
//  if (int.TryParse(input, out numeroIngresado) && numeroIngresado > 0)
//  {
//      break; // sale del ciclo si el número ingresado es válido.
//  }
//  else
//  {
//     Console.WriteLine("el número ingresado no es válido, intente de nuevo:");
//  }
// }


// bool esPrimo = true;

// // Verificamos si el número es primo utilizando un ciclo "for"

// for (int i = 2; i < numeroIngresado; i++) // se inicializa el ciclo en 2 porque la definiciónde un numero primo dice que: son números mayores a 1 que se dividen solo por si mismos y por 1.
// {
//  if (numeroIngresado % i == 0)
//  {
//     esPrimo = false;
//     break; // sale del ciclo si encuentra un divisor
//  }
// }

// // Imprimimos el resultado

// if (esPrimo)
// {
//     Console.WriteLine($"{numeroIngresado} es un número primo");
// }
// else
// {
//     Console.WriteLine($"el numero: {numeroIngresado} no es primo");
// }

// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la
// palabra en una línea separada usando un ciclo foreach.

// Console.WriteLine("por favor escriba una palabra:");
// string? palabra = Console.ReadLine();

// foreach (char letra in palabra)
// {
//     Console.WriteLine(letra);
// }

// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma
// de todos los números desde 1 hasta ese número usando un ciclo for.


using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Por favor ingrese un número entero positivo:");
string? input = Console.ReadLine();


// Intentamos convertir la entrada a un número entero
if (int.TryParse(input, out int numero) && numero > 0)
{
    int suma = 0;

    // Calculamos la suma utilizando un ciclo for
    for (int i = 1; i <= numero; i++)
    {
        suma += i;
    }

    Console.WriteLine($"La suma de todos los números desde 1 hasta {numero} es: {suma}");
}
