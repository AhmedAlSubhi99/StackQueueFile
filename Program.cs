using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Linq;
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
            // Given a queue and a number K, rotate the elements of the queue K times to the left.

            Queue<int> queue = new Queue<int>(); // Create a new queue
            Console.WriteLine("Enter the number of elements in the queue:");
            int n = Convert.ToInt32(Console.ReadLine()); // Read the number of elements
            Console.WriteLine("Enter the elements of the queue:");
            for (int i = 0; i < n; i++) // Read the elements into the queue
            {
                Console.Write($"Element {i + 1}: ");
                int element = int.Parse(Console.ReadLine());
                queue.Enqueue(element); // Enqueue each element
            }
            Console.WriteLine("Enter the number of positions to rotate:");
            int k = int.Parse(Console.ReadLine()); // Read the number of positions to rotate
            for (int i = 0; i < k; i++) // Rotate the queue k times
            {
                int temp = queue.Dequeue(); // Dequeue the first element
                queue.Enqueue(temp); // Enqueue it at the end
            }
            Console.WriteLine("Rotated queue:");
            foreach (int item in queue) // Print the rotated queue
            {
                Console.Write(item + " "); // Print each element
            }
            Console.WriteLine(); // Print a new line
        }
    }
}
    