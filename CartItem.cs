using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FakeStore
{
  public class CartItem
  {
    public Item Product { get; set; }
    public int Quantity { get; set; } = 1;
    public double SubTotal() => Product.Price * Quantity;
  }
}