using System;
using System.Collections.Generic;

namespace Repository;

public partial class PawnContract
{
    public string ContractNumber { get; set; } = null!;

    public string? UserRealName { get; set; }

    public string? Item { get; set; }

    public decimal? PawnMoney { get; set; }

    public string? PhoneNumber { get; set; }

    public double? Interest { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
}
