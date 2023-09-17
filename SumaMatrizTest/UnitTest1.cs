using NUnit.Framework;
using System;

public class SumaMatrizTest
{
    public static int[,] LlenarMatriz(int n, int m)
    {
        int[,] matriz = new int[n, m];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matriz[i, j] = rand.Next(11);
            }
        }

        return matriz;
    }

    public static int SumaMatriz(int[,] matriz)
    {
        int suma = 0;
        int n = matriz.GetLength(0);
        int m = matriz.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                suma += matriz[i, j];
            }
        }

        return suma;
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestSumaMatriz()
        {
            int[,] matriz = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int resultadoEsperado = 45;
            int resultadoObtenido = SumaMatriz(matriz);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    } 
}
