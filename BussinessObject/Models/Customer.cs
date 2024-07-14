using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerFullName { get; set; }

    public string? Telephone { get; set; }

    public string? EmailAddress { get; set; }

    public string? CustomerStatus { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
