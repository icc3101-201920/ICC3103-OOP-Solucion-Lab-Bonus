using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_complete
{
    public class AddedProductEventArgs : EventArgs
    {
        public Product Product { get; set; }
        public List<Product> ShopList { get; set; }
        public Cart Cart { get; set; }
    }
}
