// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    // Acessando _studentName com um método público
    public string GetStudentName()
    {
        return base.GetSummary().Split(" - ")[0];
    }
}
