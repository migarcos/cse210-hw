using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        string usrOption = "";
        string followOpt = "";

        Random randGenerator = new Random();

        List<Scripture> gems = ReadFromFile();

        while (followOpt != "n")
        {

            int gemIndex = randGenerator.Next(0,gems.Count()-1);

            while (usrOption != "quit")
            {
                if (usrOption == "" && gems[gemIndex].AllHidden() == false) // and newScripture.IsCompletelyHidden == false
                {
                    Console.WriteLine(gems[gemIndex].GetDisplayText() +"\n");
                    Console.Write("\n" + "[ENTER] to continue or type 'quit' to finish:  ");
                    usrOption = Console.ReadLine();
                    gems[gemIndex].HideRandomWords();
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine(gems[gemIndex].GetDisplayText() +"\n");
                    usrOption = "quit";
                }
            }
            Console.Write("\nDo you want to try with other scripture? [y]/[n] ");
            followOpt = Console.ReadLine();

            if (followOpt == "y")
            {
                Console.Clear();
                usrOption = "";
            }
        }

        Console.WriteLine("\nSee you the next time! ");
    }

    public static List<Scripture> ReadFromFile()
    {
        List<Scripture> gems = new List<Scripture>();
        string filename = "gems.csv";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int fstVerse = int.Parse(parts[2]);
            int endVerse = 0;

            if (parts[3] == "")
            {
                endVerse = 0;
            }
            else
            {
                endVerse = int.Parse(parts[3]);
            }

            Reference newreference = new Reference(book, chapter, fstVerse, endVerse);
            string scriptureText = parts[4];

            Scripture newScripture = new Scripture(newreference, scriptureText);

            gems.Add(newScripture);
        }

        return gems;
    }
}

        // string scriptureText1 = "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.";
        // Reference newreference1 = new Reference("Ether", 12, 4);
        // string scriptureText2 = "Adam fell that men might be; and men are, that they might have joy.";
        // Reference newreference2 = new Reference("2 Nefi", 2, 25);
        // string scriptureText3 = "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; Abraham, thou art one of them; thou wast chosen before thou wast born.";
        // Reference newreference3 = new Reference("Abraham",3,22,23);
        // Scripture newScripture = new Scripture(newreference1, scriptureText1);
        // Scripture newScripture2 = new Scripture(newreference2, scriptureText2);
        // Scripture newScripture3 = new Scripture(newreference3, scriptureText3);

        // gems.Add(newScripture);
        // gems.Add(newScripture2);
        // gems.Add(newScripture3);

        // foreach (Scripture gem in gems)
        // {
        //     Console.WriteLine(gem.GetDisplayText() +"\n");
        // }        