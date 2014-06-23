/*
 _____________________________
 Student Name: Karlessa Howard
 Student ID:  15120270
 ______________________________
 Student Name: Kevin K. Kennedy
 Student ID: 26100087
 
 Course: Advance Application Development (CPTR465)
 Instructor: Mr. Damion R. Mitchell (Assistant Professor, M.Sc.)
 University: Northern Caribbean University
 Department: Computer and Information Sciences
 Programming Assignment #:2
 Assignment Objective: Instrumentation, Profiling and Unit Testing
 Due Date: Sunday, June 1, 2014 
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCPTR465.A2.Sorts
{
    class Sorts{
        
        
        private int[] bubbleArray = new int[10000];
        private int[] insertionArray = new int[10000];
        private int[] shellArray = new int[10000];
       
       

        static void Main(string[] args)
        {
            const int SIZE = 10000;

            int[] numbers = new int[SIZE];

            Random randomNumber = new Random();

            for (int count = 0; count < SIZE; count++)
                numbers[count] = randomNumber.Next(1, 5001);
            
            
            
            Sorts listArray = new Sorts();
            listArray.bubbleSort(numbers, SIZE);
            listArray.insertionSort(numbers, SIZE);
            listArray.shellSort(numbers, SIZE);


            Console.Read();
        }//end main

        /*--------------------------------------------------------------------------------------------------------------------------
       Method Name: bubbleSort
       Description: This method sorts an accepted array in an ascending numercial order by utilising the bubble sort algorithm
       (Arguments) -> return type:  (int[], int) -> void
       Precondition: an integer array and a integer value (size of the array) must be passed when the method is invoked
       Postcondition: A copy of the passed array is then sorted in ascending manner.
       Example (s): int[] arr = {4,3,1,2,0} and int SIZE = 5 are passed to bubbleSort(arr, SIZE); within the method arr[] 
       is copied to arr2 which is then sorted and its content is as follows: {0,1,2,3,4}

      ----------------------------------------------------------------------------------------------------------------------- */


        public void bubbleSort(int[] numbersArray, int SIZE)
        {


            for (int count = 0; count < SIZE; count++)
                bubbleArray[count] = numbersArray[count];

            

            bool unsort = true;
            int temp = 0;
            int walker = SIZE - 1;

            while (unsort != false)
            {

                unsort = false;

                for (int count = 0; count < walker; count++)
                {
                    if (bubbleArray[count] > bubbleArray[count + 1])
                    {

                        temp = bubbleArray[count];
                        bubbleArray[count] = bubbleArray[count + 1];
                        bubbleArray[count + 1] = temp;
                        unsort = true;

                    }//end if

                }//end for

                walker--;

            } //end while
         
        }//end bubbleSort()



        /*--------------------------------------------------------------------------------------------------------------------------
         Method Name: insertionSort
         Description: This method sorts an accepted array in an ascending numercial order by utilising the insertion sort algorithm
         (Arguments) -> return type:  (int[], int) -> void
         Precondition: an integer array and a integer value (size of the array) must be passed when the method is invoked
         Postcondition: A copy of the passed array is then sorted in ascending manner.
         Example (s): int[] arr = {4,3,1,2,0} and int SIZE = 5 are passed to insertionSort(arr, SIZE); within the method arr[] 
         is copied to arr2 which is then sorted and its content is as follows: {0,1,2,3,4}

        ----------------------------------------------------------------------------------------------------------------------- */


        public void insertionSort(int[] numbersArray, int SIZE)
        {
            for (int count = 0; count < SIZE; count++)
               insertionArray[count] = numbersArray[count];

            
            int insertValue;
            int walker;

            for (int count = 1; count < SIZE; ++count)
            {
                insertValue = insertionArray[count];
                walker = count - 1;

                while ((walker > -1) && (insertionArray[walker] > insertValue))
                {

                    insertionArray[walker + 1] = insertionArray[walker];
                    --walker;
                }//end while

                insertionArray[walker + 1] = insertValue;

            }//end for
           

        }//end insertionSort()

        /*--------------------------------------------------------------------------------------------------------------------------
        Method Name: shellSort
        Description: This method sorts an accepted array in an ascending numercial order by utilising the shell sort algorithm
        (Arguments) -> return type:  (int[], int) -> void
        Precondition: an integer array and a integer value (size of the array) must be passed when the method is invoked
        Postcondition: A copy of the passed array is then sorted in ascending manner.
        Example (s): int[] arr = {4,3,1,2,0} and int SIZE = 5 are passed to shellSort(arr, SIZE); within the method arr[] 
        is copied to arr2 which is then sorted and its content is as follows: {0,1,2,3,4}

      ----------------------------------------------------------------------------------------------------------------------- */

        public void shellSort(int[] numbersArray, int SIZE)
        {

            for (int count = 0; count < SIZE; count++)
                shellArray[count] = numbersArray[count];


            int increment = (SIZE - 1) / 2;
            int temp;
            int walker = 0;

            while (increment != 0)
            {

                for (int count = 0; count < SIZE; count++)
                {
                    walker = count;
                    temp = shellArray[count];

                    while ((walker >= increment) && (shellArray[walker - increment] > temp))
                    {

                        shellArray[walker] = shellArray[walker - increment];
                        walker -= increment;

                    }//end while

                    shellArray[walker] = temp;

                }//end for

                increment /= 2;

            }//end while

    
        }//end shellSort()

    }// end class Sorts
}//end namespace
