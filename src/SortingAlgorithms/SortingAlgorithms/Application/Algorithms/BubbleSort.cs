namespace SortingAlgorithms.Application.Algorithms;

public class BubbleSort : IAlgorithm
{
    public List<int[]> PerformSort(int[] initialValues)
    {
        var lastElementIndex = initialValues.Length - 1;
        // bubble sort loops through the values n - 1 times and always touching one less element

        var stepsValues = new List<int[]> {(int[]) initialValues.Clone()};

        void tick()
        {
            stepsValues.Add((int[]) initialValues.Clone());
        }

        // === Algorithm ===

        for (var passRange = lastElementIndex; passRange >= 0; passRange--)
        {
            // for each step or pass bubble sort goes position by position to check if [i] > [i+1] and if so swap them
            for (var i = 0; i < passRange; i++)
            {
                if (initialValues[i] > initialValues[i + 1])
                {
                    // and swap them
                    (initialValues[i], initialValues[i + 1]) = (initialValues[i + 1], initialValues[i]);
                }
            }

            tick();
        }

        return stepsValues;
    }
}