namespace SortingAlgorithms.Application;

public class Step
{
    public int StepNumber { get; set; }
    public int[] Values { get; set; }
    
    public Step(int stepNumber, int[] values)
    {
        StepNumber = stepNumber;
        Values = values;
    }

    public override string ToString()
    {
        return string.Join(", ", Values);
    }
}