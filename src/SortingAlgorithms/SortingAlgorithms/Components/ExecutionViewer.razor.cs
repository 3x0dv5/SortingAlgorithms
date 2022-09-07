using Microsoft.AspNetCore.Components;
using SortingAlgorithms.Application;

namespace SortingAlgorithms.Components;

public partial class ExecutionViewer
{
    [Parameter]
    public Execution? Execution { get; set; }
}