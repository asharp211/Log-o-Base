﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_o_Base
{
    class Receipt
    {
        public int Item_Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Total { get { return string.Format("${0}", Price * Quantity); } }

    }
}
