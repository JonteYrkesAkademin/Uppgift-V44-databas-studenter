using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Inlämning_V44_databas_studenter
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public Student() { }

        public override string? ToString()
        {
            return $"StudentID: {StudentId.ToString().PadLeft(5).PadRight(5)} Förnamn: {FirstName.ToString().PadLeft(5).PadRight(5)} Efternamn: {LastName.ToString().PadLeft(5).PadRight(5)} Stad: {City.ToString().PadLeft(5).PadRight(5)}\n";
        }
    }
}
