using Microsoft.AspNetCore.Components;
using SortingAlgorithms.Application;

namespace SortingAlgorithms.Components;

public partial class StepViewer
{
    [Parameter]
    public Step? Step { get; set; }
}