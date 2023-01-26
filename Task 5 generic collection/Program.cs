//Create an instance

using System.Reflection;
using Task_5_generic_collection;
Answer result;
bool more;
string sName;
int numberOfExams = 5;
string givenValue;
List<int> points = new List<int>();
List<Student> students = new List<Student>();
int[] temporary = new int[numberOfExams];
Student student;
do
{
    Console.Write("Name: ");
    sName = Console.ReadLine();
    for (int i = 0; i < numberOfExams; i++)
    {
        Console.Write("Input {0}. exam points: ", i + 1);
        givenValue = Console.ReadLine();
        while(!Int32.TryParse(givenValue, out temporary[i]) || temporary[i] < 0 || temporary[i] > 10)
        {
            Console.Write("Not valid, try again: ");
            givenValue = Console.ReadLine();
        }
    }
    //From array to generic list:
    points = new List<int>(temporary);
    //Now it is possible to create a Student object:
    student = new Student(sName, points);
    //Add the instance to your collection:
    students.Add(student);


    Console.Write("More student (Y/N): ");
    char decision = char.ToUpper(Console.ReadKey().KeyChar);
    switch(decision)
    {
        case 'Y':
            more = true;
            break;
        default:
            more = false;
            break;
    }
}while(more);





foreach (var item in students)
{
    Console.WriteLine("\nStudent {0} got sum total of {1} points", item.Name, item.ExamPoints.Sum());
    Console.WriteLine("{0}'s grade is {1}.", item.Name, item.CalculateGrade());
    result = item.FindExamWithMinPoints();
    Console.WriteLine("Minimum points were {0} points.", result.Points);
    Console.WriteLine("It was the {0}. exam.", result.WhichOne);
}
