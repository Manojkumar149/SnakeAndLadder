namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder problem");
            GamePlay gamePlay = new GamePlay();
            gamePlay.Play();
        }
    }
}