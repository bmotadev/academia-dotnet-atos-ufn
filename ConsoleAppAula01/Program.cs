namespace ConsoleAppAula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Escreva o seu nome: ");

            ////string nome; // DECLARAÇÃO
            ////// nome = "Bruno"; // ATRIBUIÇÃO

            ////nome = Console.ReadLine();

            ////Console.WriteLine("Seu nome é " + nome); // Concatenação

            //// STRING
            //string s; // texto, todo e qualquer texto
            //char c; // caractere
            //int x; // números inteiros
            //float y; // números reais
            //double d; // números reais
            //bool booleano; // bool, booleano,lógico VERDADEIRO ou FALSO

            //// INTEIROS
            ////int idade = 32;
            ////int a = 5;
            ////int b = 2;

            ////Console.WriteLine("Sua idade é de " + idade + " anos");

            //double a;
            //double b;

            //Console.Write("Digite um valor para A:");
            //a = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um valor para B:");
            //b = double.Parse(Console.ReadLine());

            //double soma;
            //soma = a + b;

            //Console.WriteLine("A soma resulta em: " + soma);

            //double sub = a - b;
            //Console.WriteLine("A subtração resulta em: " + sub);

            //double multi = a * b;
            //double div = a / b;
            //// double div = (double)a / (double)b; // CAST
            //// double div = Convert.ToDouble(a) / Convert.ToDouble(b);
            ////double div = 5f / 2f; // fixo

            //Console.WriteLine("A multiplicação é: " + multi);
            //Console.WriteLine("A divisão é: " + a + " e " + b + " resulta em " + div);

            //Console.WriteLine("Digite a primeira nota");
            //double nota1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a segunda nota");
            //double nota2 = double.Parse(Console.ReadLine());

            //double media = (nota1 + nota2) / 2;

            //Console.WriteLine($"Sua média é {media.ToString("F2")}");

            //Console.WriteLine("Digite a temperatura em Celsius: ");
            //double temperaturaCelsius = double.Parse(Console.ReadLine());

            //double temperaturaFahrenheit = ((temperaturaCelsius * 9) / 5) + 32;

            //Console.WriteLine($"Temperatura em Fahrenheit {temperaturaFahrenheit:f2}");

            // ler dois valores e inverter a ordem dos valores. Valor digitado em A, esteja em B. E valor Digitado em B, esteja em A

            int valorA = int.Parse(Console.ReadLine());
            int valorB = int.Parse(Console.ReadLine());


            Console.WriteLine($"Valor de A: {valorA}");
            Console.WriteLine($"Valor de B: {valorB}");
            int valores = valorA;
            valorA = valorB;
            valorB = valores;
            Console.WriteLine();
            Console.WriteLine("Invertendo os valores");
            Console.WriteLine($"Valor de A: {valorA}");
            Console.WriteLine($"Valor de B: {valorB}");


        }
    }
}