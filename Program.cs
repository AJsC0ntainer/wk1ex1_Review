using System.Collections;
namespace wk1ex1Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creates an object myMessage of class message
            Message myMessage = new Message();
            //Call the DisplayMessage methos inside the class Message
            myMessage.DisplayMessage("\"Welcome to ITSE102\"");
            //Stops the program to allow the user to read the output
            Console.Read();
        }
    }
    //Class message
    class Message
    {
        //Method to display the message
        public void DisplayMessage(string message)
        {
            //displays the message string passed from the main method
            Console.WriteLine(message);
        }
    }

}