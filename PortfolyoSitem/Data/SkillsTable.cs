using System;
using System.Collections.Generic;

namespace PortfolyoSitem.Data;

public partial class SkillsTable
{
    public int SkillsId { get; set; }

    public string? ShortDescription { get; set; }

    public string? SkillName { get; set; }

    public int? SkillsPercent { get; set; }
}
