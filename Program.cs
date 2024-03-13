﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* You're developing a Student Grading application that automates the calculation of current grades for each student in a class. The parameters for your application are:

You're given a short list of four students and their five assignment grades.
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
Final scores are calculated as an average of the five assignment scores.
Your application needs to perform basic math operations to calculate the final grades for each student.
Your application needs to output/display each student’s name and final score.
Currently, the teachers grade book shows the graded assignments for each student as follows:


Copy
Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah:   84, 96, 73, 85, 79

Jeong:  90, 92, 98, 100, 97
The teacher requires that the calculated grades for each student are displayed as follows:


Copy
Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A
*/


// initialize variables - graded assignmenets
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

//Creating a sum of an array of the grades for sophia

int[] sophiaGrades = new int[] {sophia1, sophia2, sophia3, sophia4, sophia5};
int sophiaGradesSum = sophiaGrades.Sum();
//  Write sophiaGradesSum below to test
//Console.WriteLine(sophiaGradesSum);

// Workout grades average for Sophia
int sophiaGradesAverage = sophiaGradesSum / currentAssignments;
Console.WriteLine(sophiaGradesSum);


