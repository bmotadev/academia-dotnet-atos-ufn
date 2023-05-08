namespace ConsoleAppAula13Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int idade;
            //string nome;
            //Pessoa p;

            //Console.WriteLine("Digite o nome e idade: ");
            //nome = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());
            //p = new Pessoa(nome, idade);
            //p.nome = "Astolfo";
            //Console.WriteLine("Nome: " + p.nome);



            //Pessoa p;
            //p = new Pessoa();
            //Console.WriteLine("Digite o nome: ");
            //string nome = Console.ReadLine();
            //p.Nome = nome;

            //string nomeRetornado;
            //nomeRetornado =  p.Nome;
            //Console.WriteLine("Nome: " + nomeRetornado);


            Carro c = new Carro();
            c.Marca = "VW";
            c.Ano = 1999;
            c.Modelo = "Gol";
            c.Motor = new Motor();
            c.Motor.Cilindradas = 1500;
            //c.Motor.Ligado = false;
            c.LigarCarro();

            while (true)
            {
                Console.WriteLine("Digite 1 para ligar 2 para desligar: ");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    c.LigarCarro();
                }
                else if(op == 2)
                {
                    c.DesligarCarro();
                }
                else if (op == 0)
                {
                    break;
                }
            }
        }
    }
}