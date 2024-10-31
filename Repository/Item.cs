using System;
using System.Collections.Generic;

namespace Repository;

public partial class Item
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public decimal? Value { get; set; }

    public decimal? Interest { get; set; }
}
