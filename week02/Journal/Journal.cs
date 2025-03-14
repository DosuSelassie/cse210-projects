using System;
using System.IO;

public class Journal{
    public List<Entry> _entries = new List<Entry> ();

    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        if (_entries.Count == 0){
            Console.WriteLine("\nNo entries found!\n");
        }
        else {
        foreach (Entry e in _entries){
                    e.Display();   
        }
        }
        
    }
    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            foreach(Entry e in _entries){
            outputFile.WriteLine($"Date: {e._date} - Prompt: {e._promptText} - Response: {e._entryText},");
            }
            
        }

    }
    public void LoadFromFile(string file){
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found!");
        }

        string[] lines = System.IO.File.ReadAllLines(file);
        
            foreach (string line in lines){
            string[] parts = line.Split(",");
            Console.WriteLine(line);
            Console.WriteLine();
            
        }
    }

}