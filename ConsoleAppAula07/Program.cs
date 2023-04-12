namespace ConsoleAppAula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = 0;



                while (x <= 0)
                {
                    Console.WriteLine("Informe um valor positivo:");
                    x = int.Parse(Console.ReadLine());
                }


                int soma = 0;
                int contagem = 0;



                for (int i = 1; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + ", ");
                        contagem++;
                        soma += i; // soma = soma + i;
                    }
                }



                Console.WriteLine("Deseja informar outr número s/n");
                string resposta = Console.ReadLine();



                if (resposta == "n")
                {
                    break;
                }
            }
        }
    }
}