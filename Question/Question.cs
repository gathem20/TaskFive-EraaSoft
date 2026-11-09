public class Question
{
    public string Header { get; set; }
    public int Marks { get; set; }
    public Level Level { get; set; }
    public Question(Level Level, string Header, int Marks)
    {
        this.Header = Header;
        this.Marks = Marks;
        this.Level = Level;
    }

    public virtual void Display() { }
    public virtual bool CheckAnswer(string Answer)
    {
        return true;
    }

}
