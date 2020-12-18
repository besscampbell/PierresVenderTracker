using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> {};
        public string Name { get; set; }
        public string Bio { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }

        public Vendor(string vendName)
        {
            Name = vendName;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order>{};
        }
        
         public Vendor(string vendName, string bio)
        {
            Name = vendName;
            Bio = bio;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order>{};
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static Vendor Find(int vendId)
        {
            return _instances[vendId-1];
        }

        public void AddOrder(Order order)
        {
            DateTime date = new DateTime(2020,12,24);
            Order newWorldOrder = new Order("title", date, 36, 24, 140, "notes");
            Orders.Add(newWorldOrder);
        }
    }
}