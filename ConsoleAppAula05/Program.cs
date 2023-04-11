namespace ConsoleAppAula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laço de Repetição - For

            // escreva um algoritmo que mostre todos os números de 0 a 10.

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            /*
             * Escreva um algoritmo que mostre todos os números de 20 a 5.
             * 
             * **/

            //for(int i = 20; i >= 5; i--)
            //{
            //    Console.WriteLine(i);
            //}


            /*
             * Escreva um algoritmo leia pelo teclado os dois valores inteiros chamados inicio e fim, e então mostre todos os números entre inicio e fim.
             * **/

            //int inicio = int.Parse(Console.ReadLine());
            //int fim = int.Parse(Console.ReadLine());

            //for(int i = inicio; i <= fim; i++)
            //{
            //    Console.WriteLine(i);
            //}


            /*
             * Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.
             * **/

            int valorX = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 100; i+= valorX)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}