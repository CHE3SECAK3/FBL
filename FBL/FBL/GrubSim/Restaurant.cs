using System;
using System.Collections.Generic;
using System.Collections;
namespace FBL.GrubSim
{
    class Restaurant
    {
        Dictionary<string, decimal> menu;
        public string Name { get; set; }
        public string Location { get; set; }
        private List<string> currentOrders;

        public Restaurant(string Name, string Location, Dictionary<string, decimal> menu)
        {
            this.Name = Name;
            this.Location = Location;
            this.menu = menu;
        }
        public string requestMenuForViewing() { return ""; }
        public Dictionary<string, decimal> requestMenu() { return menu; }
        public void addOrder(string orderCode) { currentOrders.Add(orderCode); }
        public void requestSpecificOrder(string order_number) { }
        private string findOrder(string order_number) { return ""; }
        public List<string> requestAllOrders() { return currentOrders; }
    }
}
