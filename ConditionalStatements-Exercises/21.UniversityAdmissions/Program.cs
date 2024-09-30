namespace _21.UniversityAdmissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            int extraCurriculars = int.Parse(Console.ReadLine());

            string result = string.Empty;
            if (score >= 90)
            {
                result = "Admitted";
            }
            else if (score >= 80 && score < 90) 
            {
                if (extraCurriculars >= 2)
                {
                    result = "Admitted";
                }
                else
                {
                    result = "Not admitted";
                }
            }
            else
            {
                result = "Not admitted";
            }

            Console.WriteLine(result);
        }
    }
}
