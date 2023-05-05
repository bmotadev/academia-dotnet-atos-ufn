using System.Threading.Channels;

namespace ConsoleAppAula11Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou no meu primeiro programa OO");
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa: ");
            p.nome = Console.ReadLine(); // aqui estou atribuindo nome

            Console.WriteLine("Digite a idade da pessoa: ");
            p.idade = int.Parse(Console.ReadLine());

            //abaixo estou mostrando dados
            //Console.WriteLine("A pessoa instanciada é: "+p.nome);
            //Console.WriteLine("E tem" +p.idade+"anos");
            p.exibeDados();
        }
    }
}