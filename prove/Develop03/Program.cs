using System;

class Program
{
    static void Main(string[] args)
    {
        string usrOption = "";
        
        string scriptureText = "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.";
        Reference newreference = new Reference("Ether", 12, 4);

        Scripture newScripture = new Scripture(newreference, scriptureText);


        while (usrOption != "quit")
        {
            
            if (usrOption == "" && newScripture.AllHidden() == false) // and newScripture.IsCompletelyHidden == false
            {
                Console.WriteLine(newScripture.GetDisplayText() +"\n");
                Console.Write("\n" + "[ENTER] to continue or type 'quit' to finish:  ");
                usrOption = Console.ReadLine();
                newScripture.HideRandomWords();
                Console.Clear();
            }
            else 
            {
                Console.WriteLine(newScripture.GetDisplayText() +"\n");
                usrOption = "quit";
                Console.WriteLine("\nSee you the next time! ");
            }
        }
    }
}