using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your entry: ");
                string entryText = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                Entry newEntry = new Entry(date, prompt, entryText);
                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {

                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {

                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully!");
            }
            else if (choice == "4")
            {

                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully!");
            }
            else if (choice == "5")
            {

                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
