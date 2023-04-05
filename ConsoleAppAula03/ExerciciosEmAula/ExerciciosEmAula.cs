using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula03.ExerciciosEmAula
{
    internal class ExerciciosEmAulaClass
    {
        public void Exercicio01() 
        {
            // Exercicio
            /*
             * Considere que será concedio um bônus aos trabalhadores de uma empresa, conforme o salario atual do vendedor, descrito abaixo.
             * Desenvolva o algoritmo para ler o salário e calcular o valor em reais do aumento. Exibir na tela, o salário atual, o aumento (% e R$) e o novo salario
             * Até 900 => 5%
             * De 900 a 1400 => 8%
             * Acima de 1400 = 10%
             * **/

            Console.WriteLine("Informe o salario");
            double salario = double.Parse(Console.ReadLine());

            double bonusSalario = 0, valorDoAumento = 0;
            int porcentagem = 0;
            if (salario <= 900.00)
            {
                porcentagem = 5;
                valorDoAumento = salario * 0.05;
                bonusSalario = salario + valorDoAumento;
            }
            if (salario > 900.00 && salario < 1400.00)
            {
                porcentagem = 8;
                valorDoAumento = salario * 0.08;
                bonusSalario = salario + valorDoAumento;
            }
            if (salario >= 1400.00)
            {
                porcentagem = 10;
                valorDoAumento = salario * 0.10;
                bonusSalario = salario + valorDoAumento;
            }

            Console.WriteLine($"\nSalário atual: R${salario:f2}.\nAumento de {porcentagem}% no valor de: R${valorDoAumento:f2}.\nNovo salário: R${bonusSalario:f2}");
        }

        public void Exercicio02()
        {
            /*
             * Dados três números, verificar se eles podem representar as medidas dos lados de um triângulo e, classificar o triângulo em equilátero, isósceles ou escaleno.
             * Para que três números representem os lados de um triângulo é necessário que cada um deles seja menor que a soma dos outros dois.
             * Um triângulo é equilátero se tem os três lados iguais,  isósceles se tem apenas dois lados iguais e escaleno se tem todos os lados distintos.
             * **/

            Console.WriteLine("Digite o primeiro número");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numeroDois = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int numeroTres = int.Parse(Console.ReadLine());

            if ((numeroUm < (numeroDois + numeroTres)) && (numeroDois < (numeroUm + numeroTres)) && (numeroTres < (numeroUm + numeroDois)))
            {
                if (numeroUm == numeroDois && numeroUm == numeroTres && numeroDois == numeroTres)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (numeroUm == numeroDois || numeroUm == numeroTres || numeroDois == numeroTres)
                {
                    Console.WriteLine("Triangulo isósceles");
                }
                else if (numeroUm != numeroDois && numeroUm != numeroTres && numeroTres != numeroDois)
                {
                    Console.WriteLine("Triangulo escaleno");
                }

            }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }
        }

        public void Exercicio03()
        {
            /*
             * Exercicio
             * 
             * Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
             * Área do triangulo = (base * altura) / 2; 
             * Teste se a base ou a altura digitada não foi igual a zero.
             * **/
            Console.WriteLine("Digite o valor da base:");
            double numeroBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            double numeroAltura = double.Parse(Console.ReadLine());

            if (numeroAltura != 0 && numeroBase != 0)
            {
                double areaDoTriangulo = (numeroBase * numeroAltura) / 2;
                Console.WriteLine($"A área do triangulo é de: {areaDoTriangulo:f2}");
            }
            else
            {
                Console.WriteLine("Digite valores diferente de 0");
            }
        }

        public void Exercicio04()
        {
            /*
             * Exercicio
             * 
             * Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média.
             * **/

            Console.WriteLine("Informe o primeiro número:");
            double numeroUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double numeroDois = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número:");
            double numeroTres = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quarto número:");
            double numeroQuatro = double.Parse(Console.ReadLine());

            double media = (numeroUm + numeroDois + numeroTres + numeroQuatro) / 4;

            Console.WriteLine($"Media é:{media:f1}");

            if (numeroUm > media)
            {
                Console.WriteLine($"{numeroUm:f1} superior a media");
            }
            if (numeroDois > media)
            {
                Console.WriteLine($"{numeroDois:f1} superior a media");
            }
            if (numeroTres > media)
            {
                Console.WriteLine($"{numeroTres:f1} superior a media");
            }
            if (numeroQuatro > media)
            {
                Console.WriteLine($"{numeroQuatro:f1} superior a media");
            }
        }
    }
}
