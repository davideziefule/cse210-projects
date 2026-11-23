namespace Homework;

// WritingAssignment inherits from the Assignment base class.
public class WritingAssignment : Assignment
{
    // Private member variable to store the writing assignment title.
    private string _title;

    // Constructor that initializes the inherited attributes and writing title.
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Returns the writing title followed by the student's name.
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}