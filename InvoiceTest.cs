using System;

namespace InvoiceTest
{
    class InvoiceTest
    {
        static void Main()
        {
            Invoice invoice1 = new Invoice();

            Console.WriteLine($"Part Number: {invoice1.partNumber}\nPart Description: {partDescription}\nQuantity {quantity}\n Price: {price}");
        }
    }
}
