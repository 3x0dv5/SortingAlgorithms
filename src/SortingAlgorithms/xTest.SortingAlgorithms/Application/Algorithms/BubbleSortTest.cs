using SortingAlgorithms.Application;
using SortingAlgorithms.Application.Algorithms;
using Xunit.Abstractions;

namespace xTest.SortingAlgorithms.Application.Algorithms;

public class BubbleSortTest
{
    private readonly ITestOutputHelper _output;

    public BubbleSortTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact(DisplayName = "1. simple use case")]
    public void SimpleUseCase()
    {
        var values = new int[] {32, 45, 6, 10, 1};
        var actual = Execution.Run(values, new BubbleSort());

        Assert.Equal( values.Length + 1, actual.CurrentStep);
        var expected = """ 
            ==Execution==
            Current step: 6
            >> Step 0
            32, 45, 6, 10, 1

            >> Step 1
            32, 6, 10, 1, 45

            >> Step 2
            6, 10, 1, 32, 45

            >> Step 3
            6, 1, 10, 32, 45

            >> Step 4
            1, 6, 10, 32, 45

            >> Step 5
            1, 6, 10, 32, 45
            
                        
            """;

        Assertions.EqualString(actual.ToString(), expected, _output);
    }
}