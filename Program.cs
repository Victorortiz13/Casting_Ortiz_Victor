namespace Casting_Ortiz_Victor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a whole number plz:");                              // prints out a message in the application
            int ranNum = Convert.ToInt32 (Console.ReadLine());                          // 
            Console.WriteLine("You chose:" + ranNum);                                   // prints out a message and the whole number chosen
            Console.WriteLine("Do you like video games? (Enter true or false plz):");   // prints out a message in the application
            bool wGames = Convert.ToBoolean (Console.ReadLine());                       //
            Console.WriteLine("It is " + wGames + " that i like video games!");         // prints out a message 
            
        }
    }
}
