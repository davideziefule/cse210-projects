namespace Homework;

// MathAssignment inherits the attributes and methods from Assignment.
public class MathAssignment : Assignment
{
    // Private member variables for the math assignment details.
    private string _section;
    private string _problems;

    // Constructor that initializes the inherited attributes and math details.
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Returns the textbook section and the list of problems to complete.
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}