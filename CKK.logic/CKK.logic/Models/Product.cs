using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.logic.models
{
    class Products
    {
        public class Product
        {
            private int _id;
            private string _Name;
            private string _Decimal;

            public int Getid()
            {
                return _id;
            }

            public void SetId(int Id)
            {
                _id = Id;
            }

            public string GetName()
            {
                return _Name;
            }

            public void SetName(string Name)
            {
                _Name = Name;
            }

            public string GetDecimal()
            {
                return _Decimal;
            }

            public void SetDecimal(string Decimal)
            {
                _Decimal = Decimal;
            }

        }
    }
}
