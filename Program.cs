namespace Casting_Ortiz_Victor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a whole number plz:");                              // prints a variable to console
            int ranNum = Convert.ToInt32 (Console.ReadLine());                          // converts Console.ReadLine to int
            Console.WriteLine("You chose:" + ranNum);                                   // prints a variable and ranNum to consile
            Console.WriteLine("Do you like video games? (Enter true or false plz):");   // prints a variable to console
            bool wGames = Convert.ToBoolean (Console.ReadLine());                       // converts Console.ReadLine to bool
            Console.WriteLine("It is " + wGames + " that i like video games!");         // prints a variable and wGames to console
            
        }
    }
}
