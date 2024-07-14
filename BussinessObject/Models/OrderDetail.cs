using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int DiamondId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Diamond Diamond { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
