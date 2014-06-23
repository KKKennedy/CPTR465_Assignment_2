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

using ConsoleApplicationCPTR465.A2.Sorts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectSorts
{
    
    
    /// <summary>
    ///This is a test class for SortsTest and is intended
    ///to contain all SortsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SortsTest
    {
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


/*____________________________________________________________________________________________________________________________________________________________________________________________________*/

       // This function returns a populated array of a size and random values in range specified by the functions arguments*/
        public int[] populateArray(int SIZE, int minValue, int maxValue)
        {

            int[] ranArray = new int[SIZE];
            Random randomSeeder = new Random();

            for (int count = 0; count < SIZE; count++)
            {

                ranArray[count] = randomSeeder.Next(minValue, maxValue);


            }

            return ranArray;
        }//end populateArray();

 /*____________________________________________________________________________________________________________________________________________________________________________________________________*/


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
     

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

   /*____________________________________________________________________________________________________________________________________________________________________________________________________*/
        
        
        /// <summary>
        //Unit Test I for Bubble Sort that tests if a empty  array (list) will be handled properly i.e. no operation should be performed
        ///</summary>


        [TestMethod()]
        public void bubbleSortTest1()
        {
            int SIZE = 10;
            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)


            int[] actual= new int[SIZE]; //actual declared as an empty array

            int[] expected = new int[SIZE]; //expected declared as empty array


            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            
            target.bubbleSort(actual, SIZE); //the actual array is now passed (by reference i.e. by default) to the bubbleSort method


            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            CollectionAssert.AreEqual(expected, actual);//compares the content of the expected and actual collection


        }
 /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/
        
        /// <summary>
        //Unit Test II for Bubble Sort that tests if a list of all negative values are properly sorted
        ///</summary>


        [TestMethod()]
        public void bubbleSortTest2()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 30; // The size of the array
            int[] actual = new int[SIZE]; //actual array declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, -100, -1), actual, SIZE); /*Copies the randomly populated array from the populateArray function to the actual*/


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to hold the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            
            target.bubbleSort(actual, SIZE); //the actual is now passed (by reference by default) to the bubbleSort method

            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance


            for (int count = 0; count < SIZE; count++) // loop that iterates through the arrays (collections) and checks if each element are respectively identical 

                Assert.AreEqual(expected[count], actual[count]);
        }

 /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/

        /// <summary>
        //Unit Test III for Bubble Sort that tests if a list of  negative and positive values will be properly sorted
        ///</summary>


        [TestMethod()]
        public void bubbleSortTest3()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 50; // The size of the array
            int[] actual = new int[SIZE]; //actual declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, -100, 100), actual, SIZE); /*Copies the randomly populated array from the populateArray function to the actual*/


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to store the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            
            target.bubbleSort(actual, SIZE); //the actual is now passed (by reference) to the bubbleSort method

       
            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            CollectionAssert.AreEqual(expected, actual);//compares the content of the expected and actual collection


          
        }//end bubbleSortTest3()

/*________________________________________________________________________________________________________________________________________________________________________________________________________________*/



        /// <summary>
        ////Unit Test IV for Bubble Sort that tests if a list of all positive values will be properly sorted
        ///</summary>


        [TestMethod()]
        public void bubbleSortTest4()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 80; // The size of the array
            int[] actual = new int[SIZE]; //actual declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, 10, 100), actual, SIZE); /*Copies the randomly populated array from the actual function to the actual array*/


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to store the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            target.bubbleSort(actual, SIZE); //the numbersArray is now passed (by reference) to the bubbleSort method

            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instan


            for (int count = 0; count < SIZE; count++) // loop that iterates through the arrays (collections) and checks if each element are respectively identical 

                Assert.AreEqual(expected[count], actual[count]);
        }
        
/*________________________________________________________________________________________________________________________________________________________________________________________________________________*/
        /// <summary>
        //Unit Test I for Insertion Sort that tests if a list of  with the same values will be properly sorted
        ///</summary>


        [TestMethod()]
        public void insertionSortTest1()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 20; // The size of the array
            int[] actual = new int[SIZE]; //actual  declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, 10, 10), actual, SIZE); /*Copies the randomly populated array from the populateArray method to the actual array*/


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to store the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method


            target.insertionSort(actual, SIZE); //the actual array is now passed (by reference) to the insertionSort method


            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
  

            for (int count = 0; count < SIZE; count++) // loop that iterates through the arrays (collections) and checks if each element are respectively identical 

                Assert.AreEqual(expected[count], actual[count]);
        }

/*________________________________________________________________________________________________________________________________________________________________________________________________________________*/

        /// <summary>
        //Unit Test II for Insertion Sort that tests if a partially sorted list will properly sorted
        ///</summary>


        [TestMethod()]
        public void insertionSortTest2()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 10; // The size of the array
            int[] actual = { 3, 6, 9, 10, 12, 11, 21, 19, 27, 1};


        
            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to hold the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method


            target.insertionSort(actual, SIZE); //the actual array is now passed (by reference) to the insertionSort method

            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            CollectionAssert.AreEqual(expected, actual);//compares the content of the expected and actual collection

        }//end insertionSortTest2


