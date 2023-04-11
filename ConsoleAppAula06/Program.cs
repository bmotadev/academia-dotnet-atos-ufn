namespace ConsoleAppAula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, op;

            for(i = 0; i < 10; i++)
            {
                if(i == 3)
                {
                    continue;
                }
                if (i == 7)
                {
                    break;
                }

                Console.WriteLine("i vale" + i);
            }
        }
    }
}