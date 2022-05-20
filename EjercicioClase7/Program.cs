int[] numeros = new int[10];
int suma = 0;
int mayor = numeros[0];
int menor = numeros[0];


// Pida 10 números al usuario.
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Por favor ingrese el valor {i+1}: " );
    numeros[i] = int.Parse(Console.ReadLine());
    mayor = numeros[i];
    menor = mayor;
    suma += numeros[i];
}
// Obtener la suma de todos los números ingresados.
Console.WriteLine($"La suma de los numeros ingresados es: {suma}");
// Obtener el promedio de todos los números.
float promedio = suma / numeros.Length;
Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");

// Mostrar todos los números ingresados por pantalla.
Console.WriteLine("Los valores son: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"El valor en la posición {i+1} es {numeros[i]}");
}

// Obtener cual es el menor y mayor de todos los números.
for (int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
   
    else if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}
Console.WriteLine($"El número mayor es {mayor}");
Console.WriteLine($"El número monor es {menor}");

// https://github.com/DianaRussi/EjercicioClase7.git