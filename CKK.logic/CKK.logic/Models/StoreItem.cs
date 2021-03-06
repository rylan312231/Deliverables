using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.logic.models
{
    class StoreItem
    {
        public class StoreItems
        {
            private Product _product;
            private int _Quantity;

            public StoreItems(Product product, int Quantity)
            {
                _product = product;
                _Quantity = Quantity;
            }

            public int GetQuantity()
            {
                return _Quantity;
            }

            public void SetQuantity(int Quantity)
            {
                _Quantity = Quantity;
            }
  
            public Product GetProduct()
            {
                return _product;
            }

            public void SetProduct(Product product)
            {
                _product = product;
            }
        }
    }
}
