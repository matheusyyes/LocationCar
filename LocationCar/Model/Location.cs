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
        public ModelCar Car { get; set; }

        public Location()
        {
        }

        public Location(int id, DateTime date, double price, Cliente cliente, ModelCar car)
        {
            Id = id;
            Date = date;
            Price = price;
            Cliente = cliente;
            Car = car;
        }
    }
}
