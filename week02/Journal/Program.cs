using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        List<string> _options = new List<string>{
            "Write","View","Load","Save","Exit"
        };
        int _choice = 0;Journal userEntry = new Journal();

        do //Loop for menu options
        {
            Console.WriteLine("Please select one of the following options: ");
            for (int i = 0;i < _options.Count;i++){
                Console.WriteLine($"{i+1}. {_options[i]}");
            }
            Console.WriteLine("What would you like to do?");
            Console.Write("> "); _choice = int.Parse(Console.ReadLine());
            if (_choice == 1){
                Entry newEntry = new Entry();
                newEntry._promptText = new PromptGenerator().GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write("> ");newEntry._entryText = Console.ReadLine();
                userEntry.AddEntry(newEntry);
            }
            else if (_choice == 2){
                userEntry.DisplayAll();
            }
            else if (_choice == 3){
                Console.WriteLine("What is the filename?(filename.txt)");
                Console.Write("> ");string file = Console.ReadLine();
                userEntry.LoadFromFile(file);
            }
            else if (_choice == 4)
            {
                Console.WriteLine("What is the filename?(filename.txt)");
                Console.Write("> "); string file = Console.ReadLine();
                userEntry.SaveToFile(file);
            }

        } while (_choice != 5);
    }
}