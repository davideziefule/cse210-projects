namespace Homework;

// The base class for all assignments.
public class Assignment
{
    // Private member variables to store the student's name and topic.
    private string _studentName;
    private string _topic;

    // Constructor that initializes the student name and topic.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Returns a summary containing the student's name and assignment topic.
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Returns the student's name so derived classes can access it.
    public string GetStudentName()
    {
        return _studentName;
    }
}