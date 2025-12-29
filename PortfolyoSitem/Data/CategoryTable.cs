using System;
using System.Collections.Generic;

namespace PortfolyoSitem.Data;

public partial class CategoryTable
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<ProjectsTable> ProjectsTables { get; set; } = new List<ProjectsTable>();
}
