using Model;
using System;
using System.Collections.Generic;


namespace LocationCar.Model
{
    class Location
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public Cliente Cliente { get; set; }
        public List<ModelCar> Car { get; set; } = new List<ModelCar>();

        public Location()
        {
        }

        public Location(int id, DateTime date, double price, Cliente cliente)
        {
            Id = id;
            Date = date;
            Price = price;
            Cliente = cliente;           
        }
    }
}
