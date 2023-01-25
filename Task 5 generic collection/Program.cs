//Create an instance

using System.Reflection;
using Task_5_generic_collection;
Answer result;

List<Student> students = new List<Student>()
{
    new Student("Joel",new List<int> { 5, 7, 9, 10, 4 }),
    new Student("Jane",new List<int> { 8, 7, 9, 5, 7 }),
    new Student("Heidi",new List<int> { 9, 10, 7, 3, 5 }),
    new Student("Elisabeth",new List<int> { 8, 6, 6, 8, 10 })
};
foreach (var item in students)
{
    Console.WriteLine("Student {0} got sum total of {1} points", item.Name, item.CalculateSum());
    Console.WriteLine("{0}'s grade is {1}.", item.Name, item.CalculateGrade());
    result = item.FindExamWithMinPoints();
    Console.WriteLine("Minimum points were {0} points.", result.Points);
    Console.WriteLine("It was the {0}. exam.", result.WhichOne);
}
