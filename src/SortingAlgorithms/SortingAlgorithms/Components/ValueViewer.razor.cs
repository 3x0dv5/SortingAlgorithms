using Microsoft.AspNetCore.Components;

namespace SortingAlgorithms.Components;

public partial class ValueViewer
{
    [Parameter]
    public int Value { get; set; }
}