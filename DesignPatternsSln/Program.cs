using System;
using Without_SingleResponsibliltyPrinciple;





class Program
{
    public static void Main()
    {
        Marker marker = new Marker("Black Marker", "Red", "DOMS", 10);
        MarkerInvoiceService markerInvoiceService = new MarkerInvoiceService(marker);
        markerInvoiceService.PrintInvoice();
        markerInvoiceService.SaveToDB();

    }
}