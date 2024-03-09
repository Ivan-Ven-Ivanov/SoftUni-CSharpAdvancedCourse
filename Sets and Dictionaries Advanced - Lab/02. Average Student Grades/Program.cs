namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentInput[0];
                decimal studentGrade = decimal.Parse(studentInput[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
            }

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(g => $"{g:F2}"))} (avg: {kvp.Value.Average():F2})");
            }
        }
    }
}