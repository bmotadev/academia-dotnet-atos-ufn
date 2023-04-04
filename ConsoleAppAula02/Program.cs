namespace ConsoleAppAula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num;

            //Console.WriteLine("Digite um número:");
            //num = int.Parse(Console.ReadLine());

            //// bool condicao = num > 0;

            //if(num > 0) // condição
            //{
            //    // Código
            //    Console.WriteLine("O número informado é POSITIVO!");
            //} else if (num < 0)
            //{
            //    Console.WriteLine("NEGATIVO");
            //}

            //else
            //{
            //    Console.WriteLine("O número é zero!");
            //}

            //Console.WriteLine("Informe um número:");
            //int x = int.Parse(Console.ReadLine());

            //if(x % 2 == 0)
            //{
            //    Console.WriteLine("O número é par!");
            //}
            //else
            //{
            //    Console.WriteLine("O número é impar!");
            //}

            // Quero saber se um número é divisivel por 2, 4 e 8;
            //Console.WriteLine("Informe um número:");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("O número é divisivel por 2!");
            //}
            //if ( x % 4 == 0)
            //{
            //    Console.WriteLine("O número é divisivel por 4!");
            //}
            //if( x % 8 == 0)
            //{
            //    Console.WriteLine("O número é divisivel pro 8!");


            //bool b;

            //b = 5 > 2;
            //b = 5 >= 2;
            //b = 5 < 2;
            //b = 5 <= 2;
            //b = 5 == 2;
            //b = 5 != 2;

            //exercicio 01 de if
            //Console.WriteLine("Informe sua idade");
            //int idade = int.Parse(Console.ReadLine());

            //if (idade >= 18)
            //{
            //    Console.WriteLine("Maior de idade");
            //} else
            //{
            //    Console.WriteLine("Menor idade");
            //}

            // calculadora completa, usuario ira digitar um numero. Terá menu da operação com as 4 operações basicas. Depois usuario ira digitar dois valores

            Console.WriteLine("Informe primeiro número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero da operação: \n1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão");
            int operacao = int.Parse(Console.ReadLine());

            double calculoOperacao = 0;

            if(operacao == 1)
            {
                calculoOperacao = numero1 + numero2;
            }
            if(operacao == 2)
            {
                calculoOperacao = numero1 - numero2;
            }
            if(operacao == 3)
            {
                calculoOperacao = numero1 * numero2;
            }
            if(operacao == 4)
            {
                calculoOperacao = numero1 / numero2;
            }

            Console.WriteLine($"O resultado do calculo é: {calculoOperacao:f1}");


        }
    }
}