
using System;
using System.Collections.Generic;


class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public string HomeTown { get; private set; }

    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}


class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
                break;

            string[] studentInfo = input.Split();
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            int age = int.Parse(studentInfo[2]);
            string homeTown = studentInfo[3];

            Student student = new Student(firstName, lastName, age, homeTown);
            students.Add(student);
        }

        string city = Console.ReadLine();

        foreach (var student in students)
        {
            if (student.HomeTown == city)
            {
                Console.WriteLine(student);
            }
        }
    }
}
