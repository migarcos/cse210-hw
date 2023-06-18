using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int usrOpt = 0;
        // Create Menu and user input
        List<string> menu = new List<string>
            {
                "Select one of the folloing choices: ",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do?: "
            };
        // While user input is not 5
        Journal newJournal = new Journal();

        while (usrOpt != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            usrOpt = int.Parse(Console.ReadLine());

            if (usrOpt == 1) {
                newJournal.CreateJournalEntry();
            }
            else if (usrOpt == 2) {
                newJournal.DisplayJournalEntries();
            }
            else if (usrOpt == 3) {
                newJournal.LoadFromCSV();
            }
            else if (usrOpt == 4) {
                newJournal.SaveToCSV();
            }
        }
    }
}

//         int usrOpt = 1;

//         while (usrOpt > 0 && usrOpt < 5) 
//         {
//             Console.WriteLine("Select one of the following choices:: ");
//             Console.WriteLine("1. Write ");
//             Console.WriteLine("2. Display");
//             Console.WriteLine("3. Load");
//             Console.WriteLine("4. Save");
//             Console.WriteLine("5. Quit");
//             Console.Write("What would you like to do?: ");
//             string usrInput = Console.ReadLine();
//             usrOpt = int.Parse(usrInput);

//             if (usrOpt == 5) {
//                 usrOpt = 6;
//                 Console.WriteLine("See you the next time! ");
//             }
            
//         }