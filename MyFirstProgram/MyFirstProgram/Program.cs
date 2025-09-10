namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Erik Abrahamsson, NET25
            
            int number = 10;         //User decides what the int "number" should be

            if (number > 10)        //The if-statement checks if the number is greater than 10 and if it is, it writes a specific comment
            {
                Console.WriteLine("Talet är stort!");
            }
            else                    //If the number is or less than 10, it writes a different comment
            {
                Console.WriteLine("Oj, lågt tal!");
            }

            Console.WriteLine("Vad heter du?");

            string name = Console.ReadLine();           //The user writes in what the string "name" should be Kalopps

            Console.WriteLine("Hej " + name + "!");     


            
            
            for (int numList = 0; numList < number + 1; numList++) //The loop lists the number starting from 0 to the number that the user set
            {
                Console.WriteLine(numList);
            }
        }
    }
}
