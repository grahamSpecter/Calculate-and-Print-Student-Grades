using System;
using System.Linq;

// See https://aka.ms/new-console-template for more information

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
float sophiaGradesSum = sophiaGrades.Sum();

//  Write sophiaGradesSum below to test
//Console.WriteLine(sophiaGradesSum);

// Workout grades average for Sophia
float sophiaGradesAverage = sophiaGradesSum / currentAssignments;
//Console.WriteLine(sophiaGradesAverage);

// --------------Same as above now for nicolas------------------------------------

int[] nicolasGrades = new int[] {nicolas1, nicolas2, nicolas3, nicolas4, nicolas5};
float nicolasGradesSum = nicolasGrades.Sum();

//Console.WriteLine(nicolasGradesSum);
float nicolasGradesAverage = nicolasGradesSum / currentAssignments;
//Console.WriteLine(nicolasGradesAverage);

// --------------Same as above now for zahirah------------------------------------

int[] zahirahGrades = new int[] {zahirah1, zahirah2, zahirah3, zahirah4, zahirah5};
float zahirahGradesSum = zahirahGrades.Sum();

//Console.WriteLine(zahirahGradesSum);
float zahirahGradesAverage = zahirahGradesSum / currentAssignments;
//Console.WriteLine(zahirahGradesAverage);

// --------------Same as above now for jeong------------------------------------
int[] jeongGrades = new int[] {jeong1, jeong2, jeong3, jeong4, jeong5};
float jeongGradesSum = jeongGrades.Sum();

//Console.WriteLine(jeongGradesSum);
float jeongGradesAverage = jeongGradesSum / currentAssignments;
//Console.WriteLine(jeongGradesAverage);

// --------------Method for assigning LetterGrades------------------------------------

string GradeScore(float GradeSum)
{
    if (GradeSum >= 90) return "A";
    else if (GradeSum >= 80) return "B";
    else if (GradeSum >= 70) return "C";
    else if (GradeSum >= 60) return "D";
    else return "F";
} 

// Assigning Letter Grades
string sophiaLetterGrade = GradeScore(sophiaGradesAverage);
string nicolasLetterGrade = GradeScore(nicolasGradesAverage);
string zahirahLetterGrade = GradeScore(zahirahGradesAverage);
string jeongLetterGrade = GradeScore(jeongGradesAverage);

// Output
Console.WriteLine("\r");
Console.WriteLine("{0,-10} {1,5} {2,5}", "Student", "Grade", "Letter");
Console.WriteLine("-------------------------------------");
Console.WriteLine("{0,-10} {1,5:F1} {2,5}", "Sophia", sophiaGradesAverage, sophiaLetterGrade);
Console.WriteLine("{0,-10} {1,5:F1} {2,5}", "Nicolas", nicolasGradesAverage, nicolasLetterGrade);
Console.WriteLine("{0,-10} {1,5:F1} {2,5}", "Zahirah", zahirahGradesAverage, zahirahLetterGrade);
Console.WriteLine("{0,-10} {1,5:F1} {2,5}", "Jeong", jeongGradesAverage, jeongLetterGrade);
