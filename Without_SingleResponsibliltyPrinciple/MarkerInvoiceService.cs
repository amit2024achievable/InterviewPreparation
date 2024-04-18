using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Here , There are two reasons to change this class functilaity
1 : For changing the PrintInovide method
>> Now, if tommorow based on the financial years, i want to print the Invide, there the login should be changes here.
2 : Change in BD Saving part
>> If i want to save to NO-SQL Db , Plain text , then the logic should be changed here

>> If these two things are dependant on each other, the whole loginc will change
 */
namespace Without_SingleResponsibliltyPrinciple
{
    public class MarkerInvoiceService
    {
        private Marker _marker;

        public MarkerInvoiceService(Marker marker)
        {
            this._marker = marker;
        }
        
        // Method to Print Invoice
        public void PrintInvoice()
        {
            double price = (_marker._baseprice * (double)this._marker._quatity);
            Console.WriteLine($"Printed Invoice : {price}");
        }

        // Save to Database
        public void SaveToDB()
        {
            Console.WriteLine("Saved to MS SQL Server Database");
        }

    }
}
