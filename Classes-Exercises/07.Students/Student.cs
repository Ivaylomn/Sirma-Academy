namespace _07.Students
{
    internal class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string homeTown;

        public Student(string firstName, string lastName, int age, string town)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.homeTown = town;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {age} {homeTown}";
        }
    }
}
