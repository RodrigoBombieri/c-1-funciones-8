// 2. Hacer una función llamada “mayor” que reciba dos números enteros y
// devuelva el mayor de ellos o cero si son iguales.
// int n1, n2, max;

// Console.WriteLine("Ingrese un número: ");
// n1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese otro número: ");
// n2 = int.Parse(Console.ReadLine());

// max = mayor(n1, n2);

// Console.WriteLine("El mayor es: " + max);


// static int mayor(int a, int b){
//     if (a > b)
//         return a;
//     else if(a==0)
//         return 0;
//     else
//         return b;
// }


// 3. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si
// es par o cero si no lo es. Hacer un programa para ingresar 20 números y
// mostrar por pantalla cuántos son pares.

// int n1, con = 0;

// for (int x = 0; x < 20; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n1 = int.Parse(Console.ReadLine());

//     if (par(n1))
//         con++;
// }

// Console.WriteLine("Hay " + con + " números pares.");


// static bool par(int a){
//     if (a % 2 == 0)
//         return true;
//     else
//         return false;    
// }





// 5. Hacer una función llamada “pagos” que reciba un monto (float) y una cantidad
// de pagos (entero) y devuelva el monto de cada pago. Hacer un programa para
// ingresar 10 ventas. Para cada venta se conoce el monto y la cantidad de pagos.
// El programa deberá mostrar la cantidad de pagos y el monto del pago para
// cada una de las ventas.

// float precio, total;
// int cuotas;

// for (int x = 0; x < 10; x++)
// {
//     Console.WriteLine("Ingrese el monto: ");
//     precio = float.Parse(Console.ReadLine());
//     Console.WriteLine("Cantidad de cuotas: ");
//     cuotas = int.Parse(Console.ReadLine());

//     total = pagos(precio, cuotas);
    
//     Console.WriteLine("El total a pagar es: " + total + " en " + cuotas + " cuotas");
// }


// static float pagos(float monto, int cantidadPagos){
//     int total;
//     total = (cantidadPagos * monto);
//     return total;
// }