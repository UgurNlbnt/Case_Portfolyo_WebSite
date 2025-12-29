using System;
using System.Collections.Generic;

namespace PortfolyoSitem.Data;

public partial class ContactTable
{
    public int ContactId { get; set; }

    public string? ShortDescription { get; set; }

    public string? EmailAdress { get; set; }

    public string? LinkedlnUrl { get; set; }

    public string? GithubUrl { get; set; }

    public string? InstagramUrl { get; set; }
}
