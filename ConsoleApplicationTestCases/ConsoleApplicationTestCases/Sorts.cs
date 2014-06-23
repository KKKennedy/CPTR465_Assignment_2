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
        
     
       

        static void Main(string[] args)
        {
            /*const int SIZE = 10000;

            int[] numbers = new int[SIZE];

            Random randomNumber = new Random();

            for (int count = 0; count < SIZE; count++)
                numbers[count] = randomNumber.Next(1, 5001); */
     
        }//end main


        /*--------------------------------------------------------------------------------------------------------------------------
           Method Name: bubbleSort
           Description: This method sorts an accepted array in an numercial ascending  order by utilising the bubble sort algorithm
           (Arguments) -> return type:  (int[], int) -> void
           Precondition: An integer array and a integer value (size of the array) must be passed when the method is invoked
           Postcondition: The accepted array is then sorted in an ascending manner.
           Example (s): int[] arr = {4,3,1,2,0} and int SIZE = 5 are passed to bubbleSort(arr, SIZE); within the method arr[] 
           is sorted and its content is now as follows: {0,1,2,3,4}

          ----------------------------------------------------------------------------------------------------------------------- */


        public void bubbleSort(int[] numbersArray, int SIZE)
        {


            bool unsort = true;
            int temp = 0;
            int walker = SIZE - 1;

            while (unsort != false)
            {

                unsort = false;

                for (int count = 0; count < walker; count++)
                {
                    if (numbersArray[count] > numbersArray[count + 1])
                    {

                        temp = numbersArray[count];
                        numbersArray[count] = numbersArray[count + 1];
                        numbersArray[count + 1] = temp;
                        unsort = true;

                    }//end if

                }//end for

                walker--;

            } //end while
         
        }//end bubbleSort()



        /*--------------------------------------------------------------------------------------------------------------------------
         Method Name: insertionSort
         Description: This method sorts an accepted array in an numercial ascending  order by utilising the insertion sort algorithm
         (Arguments) -> return type:  (int[], int) -> void
         Precondition: An integer array and a integer value (size of the array) must be passed when the method is invoked
         Postcondition: The accepted array is then sorted in an ascending manner.
         Example: int[] arr = {4,3,1,2,0} and int SIZE = 5 are passed to insertionSort(arr, SIZE); within the method arr[] 
         is sorted and its content is now as follows: {0,1,2,3,4}

        ----------------------------------------------------------------------------------------------------------------------- */


        public void insertionSort(int[] numbersArray, int SIZE)
        {
       

            
            int insertValue;
            int walker;

            for (int count = 1; count < SIZE; ++count)
            {
                insertValue = numbersArray[count];
                walker = count - 1;

                while ((walker > -1) && (numbersArray[walker] > insertValue))
                {

                    numbersArray[walker + 1] = numbersArray[walker];
                    --walker;
                }//end while

                numbersArray[walker + 1] = insertValue;

            }//end for
           

        }//end insertionSort()




        /*--------------------------------------------------------------------------------------------------------------------------
         Method Name: shellSort
         Description: This method sorts an accepted array in an numercial ascending  order by utilising the shell sort algorithm
         Precondition: An integer array and a integer value (size of the array) must be passed when the method is invoked
         Postcondition: The accepted array is then sorted in an ascending manner.
         Example: int[] arr = {4,3,1,2,0} and int SIZE = 5 are passed to shellSort(arr, SIZE); within the method arr[] 
         is sorted and its content is now as follows: {0,1,2,3,4}

        ----------------------------------------------------------------------------------------------------------------------- */


        public void shellSort(int[] numbersArray, int SIZE)
        {
                      

            int increment = SIZE  / 2;
            int temp;
            int walker = 0;

            while (increment != 0)
            {

                for (int count = 0; count < SIZE; count++)
                {
                    walker = count;
                    temp = numbersArray[count];

                    while ((walker >= increment) && (numbersArray[walker - increment] > temp))
                    {

                        numbersArray[walker] = numbersArray[walker - increment];
                        walker -= increment;

                    }//end while

                    numbersArray[walker] = temp;

                }//end for

                increment /= 2;

            }//end while

    
        }//end shellSort()

    }// end class Sorts
}//end namespace
