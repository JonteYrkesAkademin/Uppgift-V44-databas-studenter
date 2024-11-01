using Microsoft.Identity.Client;
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

        bool endProgram = false;

        public void WriteMenu()
        {
            while (!endProgram)
            {
                Console.WriteLine("Välkommen till Studentinformationslistan! Vad vill du göra idag?:");
                Console.WriteLine("1: Registrera en ny student.");
                Console.WriteLine("2: Redigera en redan inskriven student.");
                Console.WriteLine("3: Lista alla inskrivna studenter.");
                Console.WriteLine("4: Avsluta programmet. (Alla dina ändringar är redan sparade)");



                int menuChoice;

                while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 7)
                {
                    Console.WriteLine("Val ogiltigt, försök igen.");
                }
                MenuOperationSelect(menuChoice);
            }
        }

        public void MenuOperationSelect(int menuChoice)
        {
            switch (menuChoice)
            {
                case 1:
                    CreateNewStudentMenu();
                    break;
                case 2:
                    ChangeStudentInfoMenu();
                    break;
                case 3:
                    ShowAllStudentsMenu();
                    break;
                case 4:
                    Console.WriteLine("Programmet avslutas!");
                    Thread.Sleep(200);
                    endProgram = true;
                    return;
                default:
                    Console.WriteLine("Ogiltig inmatning, försök igen:");
                    Thread.Sleep(500);
                    break;
            }
        }

        public void CreateNewStudentMenu()
        {
            Console.WriteLine("Ange Förnamn:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ange Efternamn:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ange Stad:");
            string city = Console.ReadLine();

            studentInfoList.CreateNewStudent(firstName, lastName, city);
        }
        public void ChangeStudentInfoMenu()
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

        public void ShowAllStudentsMenu()
        {
            Console.WriteLine("Här kommer en lista med alla studenter som finns registrerade:\n");
            studentInfoList.ShowAllStudents();
        }
    }
}
