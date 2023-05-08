namespace ConsoleAppAula13Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
            Pessoa p;

            Console.WriteLine("Digite o nome e idade: ");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            p = new Pessoa(nome, idade);
            p.nome = "Astolfo";
            Console.WriteLine("Nome: " + p.nome);
        }
    }
}