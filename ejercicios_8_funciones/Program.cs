// FUNCIONES ESTRUCTURA -----------------------------

// CABECERA
// 1. Tipo de dato
// 2. Nombre
// 3. Opcional: parámetros
//CUERPO
// Definición / Lógica
// Opcional: retorno de valor / resultado.

// MAIN ->
// ES LA QUE INTERACTÚA CON LAS PERSONAS (pedir números, etc.).
// guardo el resultado de la función en una variable n.
// int n = devolverUno();

// Console.WriteLine("Fin del programa: " + n);

// // FUNCIÓN ->
// // ésto va fuera del main
// // Ésta es la cabecera 
// //(tipo de dato / nombre y parámetros entre {})
// static int devolverUno()
// {
//     int nro = 1;
//     return nro;
// }

// EJEMPLO DE UNA FUNCIÓN ----------------------------->
// MAIN
int n1 = 0, n2 = 0, resultado;

// creamos una función para pedir datos, le enviamos los ARGUMENTOS POR REFERENCIA
// no tiene asignación a una variable ya que enviamos los datos por referencia. 
pedirDatos(ref n1, ref n2);

// lógica: por ejemplo una fórmula física o química
// LLAMADO A LA FUNCIÓN con el sumar() y guardo el resultado de la función en una variable resultado.
// Le pasamos los ARGUMENTOS a la función (n1, n2).
resultado = sumar(n1, n2);
// fin de lógica
Console.WriteLine($"El resultado de la suma es: {resultado}");
 

// DECLARACIÓN DE LA FUNCIÓN
// acá va el desarrollo de la fórmula 
// Los valores que se envían se albergan en los PARÁMETROS int a, int b.
static int sumar(int a, int b){
    int r;
    r = a + b;
    return r;
}

// se albergan en los PARÁMETROS j y h. Al ser POR REFERENCIA, se modifica el valor original de las variables en memoria.
// ésta función no tiene return porque es del tipo void, ya que trabaja con los espacios originales.
static void pedirDatos(ref int j, ref int h){
    Console.WriteLine("Ingrese un número: ");
    j = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro: ");
    h = int.Parse(Console.ReadLine());
}


// PARA PASAR VALORES POR REFERENCIA, SE AGREGA LA PALABRA RESERVADA ref, tanto en el llamado a la función,
// cómo en la función misma dentro de los paréntesis. (ref n1, ref n2); (ref int a, ref int b).