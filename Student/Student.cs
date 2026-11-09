public class Student
{
    public static void StudentMode()
    {
        System.Console.WriteLine("1. Practical Exam");
        System.Console.WriteLine("2. Final Exam");
        string choice = Console.ReadLine();

        System.Console.WriteLine("Enter Level: Easy / Medium , Hard ");
        Level level = Enum.Parse<Level>(Console.ReadLine().ToLower());
        List<Question> Q = new List<Question>();

        for (int i = 0; i < Doctor.questions.Count; i++)
        {
            if (Doctor.questions[i].Level == level)
            {
                Q.Add(Doctor.questions[i]);
            }
        }
        int count = 0;
        if (choice == "1")
        {
            count = Q.Count / 2;
        }
        if (choice == "2")
        {
            count = Q.Count;
        }
        int studentScore = 0;
        int totalMarks = 0;

        for (int i = 0; i < count; i++)
        {
            Q[i].Display();
            string answer = Console.ReadLine();

            totalMarks += Q[i].Marks;

            if (Q[i].CheckAnswer(answer))
            {
                studentScore += Q[i].Marks;
            }
        }
        Console.WriteLine($"Your Result: {studentScore} / {totalMarks}");
    }
}