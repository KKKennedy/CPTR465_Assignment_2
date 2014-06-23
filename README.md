CPTR465_Assignment_2
====================
Northern Caribbean University
Department of Computer & Information Sciences
CPTR465-Advanced Application Development
Assignment #2 (30pts / 10%)
Due Date: June 1, 2014 by 11:59PM 

Instruction: Write the program for the problem below. This assignment must be submitted via http://lms.ncu.edu.jm and also presented in class on June 2, 2014.

You have been asked by your project’s manager to use the instrumentation, and profiling feature of the .NET platform to analyze three different sorting algorithms, and write a brief report to document the time taken and number of calls to each function. Based on the data received, you should recommend the best sorting algorithm to be used for the current project (proper justifications should be given). 

You are also expected to write at least three (3) test cases for each sort function. Your application should be demonstrated with an array of 10,000 randomly generated numbers between 1 and 5000. You can implement your application in either VB.NET or C#.NET.

N.B.: Please use detailed comments as a documentation methodology to clearly explain each section of your code. Each function should have the following function description:

Description              		== e.g.: Function to count the number of vowels in a given string
(Arguments)  return type 	== e.g.: (string, int)  int
Precondition                        	== e.g.: String must not be NULL or Empty
Postcondition			== e.g.: The number of vowels contained in the given string is 							 returned
Example (s)			== e.g.: string x = “Hello”; Function(x) = 2



Rubric
Insertion Sort Implementation		3pts
Shell Sort Implementation			3pts
Bubble Sort Implementation			3pts
Test Cases (3 * 3)				9pts
Comments					3pts
Report						4pts
Demonstration				5pts
Total							30pts

 
Algorithms:
•	insertionSort
•	shellSort
•	bubbleSort

algorithm insertionSort (ref list <array>, val last <index>)
1.	current = 1
2.	loop (current <= last)
1.	hold = list[current]
2.	walker = current - 1
3.	loop (walker >= 0 AND hold.key < list[walker].key)
1.	list[walker + 1] = list[walker]
2.	walker = walker - 1
4.	end loop
5.	list[walker + 1] = hold
6.	current = current + 1
3.	end loop
4.	return
end insertionSort




algorithm shellSort (ref list <array>, val last <integer>)
1.	incre = last / 2
Compare keys "increment" elements apart.
2.	loop (incre not 0)
1.	current = incre
2.	loop (current <= last)
1.	hold = list[current]
2.	walker = current - incre
3.	loop (walker >= 0 AND hold.key < list[walker].key)
	Move larger elements up in list.
1.	list [walker + incre] = list[walker]
Fall back one partition.
2. walker = walker - incre
4.	end loop
Insert hold record in proper relative location
5.	list [walker + incre] = hold
6.	current = current + 1
3.	end loop
End of pass -- calculate next increment.
4.	incre = incre / 2
3.	end loop
4.	return
end shellSort
 
algorithm bubbleSort (ref list <array>, val last <index>)
1.	current = 0
2.	sorted = false
3.	loop (current <= last AND sorted false)
	Each iteration is one sort pass.
1.	walker = last
2.	sorted = true
3.	loop (walker > current)
1.	if (list[walker] < list[walker - 1])
Any exchange means list is not sorted
1.	sorted = false
2.	exchange (list, walker, walker - 1)
3.	end if
4.	walker = walker - 1
2.	end loop
3.	current = current + 1
4.	end loop
5.	return
end bubbleSort