/*________________________________________________________________________________________________________________________________________________________________________________________________________________*/


        /// <summary>
        //Unit Test III for Insertion Sort that tests if a fully sorted array will be properly sorted (i.e. the fully sorted array should not be modified)
        ///</summary>


        [TestMethod()]
        public void insertionSortTest3()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 160; // The size of the array
            int[] actual = new int[SIZE]; //actual array declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, 35, 350), actual, SIZE); /*Copies the randomly populated array from the populateArray function to the actual array*/

            Array.Sort(actual); //produces the fully sorted array that will be used in the unit test.


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to store the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method


            target.insertionSort(actual, SIZE); //the actual array is now passed (by reference) to the insertionSort method


            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            CollectionAssert.AreEqual(expected, actual);//compares the content of the expected and actual collection

        }

 /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/


        /// <summary>
        //Unit Test IV for Insertion Sort that tests if one (1) element array will be properly sorted (i.e.) the element is simply returned where the while is never executed base on an intial fail condition
        ///</summary>


        [TestMethod()]
        public void insertionSortTest4()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 1; // The size of the array
            int[] actual= new int[SIZE]; //actual array declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, -500, 500), actual, SIZE); /*Copies the randomly populated array from the populateArray function to the actual array*/


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to sort the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method


            target.insertionSort(actual, SIZE); //the actual array is now passed (by reference) to the insertionSort method


            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
    
            for (int count = 0; count < SIZE; count++) // loop that iterates through the arrays (collections) and checks if each element are respectively identical 
                 Assert.AreEqual(expected[count], actual[count]);
        }


 /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/
        /// <summary>
        /// //Unit Test I for Shell Sort that tests the boundaries and middle of the sorted array by the shell sort method
        ///</summary>
        [TestMethod()]
        public void shellSortTest1()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 100; // The size of the array
            int[] actual = new int[SIZE]; //actual array declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, 300, 850), actual, SIZE); /*Copies the randomly populated array from the populateArray function to the actual array*/


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to hold the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            
            target.shellSort(actual, SIZE); //the actual array is now passed (by reference) to the shellSort method


            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            Assert.AreEqual(expected[0], actual[0]);//compares and checks the first index (low boundary)
            Assert.AreEqual(expected[SIZE - 1], actual[SIZE - 1]);//compares and checks the last index (high boundary)
            Assert.AreEqual(expected[(SIZE/2)], actual[(SIZE/2)]);//checks the middle index


            
        }//end shellSort1

 /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/
        /// <summary>
        /// //Unit Test II for Shell Sort that tests if a two element array will be can be properly sorted
        ///</summary>
        [TestMethod()]
        public void shellSortTest2()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 2; // The size of the array
            int[] actual = new int[SIZE]; //actual array declared of type int with 'SIZE' number of elements


            /*populateArray(Size ofArray, Minimum Random Value, Maximum Random Value): This function returns a populated array of a size and random values in range specified by the functions arguments*/

            Array.Copy(populateArray(SIZE, 20, 100), actual, SIZE); /*Copies the randomly populated array from the populateArray function to the actual array*/

            int[] expected= new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to store the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            
            target.shellSort(actual, SIZE); //the actual array is now passed (by reference) to the shellSort method

            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            
            for (int count = 0; count < SIZE; count++) // loop that iterates through the arrays (collections) and checks if each element are respectively identical 

                Assert.AreEqual(expected[count], actual[count]);

           
        }//end shellSort2

/*________________________________________________________________________________________________________________________________________________________________________________________________________________*/


        /// <summary>
        ///  //Unit Test III for Shell Sort that tests an array that is sorted and has duplicates values (positive and negative).
        ///</summary>
        [TestMethod()]
        public void shellSortTest3()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 10; // The size of the array
            int[] actual= {-7, -5, 1,1,2,4,4,6,7,9}; //the actual array declared with a sorted list of positive and negative values with duplicate values


            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to store the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expected array
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            
            target.shellSort(actual, SIZE); //the actual array is now passed (by reference) to the shellSort method

            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
    
            for (int count = 0; count < SIZE; count++) // loop that iterates through the arrays (collections) and checks if each element are respectively identical 
                   Assert.AreEqual(expected[count], actual[count]);
        }//end shellSort3

/*________________________________________________________________________________________________________________________________________________________________________________________________________________*/

        /// <summary>
        /// //Unit Test IV for Shell Sort that tests an array that is unsorted and every value has a duplicates values
        ///</summary>
        [TestMethod()]
        public void shellSortTest4()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 20; // The size of the array
            int[] actual = { 5, 4, 3, 2, 1, -5, -4, -3, -2, -1, -5, -4, -3, -2, -1, 5, 4, 3, 2, 1, };

            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to hold the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expectedArray
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            target.shellSort(actual, SIZE); //the actual array is now passed (by reference) to the shellSort method for testing

           
            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            CollectionAssert.AreEqual(expected, actual);//compares the content of the expected and actual collection
           
        }//end shellSort4
 /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/



        /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/

        /// <summary>
        /// //Unit Test V for Shell Sort that tests an array that is sorted and every value has a duplicates values
        ///</summary>
        [TestMethod()]
        public void shellSortTest5()
        {

            Sorts target = new Sorts(); // Creates an instance of the class to be tested (a target object/instance of the Sorts class)

            int SIZE = 15; // The size of the array
            int[] actual = { 1,1,1,2,2,2,3,3,3,4,4,4,5,5,5};

            int[] expected = new int[SIZE];//expected array declared of type int with 'SIZE' number of elements used to hold the required or expected order of elements

            Array.Copy(actual, expected, SIZE);//the actual array 's content is copied to the expectedArray
            Array.Sort(expected); //the expected array is sorted by the .NET Array.Sort Method

            target.shellSort(actual, SIZE); //the actual array is now passed (by reference) to the shellSort method for testing


            CollectionAssert.ReferenceEquals(expected, actual); //Checks if compared objects are of the same instance
            CollectionAssert.AreEqual(expected, actual);//compares the content of the expected and actual collection

        }//end shellSort4
        /*________________________________________________________________________________________________________________________________________________________________________________________________________________*/
    
    
    
    } // end class SortsTest
}//end TestProjectSorts namespace
