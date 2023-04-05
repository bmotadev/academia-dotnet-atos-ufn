using ConsoleAppAula03.ExerciciosEmAula;

namespace ConsoleAppAula03
{
    internal class Program
    {
        // Encadeamento de condições
        // if(condicao 1) {
        //    if(condição 2) {
        //      desvio condicional composto
        //      if aninhado -> mais chamado*?
        //
        //       operadores lógicos:
        //       operador E (AND) exige que ambas as sentenças sejam verdadeiras para retornar true
        //       operador OU (OR) se apenas uma das sentenças sejam verdadeiras, retorna true
        //       operador NÃO (NOT)
        //       if(n!=7)
        //       
        //       Operador E = &&
        //       Operador OU = ||
        //       Operador NÃO = !
        static void Main(string[] args)
        {
            //int n, secreto;
            //secreto = 7;
            //Console.WriteLine("Digite um número:");
            //n = int.Parse(Console.ReadLine());

            //if ( n == secreto )
            //{
            //    Console.WriteLine("Acertou o numero!");
            //} else
            //{
            //    Console.Write("Errou!");
            //    if ( n > secreto )
            //    {
            //        Console.WriteLine($"O número secreto é menor que {n}");
            //    } else
            //    {
            //        Console.WriteLine($"O número secreto é maior que {n}");
            //    }
            //}

            //int a = 4, b = 5, c = 9, d = 1;

            //if((a != 0) && b == 5)
            //{
            //    Console.WriteLine("Entrei como verdadeiro!");
            //}

            //if (a> 3 || d == 1)
            //{
            //    Console.WriteLine("Entrei como verdadeiro na 2!");
            //}

            //if ((a > 3 || d < 3) && (b < c && b > c))
            //{
            //    Console.WriteLine("Entrei como verdadeiro na 3!");
            //}

            //if((b != 0 || a > 4) || (d < 3 && c >= 8))
            //{
            //    Console.WriteLine("Entrei como verdadeiro na 4");
            //}

            //if(((a > d || a < d) || a == 4) || (!(b == 5 && b > c)))
            //{
            //    Console.WriteLine("Entrei como verdadeiro na 5");
            //}

            //------------------------------------------------------
            ExerciciosEmAulaClass exerciciosEmAula = new ExerciciosEmAulaClass();

            exerciciosEmAula.Exercicio01();

            //------------------------------------------------------
            exerciciosEmAula.Exercicio02();

            //------------------------------------------------------
            exerciciosEmAula.Exercicio03();

            //------------------------------------------------------
            exerciciosEmAula.Exercicio04();

        }
    }
}