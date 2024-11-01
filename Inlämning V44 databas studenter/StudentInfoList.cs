using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_V44_databas_studenter
{
    internal class StudentInfoList
    {
        public Menu menu { get; set; }

        public StudentInfoList()
        {
            menu = new Menu(this);
        }

        StudentInfoListDbContext dbCtx = new StudentInfoListDbContext();

        public void CreateNewStudent(string firstName, string lastName, string city)
        {
            dbCtx.Add(new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                City = city,
            });
            dbCtx.SaveChanges();
        }

        public void ChangeStudentInfo(int studentId, string newFirstName, string newLastName, string newCity)
        {
            var student = dbCtx.Students.FirstOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                student.FirstName = newFirstName;
                student.LastName = newLastName;
                student.City = newCity;

                dbCtx.SaveChanges();
            }
            else
            {
                Console.WriteLine("Studenten kunde inte hittas.");
            }
        }

        public void ShowAllStudents()
        { 
            foreach (var student in dbCtx.Students)
            {
                Console.WriteLine(student.ToString());
            }
        }

    }
}
