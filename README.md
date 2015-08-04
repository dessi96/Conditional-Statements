Homework: Conditional Statements
This document defines homework assignments from the “C# Basics“ Course @ Software University. 


Exchange If Greater

Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.


Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:

	If the score is between 1 and 3, the program multiplies it by 10.
	
	If the score is between 4 and 6, the program multiplies it by 100.
	
	If the score is between 7 and 9, the program multiplies it by 1000.
	
	If the score is 0 or more than 9, the program prints “invalid score”.


Check for a Play Card

Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 


Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. 


The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers. 


The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.


Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 


Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Print “not a digit” in case of invalid inut. Use a switch statement.


Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.


Beer Time

A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. 


Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 


Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. 


Triangle

You are given a two-dimensional Cartesian coordinate system and three points A, B, C with coordinates: A(Ax, Ay), B(Bx,  By), C(Cx, Cy). Write a program to check if these three points can form a triangle. Then calculate the area of this triangle. To find the distance between two points with the coordinates (x1, y1) and (x2, y2) use the formula:
D= √(〖〖(x〗_2-x_1)〗^2+〖〖(y〗_2-y_1)〗^2 ) 

You can use the inequalities of a triangle to check whether three segments a, b and c can form a triangle:
a+b>c;  b+c>a; a+c>b

To calculate the area you can use Heron`s formula (a method for calculating the area of a triangle when you know the lengths of all three sides). Let a, b, c be the lengths of the sides of a triangle. Thus:
Area=√(p(p-a)(p-b)(p-c) ), where p is half the perimeter: (a+b+c)/2.

Input

The input data comes from the console. It consists of exactly 6 lines holding the coordinates of the three points: Ax-coordinate, Ay-coordinate, Bx-coordinate, By-coordinate, Cx-coordinate and Cy-coordinate. The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

The output data should be printed on the console and must contain two lines. 

	First line: If the given points can form a triangle you must print the message “Yes”, otherwise “No”.
	
	Second line: If the given points can form a triangle you must print the area of the triangle rounded to two decimal places (see the examples), otherwise you must print the distance between point A and point B. Use "." as decimal separator.

Constraints

	The coordinate X is integer in the range [-10000… 10000] inclusive.
	
	The coordinate Y is integer in the range [-10000… 10000] inclusive.
	
	Allowed work time for your program: 0.1 seconds.
	
	Allowed memory: 16 MB.
	
