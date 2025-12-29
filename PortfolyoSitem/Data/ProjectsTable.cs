using System;
using System.Collections.Generic;

namespace PortfolyoSitem.Data;

public partial class ProjectsTable
{
    public int ProjectId { get; set; }

    public string? ShortDescription { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public string? UsingTechnologies { get; set; }

    public string? ProjectUrl { get; set; }

    public int? CategoryId { get; set; }

    public virtual CategoryTable? Category { get; set; }
}
