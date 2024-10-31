using System;
using System.Collections.Generic;

namespace Repository;

public partial class CapitalInformation
{
    public int CapitalId { get; set; }

    public int? SafeCapital { get; set; }

    public int? CurrentCapital { get; set; }

    public int? InvestCapital { get; set; }

    public int? ExpectedCapital { get; set; }
}
