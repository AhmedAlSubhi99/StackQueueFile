using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace StackQueueFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Reverse a String Using Stack
            //Console.WriteLine("Enter a string to reverse:");
            //string orginal = Console.ReadLine();
            //Stack<char> reverse = new Stack<char>();
            //foreach (char c in orginal) // Iterate through each character in the string
            //{
            //    reverse.Push(c); // Push each character onto the stack
            //}
            //Console.Write("Reversed string: ");
            //while (reverse.Count > 0) // While there are characters in the stack
            //{
            //    Console.Write(reverse.Pop()); // Pop each character from the stack and print it
            //}
            //Console.WriteLine();

            //// Evaluate Postfix Expression more than two operands without spliting
            //// 2.Evaluate Postfix Expression Evaluate an expression like "5 3 + 8 *" using a stack and print the result. 

            //Stack<int> stack = new Stack<int>();
            //Console.WriteLine("Enter a postfix expression :");
            //string postfix = Console.ReadLine();
            //string[] store = postfix.Split(' '); // Split the expression into tokens
            //foreach (string token in store) // Iterate through each token
            //{
            //    if (int.TryParse(token, out int number)) // If the token is a number
            //    {
            //        stack.Push(number); // Push it onto the stack
            //    }
            //    else // If the token is an operator
            //    {
            //        int b = stack.Pop(); // Pop the top two numbers from the stack
            //        int a = stack.Pop();
            //        switch (token) // Perform the operation based on the operator
            //        {
            //            case "+":
            //                stack.Push(a + b);
            //                break;
            //            case "-":
            //                stack.Push(a - b);
            //                break;
            //            case "*":
            //                stack.Push(a * b);
            //                break;
            //            case "/":
            //                stack.Push(a / b);
            //                break;
            //        }
            //    }
            //}
            //Console.WriteLine("Result: " + stack.Pop()); // The result is the last number left in the stack

            // 3. Browser History Navigation  

            //Stack<string> history = new Stack<string>();
            //Console.WriteLine("Welcome to the browser history navigation!");
            //do
            //{
            //    Console.WriteLine("Enter a string to navigate to or call back to go back):");
            //    string input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input)) // Check if the input is empty or whitespace
            //    {
            //        Console.WriteLine("Please enter a valid URL.");
            //        continue; // Skip to the next iteration of the loop
            //    }
            //    else if (input.ToLower() == "exit") // Check if the user wants to exit
            //    {
            //        break; // Exit the loop
            //    }
            //    else if (input.ToLower() == "clear") // Check if the user wants to clear the history
            //    {
            //        history.Clear(); // Clear the stack
            //        Console.WriteLine("History cleared.");
            //        continue; // Skip to the next iteration of the loop
            //    }
            //    if (input.ToLower() == "back")
            //    {

            //        if (history.Count > 0) // Check if there are any pages in the history
            //        {
            //            string lastVisited = history.Pop(); // Pop the last visited page
            //            Console.WriteLine("Navigated back to: " + lastVisited);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No history available.");
            //        }
            //    }
            //    else
            //    {
            //        history.Push(input); // Push the new page onto the stack
            //        Console.WriteLine("Navigated to: " + input);
            //    }
            //} while (true); // Keep the program running until manually stopped
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();

            //// 4. XML/HTML Tag Validator 
            //// Validate whether all HTML or XML tags in a file are properly nested and closed using a stack (e.g.,< div >< p ></ p ></ div > is valid, but<div> < p ></ div ></ p > is not).
            //string filePath = "file.html"; // Replace with your file path
            //Stack<string> tagStack = new Stack<string>();
            //try
            //{
            //    string[] lines = File.ReadAllLines(filePath); // Read all lines from the file
            //    foreach (string line in lines) // Iterate through each line
            //    {
            //        string[] tags = line.Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries); // Split the line into tags
            //        foreach (string tag in tags) // Iterate through each tag
            //        {
            //            if (tag.StartsWith("/")) // If it's a closing tag
            //            {
            //                if (tagStack.Count == 0 || tagStack.Pop() != tag.Substring(1)) // Check if the stack is empty or the top tag doesn't match
            //                {
            //                    Console.WriteLine("Invalid HTML/XML: Unmatched closing tag " + tag);
            //                    return; // Exit the program
            //                }
            //            }
            //            else // If it's an opening tag
            //            {
            //                tagStack.Push(tag); // Push it onto the stack
            //            }
            //        }
            //    }
            //    if (tagStack.Count > 0) // If there are still tags in the stack
            //    {
            //        Console.WriteLine("Invalid HTML/XML: Unmatched opening tag " + string.Join(", ", tagStack));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Valid HTML/XML.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error reading file: " + ex.Message);
            //}

            // 1. Rotate Queue Elements by K 

            //Queue<int> queue = new Queue<int>(); // Create a new queue
            //Console.WriteLine("Enter the number of elements in the queue:");
            //int n = Convert.ToInt32(Console.ReadLine()); // Read the number of elements
            //Console.WriteLine("Enter the elements of the queue:");
            //for (int i = 0; i < n; i++) // Read the elements into the queue
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    int element = int.Parse(Console.ReadLine());
            //    queue.Enqueue(element); // Enqueue each element
            //}
            //Console.WriteLine("Enter the number of positions to rotate:");
            //int k = int.Parse(Console.ReadLine()); // Read the number of positions to rotate
            //for (int i = 0; i < k; i++) // Rotate the queue k times
            //{
            //    int temp = queue.Dequeue(); // Dequeue the first element
            //    queue.Enqueue(temp); // Enqueue it at the end
            //}
            //Console.WriteLine("Rotated queue:");
            //foreach (int item in queue) // Print the rotated queue
            //{
            //    Console.Write(item + " "); // Print each element
            //}
            //Console.WriteLine(); // Print a new line

            // 2. Sort a Queue Using Only Queue Operations 
            // Sort the numbers in a queue (without using arrays or lists) only another queue and basic comparisons. 

            //Queue<int> sorted = new Queue<int>();
            //Console.WriteLine("Enter the number of elements in the queue:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the elements of the queue:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    int element = int.Parse(Console.ReadLine());
            //    sorted.Enqueue(element); // Enqueue each element
            //}
            //// Sort queue 
            //sortQueue(ref sorted);
            //Console.WriteLine("Sorted queue:");
            //// Print sorted queue 
            //while (sorted.Count != 0)
            //{
            //    Console.Write(sorted.Peek() + " ");
            //    sorted.Dequeue();
            //}
            //Console.WriteLine();

            // 3.Sliding Window Maximum Using Queue
            // Given an array and a window size k, find the max of each window using a queue. Example: arr = [1, 3, -1, -3, 5, 3, 6, 7], k = 3 → Output: [3, 3, 5, 5, 6, 7]
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine()); // Read the size of the array
            //int[] arr = new int[n];
            //Queue<int> windowSlide = new Queue<int>();
            //for (int i = 0; i < n; i++) // Read the elements into the array
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    windowSlide.Enqueue(arr[i]); // Enqueue each element
            //}
            //Console.WriteLine("Enter the window slide size :");
            //int k = int.Parse(Console.ReadLine()); // Read the window size
            //Queue<int> maxQueue = new Queue<int>(); // Create a new queue for the maximum values
            //for (int i = 0; i <= n - k; i++) // Iterate through the array
            //{
            //    int max = int.MinValue; // Initialize max to minimum value
            //    for (int j = i; j < i + k; j++) // Iterate through the current window
            //    {
            //        if (arr[j] > max) // If the current element is greater than max
            //        {
            //            max = arr[j]; // Update max
            //        }
            //    }
            //    maxQueue.Enqueue(max); // Enqueue the maximum value of the current window
            //}
            //// print the result 
            //Console.WriteLine("Sliding window maximum:");
            //foreach (int i in maxQueue)
            //{
            //    Console.Write(i + " "); // Print each maximum value
            //}
            //Console.WriteLine(); // Print a new line

            // 1. Write Names to File 

            //string filePath = "C:\\Users\\Codeline\\Desktop\\File Task.txt"; // create a file path
            //using (StreamWriter writer = new StreamWriter(filePath)) // create a stream writer to write to the file
            //{
            //    Console.WriteLine("Enter n names:");
            //    int n = int.Parse(Console.ReadLine()); // Read the number of names
            //    for (int i = 0; i < n; i++) // loop to take 5 names from user
            //    {
            //        Console.Write($"Name {i + 1}: ");
            //        string name = Console.ReadLine();
            //        writer.WriteLine(name); // write each name to the file
            //    }
            //}
            //Console.WriteLine("Names written to file successfully.");

            // 2. Search for a Word in a File 

            //string filePath2 = "C:\\Users\\Codeline\\Desktop\\File search task.txt"; // create a file path
            //do
            //{
            //    Console.WriteLine("Enter a word to search:");
            //    string searchWord = Console.ReadLine(); // Read the word to search
            //    using (StreamReader rd = new StreamReader(filePath2))
            //    {
            //        string LineByLine;
            //        int lineNumber = 0; // Initialize line number
            //        bool found = false; // Flag to check if the word is found
            //        while ((LineByLine = rd.ReadLine()) != null) // Read each line from the file
            //        {
            //            lineNumber++; // Increment line number
            //            if (LineByLine.Contains(searchWord)) // Check if the line contains the search word (LineByLine == SearchWord)
            //            {
            //                Console.WriteLine($"Found '{searchWord}' in line {lineNumber}: {LineByLine}"); // Print the line number and content
            //                found = true; // Set found flag to true
            //            }
            //        }
            //        if (!found) // If the word was not found in any line
            //        {
            //            Console.WriteLine($"'{searchWord}' not found in the file.");
            //        }
            //        Console.WriteLine("are you want to search another word? (yes/no)");
            //        string answer = Console.ReadLine(); // Read the user's answer
            //        if (answer.ToLower() == "yes") // If the user wants to search another word
            //        {
            //            Console.WriteLine("Enter a word to search:");
            //            string newSearchWord = Console.ReadLine(); // Read the new word to search
            //            lineNumber = 0; // Reset line number
            //            found = false; // Reset found flag
            //            while ((LineByLine = rd.ReadLine()) != null) // Read each line from the file
            //            {
            //                lineNumber++; // Increment line number
            //                if (LineByLine.Contains(newSearchWord)) // Check if the line contains the new search word
            //                {
            //                    Console.WriteLine($"Found '{newSearchWord}' in line {lineNumber}: {LineByLine}"); // Print the line number and content
            //                    found = true; // Set found flag to true
            //                }
            //            }
            //            if (!found) // If the new word was not found in any line
            //            {
            //                Console.WriteLine($"'{newSearchWord}' not found in the file.");
            //            }
            //        }
            //        else if (answer.ToLower() == "no") // If the user does not want to search another word
            //        {
            //            Console.WriteLine("Goodbye!"); // Print goodbye message
            //            break; // Exit the loop
            //        }
            //        else // If the user enters an invalid answer
            //        {
            //            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            //            break; // Exit the loop
            //        }
            //    }
            //}
            //while (true); // Keep the program running until manually stopped

            // 3. Count Lines, Words, and Characters 
            // Read a file and count how many lines, words, and characters it contains.

            //string filePath3 = "C:\\Users\\Codeline\\Desktop\\File count task.txt"; // create a file path
            //using (StreamReader reader = new StreamReader(filePath3)) // create a stream reader to read the file
            //{
            //    int lineCount = 0; // Initialize line count
            //    int wordCount = 0; // Initialize word count
            //    int charCount = 0; // Initialize character count
            //    string line;
            //    while ((line = reader.ReadLine()) != null) // Read each line from the file
            //    {
            //        lineCount++; // Increment line count
            //        wordCount += line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length; // Count words in the line
            //        charCount += line.Length; // Count characters in the line
            //    }
            //    Console.WriteLine($"Lines: {lineCount}, Words: {wordCount}, Characters: {charCount}"); // Print the counts
            //}
            //Console.WriteLine("Press any key to exit..."); // Print exit message
            //Console.ReadLine(); // Wait for user input before exiting

            //  4. Word Frequency Counter 
            // Read a file and count how many times each word appears.Display the results sorted by frequency. 
            //string filePath4 = "C:\\Users\\Codeline\\Desktop\\File frequency task.txt"; // create a file path
            //string[] words = File.ReadAllText(filePath4).Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); // Read the file and split it into words
            //do
            //{
            //    Console.WriteLine("Enter a word to search:");
            //    string searchWord = Console.ReadLine(); // Read the word to search
            //    int count = 0; // Initialize count
            //    foreach (string word in words) // Iterate through each word
            //    {
            //        if (word == searchWord)// Check if the word matches the search word
            //        {
            //            count++; // Increment count
            //        }
            //    }
            //    if (count > 0) // If the word was found
            //    {
            //        Console.WriteLine($"'{searchWord}' appears {count} times in the file."); // Print the count
            //    }
            //    else // If the word was not found
            //    {
            //        Console.WriteLine($"'{searchWord}' not found in the file.");
            //    }
            //    Console.WriteLine("Are you want to search another word? (yes/no)"); // Ask if the user wants to search another word
            //    string answer = Console.ReadLine(); // Read the user's answer
            //    if (answer.ToLower() == "yes") // If the user wants to search another word
            //    {
            //        Console.WriteLine("Enter a word to search:");
            //        string newSearchWord = Console.ReadLine(); // Read the new word to search
            //        count = 0; // Reset count
            //        foreach (string word in words) // Iterate through each word
            //        {
            //            if (word == newSearchWord) // Check if the word matches the new search word
            //            {
            //                count++; // Increment count
            //            }
            //        }
            //        if (count > 0) // If the new word was found
            //        {
            //            Console.WriteLine($"'{newSearchWord}' appears {count} times in the file."); // Print the count
            //        }
            //        else // If the new word was not found
            //        {
            //            Console.WriteLine($"'{newSearchWord}' not found in the file.");
            //        }
            //    }
            //    else if (answer.ToLower() == "no") // If the user does not want to search another word
            //    {
            //        Console.WriteLine("Goodbye!"); // Print goodbye message
            //        break; // Exit the loop
            //    }
            //    else // If the user enters an invalid answer
            //    {
            //        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            //        break; // Exit the loop
            //    }
            //}
            //while (true); // Keep the program running until manually stopped

            // 5. Filter and Save Specific Lines 
            // From a file with multiple lines, extract only lines that contain a specific keyword(e.g., "error") and save them to errors.txt.

            //string filePath5 = "C:\\Users\\Codeline\\Desktop\\File filter task.txt"; // create a file path
            //using (StreamWriter sw = new StreamWriter(filePath5))
            //{
            //    Console.WriteLine("Enter the number of lines to write to the file:");
            //    int n = int.Parse(Console.ReadLine()); // Read the number of lines
            //    for (int i = 0; i < n; i++) // loop to take n lines from user
            //    {
            //        Console.Write($"Line {i + 1}: ");
            //        string line = Console.ReadLine();
            //        sw.WriteLine(line); // write each line to the file
            //    }
            //}
            //string[] lines = File.ReadAllLines(filePath5); // Read all lines from the file
            //Console.WriteLine("Enter a keyword to filter lines:"); // Prompt user for keyword
            //string keyword = Console.ReadLine(); // Define the keyword to filter lines
            //string filterPath = "C:\\Users\\Codeline\\Desktop\\errors.txt"; // create a file path for the output file
            //using (StreamWriter writer = new StreamWriter(filterPath)) // create a stream writer to write to the output file
            //{
            //    Console.WriteLine($"Filtering lines containing '{keyword}'..."); // Print filtering message
            //    foreach (string line in lines) // Iterate through each line
            //    {
            //        if (line.Contains(keyword)) // Check if the line contains the keyword
            //        {
            //            writer.WriteLine(line); // Write the line to the output file
            //        }
            //    }
            //}
            //Console.WriteLine($"Filtered lines containing '{keyword}' have been saved to {filterPath}."); // Print success message
            //Console.WriteLine("Press any key to exit..."); // Print exit message
            //Console.ReadLine();

            // 5. Split and Merge Files 
        }

        //// Find the index of the minimum element in the queue up to sortedIndex
        //static int min_Index(ref Queue<int> sorted, int sortedIndex)
        //{
        //    // Find the minimum element in the queue up to sortedIndex
        //    int minIndex = -1;
        //    int min = int.MaxValue; // Initialize min to maximum value
        //    int n = sorted.Count; // Get the number of elements in the queue
        //    for (int i = 0; i < n; i++) // loop through queue
        //    {
        //        int curr = sorted.Peek();
        //        sorted.Dequeue(); // This is dequeue() 
        //        // Check if the current element is less than or equal to min and within the sortedIndex
        //        if (curr <= min && i <= sortedIndex)
        //        {
        //            minIndex = i; // Update minIndex
        //            min = curr; // Update min
        //        }
        //        sorted.Enqueue(curr);
        //    }
        //    return minIndex;
        //}

        //// Insert the minimum element at the end of the queue
        //static void insertMinToQueue(ref Queue<int> sorted, int minIndex)
        //{
        //    // Insert the minimum element at the end of the queue
        //    int min = 0;
        //    int n = sorted.Count;
        //    for (int i = 0; i < n; i++) // loop through queue
        //    {
        //        int curr = sorted.Peek(); // Peek() returns the first element
        //        sorted.Dequeue(); // dequeue() removes the first element
        //        if (i != minIndex) // If the current index is not the minimum index
        //        {
        //            sorted.Enqueue(curr);
        //        }
        //        // If the current index is the minimum index, store the value in min
        //        else
        //        {
        //            min = curr;
        //        }
        //    }
        //    sorted.Enqueue(min); // Enqueue the minimum element at the end of the queue
        //}

        //// Sort the queue using the minIndex and insertMinToQueue methods
        //static void sortQueue(ref Queue<int> sorted)
        //{
        //    // Sort the queue using the minIndex and insertMinToQueue methods
        //    for (int i = 1; i <= sorted.Count; i++)
        //    {
        //        int minIndex = min_Index(ref sorted, sorted.Count - i);
        //        insertMinToQueue(ref sorted, minIndex); // insert minimum element to queue
        //    }
        //}

    }
}
    