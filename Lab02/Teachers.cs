using System.Diagnostics;

namespace Lab02
{
    internal class Teachers
    {
        // TLastName,TFirstName,Classroom
        public string? TLastName { get; set; }
        public string? TFirstName { get; set; }
        public int Classroom { get; set; }

        public override string ToString()
        {
            string? data = "Teacher LastName: " + TLastName + Environment.NewLine;
            data += "Teacher FirstName: " + TFirstName + Environment.NewLine;
            data += "Teacher Classroom: " + Classroom + Environment.NewLine;
            return data;
        }

        public string ToStringStudentClassTeacher()
        {
            string? data = "Teacher LastName: " + TLastName + Environment.NewLine;
            data += "Teacher FirstName: " + TFirstName + Environment.NewLine;
            return data;
        }

        public string ToStringTeacherClassroom()
        {
            string? data = "teacher: " + TLastName + " " + TFirstName + Environment.NewLine;
            return data;
        }

        public string ToStringTeacherGrade()
        {
            string? data = "teacher: " + TLastName + " " + TFirstName + Environment.NewLine;
            return data;
        }

    }
}