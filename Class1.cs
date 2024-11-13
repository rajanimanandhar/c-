// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Nilgiri");
using System;
public class Workshop1
{
    public string studentId;
    public string studentName;
    public int studentAge;
    public string studentGender;

    public void student()
    {
        Console.Write("Enter Your London Met ID: ");
        studentId = Console.ReadLine();

        //ask for student name
        Console.Write("Enter Your Name: ");
        studentName = Console.ReadLine();

        //ask for student age
        Console.Write("Enter your age: ");
        studentAge = Convert.ToInt32(Console.ReadLine());

        //ask for gender
        Console.Write("Enter Your Gender: ");
        studentGender = Console.ReadLine();

        //Print the student details
        Console.WriteLine("/n Student Details: ");
        Console.WriteLine("ID: " + studentId);
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age:" + studentAge);
        Console.WriteLine("Gender: " + studentGender);
    }

}
