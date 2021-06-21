// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment1_vderksen.Models;
using Xamarin.Forms;

namespace Assigment1_vderksen
{
    public partial class MainPage : ContentPage
    {
        Manager manager;

        public MainPage(Manager m)
        {
            InitializeComponent();
            manager = m;

            // initialize toppings and sizes list views
            toppingsList.ItemsSource = manager.toppings;
            sizesList.ItemsSource = manager.sizes;

            // set labels text to initial state
            quantityEntered.Text = "0";
            toppingEntered.Text = "None";
            sizeEntered.Text = "None";
        }

        // ADD NEW PIZZA TO THE ORDER COLLECTION
        void addNewPizza(System.Object sender, System.EventArgs e)
        {
            // get text from labels quantuty, topping and size
            int qty = Int32.Parse(quantityEntered.Text);
            string top = toppingEntered.Text;
            string size = sizeEntered.Text;

            if(qty == 0)
                DisplayAlert("Order is incomplete", "Please, Choose the Pizza Quantity", "OK");
            else if(top == "None")
                DisplayAlert("Order is incomplete", "Please, Choose the Pizza Topping", "OK");
            else if(size == "None")
                DisplayAlert("Order is incomplete", "Please, Choose the Pizza Size", "OK");
            else
            {
                // pass quantuty, topping and size to create new Pizza object
                Pizza newPizza = new Pizza(qty, top, size);

                // add new Pizza object to Order collection
                manager.addPizza(newPizza);

                // display alert message with the order info
                var mes = "Your order has now " + manager.getTotalOrderQty() + " pizzas, and the total is " + manager.getTotalOrderPrice() + " CND";
                DisplayAlert("Success!!", mes, "OK");
            }
        }

        // enter quantity from 0 to 9
        public void Number_Clicked(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            quantityEntered.Text = ((Button)sender).Text;
        }

        // RESET TEXT FOR LABELS QUANTUTY, TOPPING AND SIZE
        public void resetOrder(object sender, EventArgs e)
        {
            quantityEntered.Text = "0";
            toppingEntered.Text = "None";
            sizeEntered.Text = "None";
        }

        // SELECT TOPPING FROM THE LIST
        private void toppingsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                toppingEntered.Text = (e.SelectedItem as Topping).name; // pass to the label the topping name
                ((ListView)sender).SelectedItem = null; // inselect the item from the list
            }
        }

        // SELECT SIZE FROM THE LIST
        private void sizesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                sizeEntered.Text = (e.SelectedItem as PizzaSize).name; // pass to the label the size name
                ((ListView)sender).SelectedItem = null; // inselect the item from the list
            }
        }

        // NAVIGATION TO MY ORDER PAGE
        async void viewOrder(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage(manager));
        }

    }
}
