using System.Collections.Generic;
using System;
namespace VendorTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int PastryOrder { get; set ;}
        public int BreadOrder { get; set; }
        public int TotalCost { get; set; }
        public string Notes { get; set; }

        public Order(string title, DateTime date, int pastryOrder, int breadOrder, int totalCost, string notes)
        {
            Title = title;
            Date = date;
            PastryOrder = pastryOrder;
            BreadOrder = breadOrder;
            TotalCost = totalCost;
            Notes = notes;
        }
        public Order(string title, DateTime date, int pastryOrder, int breadOrder, int totalCost)
        {
            Title = title;
            Date = date;
            PastryOrder = pastryOrder;
            BreadOrder = breadOrder;
            TotalCost = totalCost;
        }
        
    }
}