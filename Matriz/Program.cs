using System;

class Program
{
    static void Main()
    {
        int[,] matriz;
        int n, m, suma = 0;

        Console.WriteLine("Ingrese la cantidad de filas: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de columnas: ");
        m = int.Parse(Console.ReadLine());

        matriz = new int[n, m];
        LlenarMatriz(ref matriz, n, m);
        SumaMatriz(ref suma, matriz, n, m);

        Console.WriteLine("El resultado de la suma es: " + suma);
    }

    static void LlenarMatriz(ref int[,] matriz, int n, int m)
    {
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matriz[i, j] = rand.Next(0, 10);
            }
        }
    }

    static void SumaMatriz(ref int suma, int[,] matriz, int n, int m)
    {
        suma = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matriz[i, j] + " ");
                suma += matriz[i, j];
            }
            Console.WriteLine();
        }
    }
}


/* Lenguaje JAVA
 import java.util.Random;

public class SumaMatriz
{
    public static void main(String[] args)
    {
        int[][] matriz;
        int n, m, suma = 0;

        System.out.println("Ingrese la cantidad de filas: ");
        n = Integer.parseInt(System.console().readLine());

        System.out.println("Ingrese la cantidad de columnas: ");
        m = Integer.parseInt(System.console().readLine());

        matriz = new int[n][m];
        llenarMatriz(matriz, n, m);
        sumaMatriz(matriz, n, m, suma);

        System.out.println("El resultado de la suma es: " + suma);
    }

    static void llenarMatriz(int[][] matriz, int n, int m)
    {
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matriz[i][j] = rand.nextInt(11); // Rango de valores de 0 a 10
            }
        }
    }

    static void sumaMatriz(int[][] matriz, int n, int m, int suma)
    {
        suma = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                System.out.print(matriz[i][j] + " ");
                suma += matriz[i][j];
            }
            System.out.println();
        }
    }
}*/

