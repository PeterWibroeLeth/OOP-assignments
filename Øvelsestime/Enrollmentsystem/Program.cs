
namespace Program {
    public class Program {
        static void Main(string[] args){
            Student s = new Student();
            string result = s.AddStudent("Frank",1);

            Console.WriteLine(result);

        }
    }
}




public class Student {
    
    public string name;
    public int id;

    public void AddStudent(Student student)
    {
        for (int i = 0; i < student.Length; i++)
        {
            if (student[i] == null)
            {
                student[i] = student;
                return;
            }
        }
        Console.WriteLine("The enrollment system is occupied");
    }

    public Student(string name, int id)
    {
        name = name;
        id = id;
    }

    public string GetName()
    {
        return name;
    }
}

public class Course {
    string name;
    Student[] participants;
    int id;

    public void AddCourse(Course course)
    {
        for (int i = 0; i < Course.Length; i++)
        {
            if (course[i] == null)
            {
                course[i] = course;
                return;
            }
        }
        Console.WriteLine("No available slots for Courses");
    }


    public void Enroll(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == null)
            {
                participants[i] = student;
                return;
            }
        }
    }

    public void Remove(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == student)
            {
                participants[i] = null;
            }
        }
    }

    public Student[] GetParticipants()
    {
        // count number of entries
        int count = 0;
        foreach (Student student in participants)
        {
            if (student != null)
            {
                count++;
            }
        }
    }
}