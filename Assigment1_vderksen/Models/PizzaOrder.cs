// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
using System.Collections.ObjectModel;

namespace Assigment1_vderksen.Models
{
    public class Pizza
    {
        private int _quantity;
        private string _topping;
        private string _size;
        private double _price;
        private double _total;

        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string topping
        {
            get { return _topping; }
            set { _topping = value; }
        }

        public string size
        {
            get { return _size; }
            set { _size = value; }
        }

        public double price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double total
        {
            get { return _total; }
            set { _total = value; }
        }
        public Pizza()
        {
            this.quantity = 0;
            this.topping = null;
            this.size = null;
            this.price = 0;
            this.total = 0;
        }
        public Pizza(int qty, string t, string s)
        {
            this.quantity = qty;
            this.topping = t;
            this.size = s;
            this.price = GetPrice(size);
            this.total = GetTotal();
        }

        public double GetPrice(string size)
        {
            double price = 0.0;
            switch (size)
            {
                case "Small":
                    price = 10.0;
                    break;
                case "Medium":
                    price = 12.0;
                    break;
                case "Large":
                    price = 15.0;
                    break;
                case "Party":
                    price = 20.0;
                    break;
            }

            return price;
        }

        public double GetTotal()
        {
            return this.total = this.quantity * this.price;
        }
    }

}
