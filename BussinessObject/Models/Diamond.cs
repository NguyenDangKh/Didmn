using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Diamond
{
    public int DiamondId { get; set; }

    public string? Name { get; set; }

    public string? Size { get; set; }

    public string? Weight { get; set; }

    public string? Color { get; set; }

    public decimal? Price { get; set; }

    public int? Stock { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
