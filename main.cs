
using System; 
using System.Collections.Generic; 
using System.Linq; 
class Program 
{ 
    static void Main() 
    { 
        Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>(); 

        while (true) 
        { 
          displayoption ();
            Console.WriteLine("\nEnter the letter of your choice:"); 
            char choice = Console.ReadKey().KeyChar; 
            Console.WriteLine(); 
            switch (choice) 
            { 
                case 'a': 
                    PopulateDictionary(myDictionary); 
                    break; 
                case 'b': 
                    DisplayDictionaryContents(myDictionary); 
                    break; 
                case 'c': 
                    RemoveKey(myDictionary); 
                    break; 
                case 'd': 
                    AddNewKeyValue(myDictionary); 
                    break; 
                case 'e': 
                    AddValueToExistingKey(myDictionary); 
                    break; 
                case 'f': 
                    SortKeys(myDictionary); 
                    break; 
                case 'x': 
                    return; 
                default: 
                    Console.WriteLine("Invalid option, please try again."); 
                    break; 
            } 
        } 
    } 

static void displayoption (){
  Console.WriteLine("=================================="); 
  Console.WriteLine("a. Populate the Dictionary"); 
  Console.WriteLine("b. Display Dictionary Contents"); 
  Console.WriteLine("c. Remove a Key"); 
  Console.WriteLine("d. Add a New Key and Value"); 
  Console.WriteLine("e. Add a Value to an Existing Key"); 
  Console.WriteLine("f. Sort the Keys"); 
  Console.WriteLine("x. Exit"); 
    Console.WriteLine("=================================="); 
}
    //a. Function Populate the Dictionary
    static void PopulateDictionary(Dictionary<string, List<string>> dictionary) 
    { 
        Console.Write("Enter key to add: "); 
        string key = Console.ReadLine(); 
        Console.Write("Enter value to add: "); 
        string value = Console.ReadLine(); 
        if (!dictionary.ContainsKey(key)) 
        { 
            dictionary[key] = new List<string> { value }; 
            Console.WriteLine($"Key '{key}' added with initial value '{value}'.\n"); 
        } 
        else 
        { 
            Console.WriteLine("Key already exists. Use option 'e' to add values to an existing key.\n"); 
        } 
    } 
    // Display Dictionary Contents

    static void DisplayDictionaryContents(Dictionary<string, List<string>> dictionary) 
    { 
        Console.WriteLine("\nDictionary Contents:"); 
        foreach (var kvp in dictionary) 
        { 
            Console.WriteLine($"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}"); 
        } 
        Console.WriteLine();
    } 
    // Fungsi untuk menghapus kunci dari dictionary
    static void RemoveKey(Dictionary<string, List<string>> dictionary) 
    { 
        Console.Write("Enter key to remove: "); 
        string key = Console.ReadLine(); 

        if (dictionary.Remove(key)) 
        { 
            Console.WriteLine($"Key '{key}' removed.\n"); 
        } 
        else 
        { 
            Console.WriteLine("Key not found.\n"); 
        } 
    } 

    // Further methods for adding, updating, and sorting keys and values can be added here.
    static void AddNewKeyValue(Dictionary<string, List<string>> dictionary) 
    { 
        Console.Write("Enter new key: "); 
        string key = Console.ReadLine(); 
        Console.Write("Enter value: "); 
        string value = Console.ReadLine(); 

        if (!dictionary.ContainsKey(key)) 
        { 
            dictionary[key] = new List<string> { value }; 
            Console.WriteLine($"New key '{key}' added with value '{value}'.\n"); 
        } 
        else 
        { 
            Console.WriteLine("Key already exists. Use option 'e' to add values to an existing key.\n"); 
        } 
    } 
    // Function to add a value to an existing key
    static void AddValueToExistingKey(Dictionary<string, List<string>> dictionary) 
    { 
        Console.Write("Enter key to add value to: "); 
        string key = Console.ReadLine(); 
      
        if (dictionary.ContainsKey(key)) 
        { 
            Console.Write("Enter value to add: "); 
            string value = Console.ReadLine(); 
            dictionary[key].Add(value); 
            Console.WriteLine($"Value '{value}' added to key '{key}'.\n"); 
        } 
        else 
        { 
            Console.WriteLine("Key not found.\n"); 
        } 
    } 


    // Function to sort the keys in the dictionary
    static void SortKeys(Dictionary<string, List<string>> dictionary) 
    { 
        Console.WriteLine("\nSorted Dictionary by Keys:"); 
        foreach (var kvp in dictionary.OrderBy(k => k.Key)) 
        { 
            Console.WriteLine($"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}"); 
        } 
        Console.WriteLine();
    } 

} 