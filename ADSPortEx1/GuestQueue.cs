using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1
{
    //Queue implementation for Assessed Exercise 1

    //Hints : 
    //Use lecture materials from Week 2A
    // and lab sheet 'Lab 2 (second part): Stacks and Queues' to aid with implementation...

    //Do not delete the current function definitions, just replace the exceptions with the required functionality...

    //Don't forget to properly commit and document your work! 
    // Commit fairly frequently with proper descriptions, i.e. commit after implementing the enqueue function...
    
    //Lastly, don't forget about implementing your UI in 'Form1.cs' too!
    // See lab material from week 1 to aid with this...

    // - Adam.M 

    class GuestQueue
    {
        private List<Guest> themeParkGuests;
        // Functions for EX.1A
        public GuestQueue()
        {
            themeParkGuests = new List<Guest>();
        }

        public GuestQueue(int size)
        {
            themeParkGuests = new List<Guest>(size);
        }

        public void Enqueue(Guest value)
        {
            themeParkGuests.Add(value);
            Console.WriteLine($"{value.Name} (£{value.Funds}) has Entered the Queue.");
        }

        public Guest Dequeue()
        {
            if(themeParkGuests.Count == 0) {
                Console.WriteLine("There are no guests in the Queue.");
                return null;
            }
            themeParkGuests.RemoveAt(0);
            Guest leadGuest = themeParkGuests.First();

            Console.WriteLine($"{leadGuest.Name} ({leadGuest.Funds}) has Left the Queue.");
            return leadGuest;
        }

        public Guest Peek()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return themeParkGuests.Count();
        }

        public bool IsEmpty()
        {
            if(themeParkGuests.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //lol
        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        // Functions for EX.1B

        public void Reverse(int k)
        {
            throw new NotImplementedException();
        }

        public Guest GetMostFunds()
        {
            throw new NotImplementedException();
        }

        // See tasksheet for details for EX.1C



        //Free space, use as necessary to address task requirements... 







    } // End of class
}
