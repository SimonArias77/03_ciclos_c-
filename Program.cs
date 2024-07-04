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
//     string? respuesta = Console.ReadLine(); //para strings en este ciclo se utiliza el ? paradejar que el usuario ponga valor vacío o nulo y de todos modos se ejecute
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


do
{
    Console.WriteLine("Por favor escriba un número entero positivo");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero <= 0)
    {
        Console.WriteLine("el número ingresado no es positivo");
    }
    else
    {
        Console.WriteLine($"números impares desde {numero} hasta 1");

        while (numero >= 1)
        {
            if(numero % 2 != 0)
            {
                Console.WriteLine(numero);
            }
        }
        numero--;
    }
    
} while;





// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no
// es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta
// usando un ciclo while.
// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la
// secuencia de Fibonacci hasta ese número usando un ciclo for.
// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el
// número es primo o no usando un ciclo for.
// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la
// palabra en una línea separada usando un ciclo foreach.
// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma
// de todos los números desde 1 hasta ese número usando un ciclo for.

