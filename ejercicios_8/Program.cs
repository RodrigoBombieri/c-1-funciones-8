// EJERCICIO 1 --------------------------------------------------
// 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
// Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar.
// Usar la función.

// int precio, cantidadVendida, resultado;

// Console.WriteLine("Ingrese el precio del artículo: ");
// precio = int.Parse(Console.ReadLine());
// Console.WriteLine("Cantidad vendida: ");
// cantidadVendida = int.Parse(Console.ReadLine());

// resultado = producto(precio, cantidadVendida);
// Console.WriteLine("El monto total a pagar es: " + resultado);

// static int producto(int a, int b){
//     int r = a * b;
//     return r;
// }



// EJERCICIO 2 ---------------------------------------------
// 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
// Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

// int n1, con = 0;

// for (int x = 0; x < 20; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n1 = int.Parse(Console.ReadLine());
//     // pregunto si el numero enviado a la función es == true y lo cuento.
//     if (numeroPar(n1) == true)
//         con++;

// }

// Console.WriteLine("Hay " + con + " números pares.");

// static bool numeroPar(int a){   
//     if(a % 2 == 0)
//         return true;
//     else
//         return false;
// }


// EJERCICIO 3 ----------------------------------------------------
// 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
// Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
// Informar el promedio teniendo en cuenta sólo los números primos.

// int n1, promedio, con = 0, acu = 0;

// Console.WriteLine("Ingrese un número: ");
// n1 = int.Parse(Console.ReadLine());

// while (n1 != 0)
// {
//     if(numeroPrimo(n1) == true){
//         con++;
//         acu+=n1;
//     }
//     Console.WriteLine("Ingrese otro: ");
//     n1 = int.Parse(Console.ReadLine());    
// }

// promedio = acu / con;
// Console.WriteLine("El promedio es: " + promedio);


// static bool numeroPrimo(int a){
//     int con = 0;
//     for (int x = 1; x <= a; x++)
//     {
//         if(a % x == 0)
//             con++;
//     }

//     if(con == 2)
//         return true;
//     else
//         return false;
// }


// EJERCICIO 4 ---------------------------------------------
// 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
// que reciba un número por valor y una variable por referencia. 
// Que analice el número y escriba la variable recibida por referencia con:
    // a. 1 si el número es positivo.
    // b. -1 si el número es negativo.
    // c. 0 si el número es cero. 

// int n1, num = 0;

// Console.WriteLine("Ingrese un número: ");
// n1 = int.Parse(Console.ReadLine());

// positivoNegativoCero(n1, ref num);

// Console.WriteLine("El estado del número: " + n1 + " es " + num);

// static void positivoNegativoCero(int a, ref int var){
//     if (a == 0)
//         var = 0;
//     else if(a > 0)
//         var = 1;
//     else
//         var = -1;
// }