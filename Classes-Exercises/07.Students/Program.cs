namespace _07.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();

                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string town = commandArgs[3];

                Student student = new Student(firstName, lastName, age, town);
                students.Add(student);
            }

            string homeTown = Console.ReadLine();
            foreach (var student in students)
            {
                if (homeTown == student.homeTown)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
