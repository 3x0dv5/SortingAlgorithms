using System.Text;
using SortingAlgorithms.Application.Algorithms;

namespace SortingAlgorithms.Application;

public class Execution
{
    public int CurrentStep { get; set; }
    public Step[] Steps { get; set; }
    public Execution(Step[] steps)
    {
        Steps = steps;
        CurrentStep = steps.Length;
    }

    public static Execution Run(int[] initialValues, IAlgorithm algorithm)
    {
        var stepsValues = algorithm.PerformSort(initialValues).ToArray();
        Step[] steps = new Step[stepsValues.Length];
        for (int i = 0; i < stepsValues.Length; i++)
        {
            steps[i] = new Step(i, stepsValues[i]);
        }

        return new Execution(steps);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("==Execution==");
        sb.AppendLine($"Current step: {CurrentStep}");
        foreach (var step in Steps)
        {
            sb.AppendLine($">> Step {step.StepNumber}");
            sb.AppendLine(step.ToString());
            sb.AppendLine();

        }

        return sb.ToString();
    }
}