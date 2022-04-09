namespace Student
{
    class Program
    {

        static void Main(string[] args)
        {
            Group group = new Group("Test1", 3);
            group.addStudent(new Student() { Name = "mehemmed" });
            group.addStudent(new Student() { Name = "Gunay" });
            group.showStudent();
            group.addStudent(new Student() { Name = "Ibo" });


        }
    }
}
