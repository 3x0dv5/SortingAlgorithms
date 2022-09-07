using Microsoft.AspNetCore.Components;
using SortingAlgorithms.Application;

namespace SortingAlgorithms.Components;

public partial class ProgressViewer
{
    [Parameter]
    public Execution? Execution { get; set; }
}