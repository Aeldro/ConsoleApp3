namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];
            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine("Enter the move N°" + (i + 1) + ".");
                string userText = Console.ReadLine();
                if (userText == "done")
                {
                    break;
                } else
                {
                    moves[i] = userText;
                }
            }

            Console.WriteLine("Enter the number of repetitions.");
            int repeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < repeat; i++)
            {
                foreach (string move in moves)
                {
                    Console.WriteLine(move);
                }
                }

        }
    }
}
