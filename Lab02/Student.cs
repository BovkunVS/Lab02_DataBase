namespace Lab02
{
    internal class Student
    {
        // StLastName, StFirstName,Grade,Classroom,Bus
        public string? StLastName { get; set; }
        public string? StFirstName { get; set; }
        public int Grade { get; set; }
        public int Classroom { get; set; }
        public int Bus { get; set; }

        public override string ToString()
        {
            string? data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Grade: " + Grade + Environment.NewLine;
            data += "Student Classroom: " + Classroom + Environment.NewLine;
            data += "Student Bus: " + Bus + Environment.NewLine;
            return data;
        }

        public string ToStringStudentClassTeacher()
        {
            string? data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Classroom: " + Classroom + Environment.NewLine;
            return data;
        }

        public string ToStringStudentBus()
        {
            string? data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Bus: " + Bus + Environment.NewLine;
            return data;
        }

        public string ToStringTeacherStudents()
        {
            string? data = "student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }

        public string ToStringBusStudent()
        {
            string? data = "student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }

        public string ToStringStudentGrade()
        {
            string? data = "student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }

        public string ToStringStudentClassroom()
        {
            string? data = "student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }
    }
}