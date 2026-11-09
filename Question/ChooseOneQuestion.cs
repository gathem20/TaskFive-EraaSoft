
public class ChooseOneQuestion : Question
{
    public string CorrectAnswer { get; set; }
    public List<string> Answers { get; set; }
    public ChooseOneQuestion(Level Level, string Header, int Marks, string CorrectAnswer, List<string> Answers) : base(Level, Header, Marks)
    {
        this.CorrectAnswer = CorrectAnswer;
        this.Answers = Answers;
    }
    public override void Display()
    {
        System.Console.WriteLine(Header);
        for (int i = 0; i < Answers.Count; i++)
        {

            System.Console.WriteLine($"{i + 1} . {Answers[i]}");
        }
        System.Console.WriteLine($"Mark: {Marks}");
    }
    public override bool CheckAnswer(string Answer)
    {

        bool isValid = false;
        for (int i = 0; i < Answers.Count; i++)
        {
            if (Answer == (i + 1).ToString())
            {
                isValid = true;
            }
        }

        if (!isValid)
        {
            System.Console.WriteLine("Invalid Input");
            return false;
        }
        else if (Answer == CorrectAnswer)
        {
            System.Console.WriteLine("Correct!");
        }
        else
        {
            System.Console.WriteLine("Wrong!");
            return false;
        }
        return Answer == CorrectAnswer;
    }

}