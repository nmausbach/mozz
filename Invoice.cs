using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice
    {
        public string partNumber;
        public string partDescription;
        public int quantity;
        public decimal price;
        public void SetNumber(string partNumber1)
        {
            partNumber = partNumber1;
        }
        public string GetNumber()
        {
            return partNumber;
        }
        public void SetDescription(string partDescription1)
        {
            partDescription = partDescription1;
        }
        public string GetDescription()
        {
            return partDescription;
        }
        public void SetQuantity(int partQuantity1)
        {
            quantity = partQuantity1;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetPrice(decimal price1)
        {
            price = price1;
        }
        public decimal GetPrice()
        {
            return price;
        }
    }  
}