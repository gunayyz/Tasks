using System;
namespace Student
{
    public class Group
    {
        public string Name;
        public int MaxStuCount;
        Student[] students = new Student[0];
        public Group(string name, int maxStuCount)
        {
            Name = name;
            MaxStuCount = maxStuCount;

        }

        public void addStudent(Student student)
        {
            if (students.Length < MaxStuCount)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }

        }
        public void removeStudent(int index)
        {
            Student[] temp = new Student[students.Length - 1];
            int index2 = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (i != index)
                {
                    temp[index2] = students[i];
                    index2++;
                }
            }
            students = temp;
        }

        public void showStudent()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);

            }
        }
    }
}
