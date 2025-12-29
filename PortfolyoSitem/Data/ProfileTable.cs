using System;
using System.Collections.Generic;

namespace PortfolyoSitem.Data;

public partial class ProfileTable
{
    public int ProfileId { get; set; }

    public string? FullName { get; set; }

    public string? Title { get; set; }

    public string? ShortDescription { get; set; }

    public string? ImageUrl { get; set; }
}
