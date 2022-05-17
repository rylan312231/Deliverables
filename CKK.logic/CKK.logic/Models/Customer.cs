using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.logic.models
{
    class Customers
    {
        public class Customer
        {
            private int _id;
            private string _Name;
            private string _Address;

            public int GetId()
            {
                return _id;
            }

            public void SetId(int id)
            {
                _id = id;
            }

            public string GetName()
            {
                return _Name;
            }

            public void SetName(string Name)
            {
                _Name = Name;
            }

            public string GetAddress()
            {
                return _Address;
            }

            public void SetAddress(string Address)
            {
                _Address = Address;
            }
        }     

              
        
    }
}
