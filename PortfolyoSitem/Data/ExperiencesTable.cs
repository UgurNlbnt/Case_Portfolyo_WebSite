using System;
using System.Collections.Generic;

namespace PortfolyoSitem.Data;

public partial class ExperiencesTable
{
    public int ExperienceId { get; set; }

    public string? ShortDescription { get; set; }

    public string? Year { get; set; }

    public string? Title { get; set; }

    public string? CompanyName { get; set; }

    public string? Description { get; set; }
}
