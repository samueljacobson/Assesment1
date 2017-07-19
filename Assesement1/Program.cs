using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesement1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //No. 3 - Complete the method so that the sequence of numbers from startingNumber to (& including) endingNumber is returned.
        public static string PrintNumberSequence(int startingNumber, int endingNumber)
        {
            string sequence = "";
            for(int i = startingNumber; i <= endingNumber; i++)
            {
                sequence += i + " ";
            }
            return sequence;
        }

        //No. 4 - Complete the method so that it returns an array of consecutive numbers from startingNumber to (& including) endingNumber.
        public static int[] ArraySequence(int startingNumber, int endingNumber)
        {
            int length = endingNumber - startingNumber + 1;
            int[] sequence = new int[length];
            int counter = 0;  //need to start at index of 0
            for (int i = startingNumber; i <= endingNumber; i++)
            {
                sequence[counter] = i;
                counter += 1;
            }
            return sequence;
        }

        //No. 6 - Complete the method so that the correct string is returned depending on whether the yes input it true.
        public static string PrintTwice(bool yes)
        {
            string boolString = "";
            if(yes == true)
            {
                boolString = "Yes Yes";
            }
            else
            {
                boolString = "yes";
            }
            return boolString;
        }

        //No. 8 - This method receives an array of strings as parameter. 
        //It should loop through each element, check to see whether that string contains contains a q and increment a counter if so. 
        //The method should return the number of strings that contain a q.
        public static int Counting(string[] words)
        {
            int qCount = 0;
            foreach(string word in words)
            {
                if(word.Contains("q"))
                {
                    qCount++;
                }
            }
            return qCount;
        }
    }
}
