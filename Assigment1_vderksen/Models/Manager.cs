// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assigment1_vderksen.Models
{
    public class Manager
    {
        public List<Topping> toppings = new List<Topping>(); // create topping list
        public List<PizzaSize> sizes = new List<PizzaSize>(); // create sizes list 
        public ObservableCollection<Pizza> Order = new ObservableCollection<Pizza>(); // create order collections for pizza objects
        public ObservableCollection<OrderInfo> History = new ObservableCollection<OrderInfo>(); // create history collections for orders objects


        // SET LIST OF TOPPINGS and LIST OF SIZES with initial values
        public void addTopping(Topping t)
        {
            toppings.Add(t);
        }

        public void addSize(PizzaSize s)
        {
            sizes.Add(s);
        }

        public Manager()
        {
            toppings.Add(new Topping("Vegetables"));
            toppings.Add(new Topping("Meat Balls"));
            toppings.Add(new Topping("Pepperoni"));
            toppings.Add(new Topping("Mashrooms"));
            sizes.Add(new PizzaSize("Small"));
            sizes.Add(new PizzaSize("Medium"));
            sizes.Add(new PizzaSize("Large"));
            sizes.Add(new PizzaSize("Party"));
        }


        // ADD NEW PIZZA TO THE ORDER
        public void addPizza(Pizza item)
        {
            Order.Add(item);
        }

        // REMOVE PIZZA FROM THE ORDER
        public void deletePizza(Pizza item)
        {
            Order.Remove(item);
        }

        // CALCULATE TOTAL NUMBER PIZZAS IN THE ORDER
        public int getTotalOrderQty()
        {
            int totalQty = 0;
            for (int i = 0; i < Order.Count; i++)
            {
                totalQty += Order[i].quantity;
            }
            return totalQty;
        }

        // CALCULATE TOTAL ORDER PRICE
        public double getTotalOrderPrice()
        {
            double totalPrice = 0;
            for (int i = 0; i < Order.Count; i++)
            {
                totalPrice += Order[i].total;
            }
            return totalPrice;
        }

        // ADD NEW ORDER TO HISTORY COLLECTION
        public void addOrder(OrderInfo item)
        {
            History.Add(item);
        }

        // RESET ORDER COLLECTION
        public void resetOrder()
        {
            while (Order.Count > 0)
            {
                Order.RemoveAt(Order.Count - 1);
            }
        }

    }
}
