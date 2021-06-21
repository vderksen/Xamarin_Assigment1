// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
using System.Collections.Generic;
using Assigment1_vderksen.Models;
using Xamarin.Forms;

namespace Assigment1_vderksen
{
    public partial class MyOrder : ContentPage
    {
        Manager manager;

        public MyOrder(Manager m)
        {
            InitializeComponent();
            manager = m;

            // initialize list view and bind it to the Order collection
            pizzasList.ItemsSource = manager.Order;

            // set labels text
            totalQty.Text = ("Ordered " + manager.getTotalOrderQty() + " Pizzas" ); 
            totalPrice.Text = ("Total Price is $" + manager.getTotalOrderPrice()); 
        }

        // PLACE THE ORDER, ADD CURRENT ORDER TO HISTORY LIST AND NAVIGATION TO NEW MENU PAGE
        async void placeOrder(System.Object sender, System.EventArgs e)
        {
            // if no pizza in the current order
            if(manager.Order.Count == 0)
            {
                // display alert message with the error message
                DisplayAlert("Not able to place the Oder", "Please, add a Pizza to the Order", "OK");
            }

            // if there are one or more pizzas in the order
            else
            {
                // pass quantuty, topping and size to create new Pizza object
                double total = manager.getTotalOrderPrice();
                OrderInfo newOrder = new OrderInfo(total);

                // add new Pizza object to Order collection
                manager.addOrder(newOrder);

                // display alert message with the order info
                DisplayAlert("Thank you!", "Your order is placed", "OK");

                // reset the current order to empty state
                manager.resetOrder();

                // navigate to main page
                await Navigation.PushAsync(new MainPage(manager));
            }
        }

        // REMOVE PIZZA FROM THE CURRENT ORDER
        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var toDelete = (sender as MenuItem).CommandParameter as Pizza;
            manager.deletePizza(toDelete);
            totalQty.Text = ("Ordered " + manager.getTotalOrderQty() + " Pizzas");
            totalPrice.Text = ("Total Price is $" + manager.getTotalOrderPrice());
        }
    }
}
