using System;

namespace DiamanteLetras2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Informe uma letra:");
            char letraInformada = Convert.ToChar(Console.ReadLine());

            int numEspacosFora = 0, numEspacosDentro =0;

            for (int x = 0; x < alfabeto.Length; x++)
            {
                if (alfabeto[x] == letraInformada) break;
                numEspacosFora++;
            }

            //parte de cima
            for (char letraAtual = 'a'; letraAtual <= letraInformada; letraAtual ++)
            {
                for (int x = 0; x < numEspacosFora; x++) Console.Write(" ");
                numEspacosFora--;
                Console.Write(letraAtual);
                for (int x = 0; x < numEspacosDentro; x++) Console.Write(" ");

                if (numEspacosDentro != 0)
                {
                    Console.Write(letraAtual);
                    numEspacosDentro ++;
                }
                numEspacosDentro++;

                Console.WriteLine();
            }

            letraInformada--;
            numEspacosFora = 0;
            numEspacosDentro -= 2;

            //parte de baixo
            for (char letraAtual = letraInformada; letraAtual>='a'; letraAtual--)
            {
                numEspacosFora++;
                numEspacosDentro-=2;

                for (int x = 0; x < numEspacosFora; x++) Console.Write(" ");

                Console.Write(letraAtual);

                for (int x = 0; x < numEspacosDentro; x++) Console.Write(" ");

                if (numEspacosDentro >= 0 )
                {
                    Console.Write(letraAtual);
                }

                Console.WriteLine();
            }
        }
    }
}
