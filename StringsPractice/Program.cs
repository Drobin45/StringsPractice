using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string practice!

            //string firstName = "Daniel";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(lengthOfName);

            //string myFaveQuote = "\"It's a yam sham\"-Buffy Summer";
            //Console.WriteLine(myFaveQuote);


            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine \n";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";

            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);


            // Simple if else statement. Also, first use of .Equals instead of "=="

            //Console.WriteLine("User One please write something!");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User Two please write something!");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User two is a copycat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}

            // use of concatonation 

            //string startOfSentence = "My best friend's is ";
            //string endOfSentence = "30 Giant Men.";

            //string fullSentence = (startOfSentence + endOfSentence);
            //Console.WriteLine(fullSentence;

            //Console.WriteLine(startOfSentence + endOfSentence);

            //Console.WriteLine("My friend" + endOfSentence + "has a cute kid.");
            //Console.WriteLine("The first part of my sentence was {0}, the second was {1}", startOfSentence, endOfSentence);

            //Console.WriteLine("This is a tab \t \nThis is a backspace \\ \nAnd this is a bell sound \a");



            // Write an app that lets the user write in their first and last names. 
            // Have the program count the length of each name, then tell the user which name is longer, or if they are both equal to one another

            //Console.WriteLine("Write your first name");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Write your last name");
            //string lastName = Console.ReadLine();

            //int lengthOfFirst = firstName.Length;
            //int lengthOfLast = lastName.Length;

            //if (lengthOfFirst > lengthOfLast)
            //{
            //    Console.WriteLine("First is longer!");
            //}
            //else if (lengthOfLast == lengthOfFirst)
            //{
            //    Console.WriteLine("Samsis!");
            //}
            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}

            //string nameOne = "Daniel";
            //string nameTwo = "Danny";

            //if (nameOne.Equals(nameTwo))
            //{
            //    Console.WriteLine("The names are the same");
            //}
            //else if (nameOne != nameTwo)
            //{
            //    Console.WriteLine("The names are different");
            //}

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();

            //Console.WriteLine(firstName + lastName);

            Console.WriteLine("Name the correct animal! Hint: It's the opposite of a dog.");
            string answer = Console.ReadLine();

            if (answer == "cat")
            {
                Console.WriteLine("You answered correcly!");
            }
            else
            {
                Console.WriteLine("You answered incorrectly!");
            }

            //ToLower() & ToUpper






        }
    }
}
