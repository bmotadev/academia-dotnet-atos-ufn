namespace ConsoleAppAula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i, op;

            //for(i = 0; i < 10; i++)
            //{
            //    if(i == 3)
            //    {
            //        continue;
            //    }
            //    if (i == 7)
            //    {
            //        break;
            //    }

            //    Console.WriteLine("i vale" + i);
            //}


            /*
             *  Escreva um algoritmo que leia pelo teclado o valor de uma variavel inteira chamada opcao.
             *  Porem o programa só pode seguir sua execução caso o valor de opcao seja entre 1 e 4
             *  Se o valor digitado não for entre 1 e 4, a variável opcao devera ser lida novamente pelo teclado.
             * **/

            int opcao;
            do
            {
                Console.WriteLine("Informe uma opção entre 1 e 4");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao < 1 || opcao > 4);
        }
    }
}