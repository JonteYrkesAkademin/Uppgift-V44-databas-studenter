using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_V44_databas_studenter
{
    internal class Menu
    {
        private StudentInfoList studentInfoList;
        public Menu(StudentInfoList studentInfoList)
        {
            this.studentInfoList = studentInfoList;
        }

        public void CreateNewStudent()
        {
            Console.WriteLine("Ange Förnamn");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ange Efternamn");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ange Telefonnummer");
            string city = Console.ReadLine();

            studentInfoList.CreateNewStudent(firstName, lastName, city);
        }
        public void ChangeStudentInfo()
        {
            Console.WriteLine("Vilken student vill du ändra informationen för? Ange ID:");
            int studentIdToChange = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett nytt Förnamn:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ange ett nytt Efternamn:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ange en ny stad:");
            string city = Console.ReadLine();

            studentInfoList.ChangeStudentInfo(studentIdToChange, firstName, lastName, city);
        }
    }
}
