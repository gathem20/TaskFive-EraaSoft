using System.Security.Cryptography;

public class Doctor
{
    public static List<Question> questions = new List<Question>();
    public static void DoctorMode()
    {
        System.Console.WriteLine("How Many Queastions ?");
        string input = Console.ReadLine();
        int numberOfQuestions = Convert.ToInt32(input);
        for (int i = 1; i <= numberOfQuestions; i++)
        {
            System.Console.WriteLine("1. True Or False?");
            System.Console.WriteLine("2. ChooseOneQuestion ?");
            System.Console.WriteLine("3. MultipleChoiceQuestion ?");
            System.Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                System.Console.WriteLine("Enter Level: Easy / Medium , Hard ");
                Level level = Enum.Parse<Level>(Console.ReadLine().ToLower());
                System.Console.WriteLine("Enter Question Header");
                string Header = Console.ReadLine();
                System.Console.WriteLine("Enter Question Marks");
                int marks = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter Correct Answer: True / False");
                bool correct = Convert.ToBoolean(Console.ReadLine());
                questions.Add(new TrueFalseQuestion(level, Header, marks, correct));
            }
            if (choice == "2")
            {
                System.Console.WriteLine("Enter Level: Easy / Medium , Hard ");
                Level level = Enum.Parse<Level>(Console.ReadLine().ToLower());
                System.Console.WriteLine("Enter Question Header");
                string Header = Console.ReadLine();
                System.Console.WriteLine("Enter Question Marks");
                int marks = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter Correct Answer In Choice Number(1 - 4)");
                string correct = Console.ReadLine();

                List<string> answers = new List<string>();
                for (int j = 1; j <= 4; j++)
                {
                    System.Console.WriteLine($"Enter Choice {j}");
                    answers.Add(Console.ReadLine());
                }


                questions.Add(new ChooseOneQuestion(level, Header, marks, correct, answers));
            }
            if (choice == "3")
            {
                System.Console.WriteLine("Enter Level: Easy / Medium , Hard ");
                Level level = Enum.Parse<Level>(Console.ReadLine().ToLower());
                System.Console.WriteLine("Enter Question Header");
                string Header = Console.ReadLine();
                System.Console.WriteLine("Enter Question Marks");
                int marks = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter Correct Answer In Choice Number(1 - 4)");
                string correct = Console.ReadLine();

                List<string> answers = new List<string>();
                for (int j = 1; j <= 4; j++)
                {
                    System.Console.WriteLine($"Enter Choice {j}");
                    answers.Add(Console.ReadLine());
                }
                List<string> correctList = new List<string>(correct.Split(','));
                questions.Add(new MultipleChoiceQuestion(level, Header, marks, correctList, answers));

            }
            if (choice == "4")
            {
                break;
            }
        }

    }
}