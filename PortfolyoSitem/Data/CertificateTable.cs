using System;
using System.Collections.Generic;

namespace PortfolyoSitem.Data;

public partial class CertificateTable
{
    public int CertificationsId { get; set; }

    public string? ShortDescription { get; set; }

    public string? IconUrl { get; set; }

    public string? CertificateName { get; set; }

    public string? CompanyName { get; set; }

    public string? Year { get; set; }
}
