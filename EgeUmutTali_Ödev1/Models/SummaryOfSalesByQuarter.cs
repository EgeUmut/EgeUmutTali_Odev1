﻿using System;
using System.Collections.Generic;

namespace EgeUmutTali_Ödev1.Models;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
