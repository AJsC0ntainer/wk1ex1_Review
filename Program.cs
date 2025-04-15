using System.Collections;

namespace wk1ex1Review
{
    public class Program
    {
        static void Main(string[] args)
        {

            Message myMessage = new Message();

            myMessage.DisplayMessage("\"Welcome to ITSE102\"");

            Console.Read();
        }
    }
    class Message
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}