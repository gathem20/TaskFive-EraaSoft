public class TrueFalseQuestion : Question
{
    public bool CorrectAnswer { get; set; }
    public TrueFalseQuestion(Level Level, string Header, int Marks, bool CorrectAnswer) : base(Level, Header, Marks)
    {
        this.CorrectAnswer = CorrectAnswer;
    }


    public override void Display()
    {
        System.Console.WriteLine(Header);
        System.Console.WriteLine("1. True");
        System.Console.WriteLine("2. False");
        System.Console.WriteLine($"Mark: {Marks}");
    }
    public override bool CheckAnswer(string Answer)
    {
        bool StudentAnswer = false;
        if (Answer == "1")
        {
            StudentAnswer = true;

        }
        else if (Answer == "2")
        {
            StudentAnswer = false;

        }
        else
        {
            System.Console.WriteLine("Invalid Input ");
            return false;
        }


        if (StudentAnswer == CorrectAnswer)
        {
            System.Console.WriteLine("Correct!");
        }
        else
        {
            System.Console.WriteLine("Wrong!");
        }
        return StudentAnswer == CorrectAnswer;
    }


}