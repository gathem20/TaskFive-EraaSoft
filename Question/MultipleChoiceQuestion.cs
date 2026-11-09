public class MultipleChoiceQuestion : Question
{
    public List<string> CorrectAnswer { get; set; }
    public List<string> Answers { get; set; }
    public MultipleChoiceQuestion(Level Level, string Header, int Marks, List<string> CorrectAnswer, List<string> Answers) : base(Level, Header, Marks)
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
        bool isCorrect = false;
        List<string> StudentAnswers = new List<string>(Answer.Split(','));
        if (StudentAnswers.Count != CorrectAnswer.Count)
        {
            return false;
        }
        for (int i = 0; i < StudentAnswers.Count; i++)
        {

            isCorrect = false;

            for (int j = 0; j < CorrectAnswer.Count; j++)
            {
                if (StudentAnswers[i] == CorrectAnswer[j])
                {
                    isCorrect = true;
                }
            }
            if (!isCorrect)
                return false;
        }
        return true;
    }


}