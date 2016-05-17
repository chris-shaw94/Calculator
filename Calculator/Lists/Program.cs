using Lists.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this exercise we're going to learn about lists  - a common ways of maintaining a running list of things
            // I'll also show you how to iterate through each one


            // This how you create a new list that is supposed to contain a load on ints
            // The type you put inside the <> tells the list what type of data it can contain
            List<int> listOfNumbers = new List<int>();

            // This is how you add things to a list, there are no rules really as long as you stick to the type you are adding
            // Each item is added to the bottom of the list
            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(3);
            listOfNumbers.Add(178367451);
            listOfNumbers.Add(1);

            // This removes the first occurance an item from the list if it matches
            // so the int 3 is going to be removed
            listOfNumbers.Remove(3);

            // this removes the entry at the index you specify
            // you should note that lists are zero based, this means that when they calculate the index it starts at 0
            // so listOfNumbers.RemoveAt(1); will infact remove the second entry in the list
            listOfNumbers.RemoveAt(1);

            // this gets rid of everything in the list
            listOfNumbers.Clear();



            // cool, so we're going to create a list of numbers, iterate through them and output them to the screen
            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(3);
            listOfNumbers.Add(4);
            listOfNumbers.Add(5);
            listOfNumbers.Add(6);
            listOfNumbers.Add(7);
            listOfNumbers.Add(8);
            listOfNumbers.Add(9);
            listOfNumbers.Add(10);

            // there are a few loops we can use, traditionally we used to use the for method
            // this is supported in every programming language so its a good one to understand
            // a for loop has 3 parts, the start value, the end value and how we increment it

            
            // OK theres loads going on here
            for (int index=0; index<listOfNumbers.Count; index++)
            {
                // first, the start value, we are greating a new int called index and setting it to 0, this is the int index=0; bit
                // this is where the index will start from, you can call index anything you like

                // the ; seperates each part of the loop

                // secondly we are telling the loop that we want the index to be less than the amount of numbers in our list

                // thirdly we are telling the loop to increment the loop after every loop



                // this is writing out the unmber to the screen
                // the square brackets are looking for the entry in the list at the index
                Console.WriteLine(listOfNumbers[index]);
            }


            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();



            // heres a much simpler example that spits out all numbers between 0 and 100
            for (int i=0; i<=100; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            // so the for loop is alright to understand but C# has made it easier to iterate through a list
            foreach(int listItem in listOfNumbers)
            {
                Console.WriteLine(listItem);
            }
            
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            // lists can contain any kind of data you want from simple data types like ints and strings to really complicated data like for instance
            // a list of enemy units complete with hitpoints, ai, strength etc...
            // in this example i created a new list of simple objects that creates a random name and displays it
            List<SimpleObject> Objects = new List<SimpleObject>();

            Objects.Add(new SimpleObject());
            Objects.Add(new SimpleObject());
            Objects.Add(new SimpleObject());
            Objects.Add(new SimpleObject());
            Objects.Add(new SimpleObject());
            Objects.Add(new SimpleObject());
            Objects.Add(new SimpleObject());

            foreach(SimpleObject obj in Objects)
            {
                Console.WriteLine(obj.Name);
            }


            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}
