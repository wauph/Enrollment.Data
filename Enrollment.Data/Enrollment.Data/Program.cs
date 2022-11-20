using Enrollment.Data.Context;
using Enrollment.Data.Models;

using EnrollmentContext context = new EnrollmentContext();


var student = GetStudents().FirstOrDefault();

 static ICollection<Student> GetStudents()
{
    var students = new List<Student>();
    var student = new Student()
    {
        StudentID = "2",
        StudentName = "Beth",
        Subjects = GetStudentSubjects()
    };
    students.Add(student);
    return students;
}
 static ICollection<Subject> GetStudentSubjects()
{
    var subjects = new List<Subject>();
    var subjectOne = new Subject() { SubjectID = "3", SubjectName = "English" };
    var subjectTwo = new Subject() { SubjectID = "4", SubjectName = "Arabic" };
    subjects.Add(subjectOne);
    subjects.Add(subjectTwo);
    return subjects;
}

context.Add(student);
var IsSaved = context.SaveChanges();

if (IsSaved == 3)
{
    Console.WriteLine(student.StudentName + "Saved successfully");
    foreach (var subject in student.Subjects)
    {
        Console.WriteLine("subject " + subject.SubjectName);
    }
    Console.WriteLine("Student Details Printed Successfully");
}
else
{
    Console.WriteLine("an error has occured");
}

Console.ReadLine();
