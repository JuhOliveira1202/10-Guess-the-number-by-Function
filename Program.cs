// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int LerNumero()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int NumAleatorio()
    {
        Random num = new Random();
        int numero = num.Next(1, 101);
        return numero;
    }

    public static void AvaliarAposta(int aposta, int numero)
    {
        int tentativas = 1;

        do
        {
            if (aposta > numero)
            {
                Console.WriteLine("O número que introduziu é superior.");
                tentativas = tentativas + 1;
            }
            else if (aposta < numero)
            {
                Console.WriteLine("O número que introdoziu é inferior.");
                tentativas = tentativas + 1;
            }
            Console.Write("Introduza a sua aposta: ");
            aposta = LerNumero();
        } while (aposta != numero);
        Console.WriteLine("Parabéns, acertou o número! (" + numero + "). \nUtilizou" + tentativas + "tentativas");
    }
    static void Main(string[] args)
    {
        int aposta, numero;

        numero = NumAleatorio();

        Console.WriteLine("Introduza a sua aposta:");
        aposta = LerNumero();
        AvaliarAposta(aposta, numero);
    }
}
