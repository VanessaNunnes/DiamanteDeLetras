namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ASCII A-Z 65-90
            Console.WriteLine("Informe uma letra: ");
            char letra = Convert.ToChar(Console.ReadLine());

            int altura = letra - 65 + 1;

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < altura - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write((char)(65 + i));

                if (i > 0)
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write((char)(65 + i));
                }
                Console.WriteLine();
            }

            for (int i = altura - 2; i >= 0; i--)
            {
                for (int j = 0; j < altura - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write((char)(65 + i));

                if (i > 0)
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write((char)(65 + i));
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
