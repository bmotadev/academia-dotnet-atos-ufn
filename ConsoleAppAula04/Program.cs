namespace ConsoleAppAula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch-case
            // Exemplo 1:
            //int num;
            //Console.WriteLine("Digite um numero:");
            //num = int.Parse(Console.ReadLine());

            //switch(num)
            //{
            //    case 9:
            //        Console.WriteLine("O numero digitado é 9");
            //        break;
            //    case 10:
            //        Console.WriteLine("O numero digitado é 10");
            //        break;
            //    default:
            //        Console.WriteLine("O numero digitado não é 9 nem 10");
            //        break;
            //}


            // Exemplo 2 - Calculadora
            Console.WriteLine("Digite a operação: \n+ - Soma \n- - Subtração \nx - Multiplicação \n/ - Divisão");
            char operacao = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numeroDois = int.Parse(Console.ReadLine());

            double calculoDaOperacao = 0;

            switch (operacao)
            {
                case '+':
                    calculoDaOperacao = numeroUm + numeroDois;
                    break;
                case '-':
                    calculoDaOperacao = numeroUm - numeroDois;
                    break;
                case 'x':
                    calculoDaOperacao = numeroUm * numeroDois;
                    break;
                case '/':
                    calculoDaOperacao = numeroUm / numeroDois;
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;


            }
               Console.WriteLine($"O resultado da operação foi: {calculoDaOperacao}");

            // Exemplo 4 - Operador Ternario
            /*
             *  ( condição ) ? valor_se_verdadeiro : valor_se_falso
             * **/

            //int x = 0, i;
            //i = int.Parse(Console.ReadLine());
            //x = (i % 2 == 0) ? x = 1 : x = 2;
            //Console.WriteLine($"Resultado = {x}");

            // Exemplo 6
            int i;
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i + " é " + (i % 2 == 0 ? "par" : "impar"));
        }
    }
}