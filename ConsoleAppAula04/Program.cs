namespace ConsoleAppAula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch-case

            int num;
            Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 9:
                    Console.WriteLine("O numero digitado é 9");
                    break;
                case 10:
                    Console.WriteLine("O numero digitado é 10");
                    break;
                default:
                    Console.WriteLine("O numero digitado não é 9 nem 10");
                    break;
            }
        }
    }
}