using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_complete
{
    public class PayingEventArgs:EventArgs
    {
        public List<Product> ShopList { get; set; }
    }
}
