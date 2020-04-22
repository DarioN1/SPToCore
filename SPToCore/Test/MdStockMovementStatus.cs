using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdStockMovementStatus
    {
        public int IdStockMovementStatus { get; set; }
        public string Code { get; set; }
        public string StockMovementStatus { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
